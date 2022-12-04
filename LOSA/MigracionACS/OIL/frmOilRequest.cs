using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using LOSA.Clases;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;
using ACS.Classes;

namespace LOSA.MigracionACS.OIL
{
    public partial class frmOilRequest : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        DataOperations dp;
        public frmOilRequest(UserLogin pUser)
        {
            InitializeComponent();
            dp = new DataOperations();
            UsuarioLogeado = pUser;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmTipoReq frm = new frmTipoReq();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                switch (frm.tipo)
                {
                    case 0:
                        break;
                    case 1:
                        frmOilSingle frmx = new frmOilSingle(this.UsuarioLogeado);
                        if(frmx.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            CargarRequisiciones();
                        break;
                    case 2:
                        MessageBox.Show("No se han definido los porcentajes de inclusion para un producto Mix.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
        }

        private void CargarRequisiciones()
        {
            try
            {
                string sql = @"SELECT distinct hh.[id]
                                        ,[fecha_p],
	                                    case when dd.process = 1 then
		                                'En Proceso'
	                                    else
		                                case when dd.complete = 1 then
			                                'Completada'
		                                else
			                                'Pendiente'
		                                end
	                                    end as estado,
	                                    rd.long_name as material,
			                            (select sum(dd1.cant)
			                             from [dbo].[oil_req_h] hh1 join
		                                      [dbo].[oil_req_d] dd1 on
				                              hh1.id = dd1.id_requisicion
			                             where hh1.id = hh.id and
			                                   dd1.id_rm = dd.id_rm) as Cant,
                                        (SELECT [nombre]
                                         FROM [AQFSVR003].ACS.[dbo].[conf_usuarios] uss
                                         where uss.[id] = hh.id_usuario) as usuario
                                FROM [dbo].[oil_req_h] hh join
                                        [dbo].[oil_req_d] dd 
	                                    on hh.id = dd.id_requisicion join
	                                    MD_Raw_Material rd 
	                                    on rd.id = dd.id_rm
                                order by hh.[id] desc";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringAPMS);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsAceites1.requisiciones.Clear();
                adat.Fill(dsAceites1.requisiciones);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Detalle del Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmOilRequest_Load(object sender, EventArgs e)
        {
            CargarRequisiciones();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            CargarRequisiciones();
        }

        private void cmdDetalles_column_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsAceites.requisicionesRow)gridView.GetFocusedDataRow();

            if (row.estado == "Completada")
            {
                frmDetalle frm = new frmDetalle(row.id);
                frm.ShowDialog();
            }
            else
            {
                CajaDialogo.Error("Esta Requisicion aun no ha sido completada!\nCuando la requisicion se haya completado podra ver el detalle...");
            }
        }

        private void ButtonEliminar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridvieWs = (GridView)gridControl1.FocusedView;
            var row = (dsAceites.requisicionesRow)gridvieWs.GetFocusedDataRow();
            int idreques = row.id;
            if (row.estado == "Completada")
            {
                CajaDialogo.Error("No es posible eliminar una Requesicion que ya se ha completado!");
                return;
            }
            else if (row.estado == "En Proceso")
            {
                string Quere;
                try
                {
                    idreques = row.id;
                    dp = new DataOperations();
                    Quere = @"Select 
                                    coalesce(SUM(A.cant),0) as suma
		                    from APMS.DBO.oil_transfers a join
			                        APMS.dbo.oil_req_d b on
			                        a.id_req_d = b.id join 
			                        APMS.dbo.oil_req_h c on
			                        b.id_requisicion = c.id
		                    where c.id = " + idreques;
                    SqlConnection nc = new SqlConnection(dp.ConnectionStringAPMS);
                    nc.Open();
                    SqlCommand cmd = new SqlCommand(Quere, nc);
                    int Sum = Convert.ToInt32(cmd.ExecuteScalar());
                    if (Sum > 0)
                    {
                        CajaDialogo.Error("No se puede eliminar la requesicion por que se ha iniciado el traslado de Aceite.");
                        return;
                    }
                    else
                    {
                        string DeleRe;
                        DeleRe = @"DELETE FROM [dbo].[oil_req_d]
                                WHERE id_requisicion = " + idreques + ";" + @"
                            
                                DELETE FROM [dbo].[oil_req_h]
                                WHERE id = " + idreques + ";";
                        cmd = new SqlCommand(DeleRe, nc);
                        DialogResult result = MessageBox.Show("Se va eliminar la Requesicion en proceso"," Eliminar",MessageBoxButtons.YesNo);
                        if (result == System.Windows.Forms.DialogResult.Yes)
                        {
                            cmd.ExecuteNonQuery();
                            CargarRequisiciones();
                            

                        }
                        else
                        {
                            return;
                        }

                    }
                }
                catch (Exception)
                {

                    throw;
                }  
               
               
            }
            else if (row.estado == "Pendiente")
            {
                string DeleRe;
                DeleRe = @"DELETE FROM [dbo].[oil_req_d]
                                WHERE id_requisicion = " + idreques + ";" + @"
                            
                                DELETE FROM [dbo].[oil_req_h]
                                WHERE id = " + idreques + ";";

                SqlConnection nc = new SqlConnection(dp.ConnectionStringAPMS);
                nc.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand(DeleRe, nc);
                    DialogResult result = MessageBox.Show("Se va eliminar la Requesicion en proceso", " Eliminar", MessageBoxButtons.YesNo);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        CargarRequisiciones();
                    }
                    else
                    {
                        return;
                    }
                }
                catch (Exception ec)
                {
                    CajaDialogo.Error(ec.Message);
                }
                
            }
        }
    }
}