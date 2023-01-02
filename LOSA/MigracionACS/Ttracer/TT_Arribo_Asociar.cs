using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACS.Classes;
using System.Data.SqlClient;

namespace LOSA.MigracionACS.Ttracer
{
    public partial class TT_Arribo_Asociar : Form
    {
        public int id;
        string Typesugerido = "";
        public int status = 10;
        public string codigoGen;
        int Idtipo = 0;
        DataOperations dp = new DataOperations();
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public TT_Arribo_Asociar(int IDArribDetalle,string codigoGen, string Itemcode, string ItemName, string Cardname, string Cardcode, DateTime fecharrando, Decimal quantity,
            Boolean habilitado, int estado, string comentario , int idvhe, Boolean granel, int tipo, int Idunidad)
        {
            InitializeComponent();
            id = IDArribDetalle;
            load_estados(estado);
            load_vehiculos();
            if (codigoGen == "NO")
            {
                codigoGen = dp.Nexcode(6);
                txtcodigoGen.Text = codigoGen;
                status = 20;
            }
            else
            {
                txtcodigoGen.Text = codigoGen;
            }
            txtItemCode.Text = Itemcode;
            if (Itemcode == "")
            {
                Typesugerido = "PT";
            }else
	        {
                Typesugerido = Itemcode.Substring(0,2);
            }
            txtItemName.Text = ItemName;
            grdtipo.EditValue = tipo;
            txtCardName.Text = Cardname;
            txtCardCode.Text = Cardcode;
            txtdate.Text = String.Format("{0:yyyy-MM-dd}",fecharrando);
            txtcantidad.Text = Convert.ToString(quantity);
            tgghabilitado.IsOn = habilitado;
            grdvehiculo.EditValue = idvhe;
            txtcomment.Text = comentario;
            if (granel)
            {
                tgggrael.IsOn = true;

            }
            else
            {
                tgggrael.IsOn = false;
            }
            if (estado < 70)
            {
                tgghabilitado.IsOn = true;
            }
            else
            {
                tgghabilitado.IsOn = false;
            }
            grd_unidades.EditValue = Idunidad;
            load_tipos();
            load_datas();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void load_datas()
        {
            string query = @"SELECT [id]
                                  ,[descripcion]
                              FROM [dbo].[M_unidades]
                              where enable = 1";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringBascula);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dSTtracer.unidades.Clear();
                da.Fill(dSTtracer.unidades);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void load_tipos()
        {

            if (Typesugerido == "CO" || Typesugerido == "SV" || Typesugerido == "DS" || Typesugerido == "RM" || Typesugerido == "RS") // LOS FILTROS DE ITEMS SE CAMBIAN SEGUN EL TIPO SELECCIONADO.
            {
                Typesugerido = "NA";
            }
            string query = @"SELECT T0.[id]
                            ,T0.[descripcion] as descrip
                        FROM [dbo].[M_tipo_op] T0
                        where T0.enable = 1 and  t0.codigo = '" + Typesugerido + @"' union all
                            SELECT T0.[id]
                            ,T0.[descripcion] as descrip
                        FROM [dbo].[M_tipo_op] T0
                        where T0.enable = 1 and  t0.codigo NOT IN ('CO','PT','MP','ME','NA')";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringBascula);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dSTtracer.tipoitems.Clear();
                da.Fill(dSTtracer.tipoitems);
                cn.Close();
                if (Typesugerido == "MP" && tgggrael.Enabled == true)
                {
                    grdtipo.EditValue = 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        
        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        public void load_estados(int estado)
        {
            string Query = @"SELECT  [id]
                      ,[Descripcion]
                  FROM [dbo].[M_estatus]
                    where id >= "+ estado + @"and id not like 70
                  union all
                  Select id,Descripcion 
                  from dbo.M_estatus
                  where id = 70 ";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringBascula);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query,cn);
                dSTtracer.tableconfig.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dSTtracer.tableconfig);
                cn.Close();
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void load_vehiculos()
        {
            string query = @"SELECT T0.[id]
                              ,T0.[idvehiculo]
	                          ,T1.[placa]
                              ,Coalesce(T0.[idfurgon], 0) as idfurgon
	                          ,Coalesce((Select top 1 T4.container 
					                        from [dbo].[M_furgon] T4 where T4.id = T0.idfurgon), 'No admite furgon')  as [N_Furgon]
                              ,T0.[enable]
                              ,T2.descripcion as [Tipos]
                          FROM [dbo].[conf_vehiculos] T0 INNER JOIN [dbo].[M_vehiculo] T1 ON T0.idvehiculo = T1.id
								                         INNER JOIN [dbo].[M_tipos_vehi] T2 On T1.idtipo = T2.id
														 
							union all
							Select 0,0,'Quitar configuracion',0,'Sin configuracion', 1, 'Sin tipos'
							
	                        Order by 1 desc";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringBascula);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                dSTtracer.confvehi.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dSTtracer.confvehi);
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
          
        }

        private void panelControl2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lbname_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Estado = 0, vehiculo = 0;
            int bitGranel = 0;
            try
            {
                if (txtcodigoGen.Text == "Procesando..")
                {
                    MessageBox.Show("El campo de codigo no puede quedar vacio. Revise los datos imputados.");
                    return;
                }
                if (txtCardName.Text == "")
                {
                    MessageBox.Show("El nombre del proveedor no puede quedar vacio.");
                    return;
                }
                if (txtcantidad.Text == "")
                {
                    MessageBox.Show("Debe colocar a menos 0 en el campo.");
                    return;
                }
                if (txtcomment.Text == "")
                {
                    MessageBox.Show("Documento debe de tener al menos un comentario para poder ser guardado.");
                    return;

                }
                if (Convert.ToInt32(grdvehiculo.EditValue) == 0)
                {
                    if (MessageBox.Show("Se esta guardando un arribo sin configurar un vehiculo debe tener en cuenta que no podra entrar sin asignarle un vehiculo.","Advertencia",MessageBoxButtons.OKCancel, MessageBoxIcon.Hand) ==DialogResult.OK )
                    {
                        vehiculo = 0;
                        status = 20;
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    try
                    {
                        vehiculo = Convert.ToInt32(grdvehiculo.EditValue);
                        status = 30;
                    }
                    catch (Exception)
                    {

                    }
                }
                if (grdtipo.EditValue == DBNull.Value)
                {
                    Idtipo = 0;
                    status = 20;
                }
                else
                {
                    if (Convert.ToInt32(grdtipo.EditValue) == 0)
                    {
                        Idtipo = 0;
                        status = 20;
                    }
                    else
                    {
                        Idtipo = Convert.ToInt32(grdtipo.EditValue);
                    }
                }
                if (tgghabilitado.IsOn )
                {
                    
                }
                else
                {
                    status = 70;
                }
               

                if (tgggrael.IsOn)
                {
                    bitGranel = 1;
                }
                else
                {
                    bitGranel = 0;
                }
                string Alfa;
                Alfa = @"UPDATE [dbo].[DC_workplan_d]
                               SET 
                                 [descriprove] = @Desprov
                                  ,[descripitem] = @desitem
                                  ,[quantityplan] = @quantity
                                  ,[dateplanarribe] = @dateplan
                                  ,[idconfvehi] = @idconf
                                  ,[status] = @idstatus
                                  ,[comment] = @comentario
                                  ,[codigoGen] = @codigo
                                  ,typeid = @Typeid
                                  ,Idunidad = @unidad
                             WHERE id =" + id;
                try
                {
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringBascula);
                    cn.Open();

                    SqlCommand cmd = new SqlCommand(Alfa, cn);
                    if (Convert.ToInt32(grd_unidades.EditValue)  == 0)
                    {
                        cmd.Parameters.Add("@unidad", SqlDbType.Int).Value = DBNull.Value;
                    }
                    else
                    {
                        cmd.Parameters.Add("@unidad", SqlDbType.Int).Value = grd_unidades.EditValue;
                    }
                    cmd.Parameters.Add("@Desprov", SqlDbType.VarChar).Value = txtCardName.Text;
                    cmd.Parameters.Add("@desitem", SqlDbType.VarChar).Value = txtItemName.Text;
                    cmd.Parameters.Add("@quantity", SqlDbType.Decimal).Value = txtcantidad.Text;
                    cmd.Parameters.Add("@dateplan", SqlDbType.Date).Value = Convert.ToDateTime(txtdate.Text).Date;
                    cmd.Parameters.Add("@idconf", SqlDbType.Int).Value = vehiculo;
                    cmd.Parameters.Add("@idstatus", SqlDbType.Int).Value = status;
                    cmd.Parameters.Add("@comentario", SqlDbType.VarChar).Value = txtcomment.Text;
                    cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = txtcodigoGen.Text;
                    cmd.Parameters.Add("@Typeid", SqlDbType.Int).Value = Idtipo;
                    cmd.ExecuteNonQuery();
                    dp.Nexcode(6);
                    
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    
                }
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.DialogResult = DialogResult.OK;
        }

        private void txtdate_EditValueChanged(object sender, EventArgs e)
        {
          
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar la orden de compra de la planeacion?","Advertencia",MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    string Query = @"UPDATE [dbo].[DC_workplan_d]
                                           SET 
                                             [enable] = 0
                                         WHERE id =" + id;
                    dp.ACS_DoSmallDBOperationBas(Query);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
