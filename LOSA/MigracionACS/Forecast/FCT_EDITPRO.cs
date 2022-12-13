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
using ACS.Classes;
using System.Data.SqlClient;
using DevExpress.Charts.Native;
using LOSA.MigracionACS.DataSetx;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.MigracionACS.Forecast
{
    public partial class FCT_EDITPRO : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp;
        
        public FCT_EDITPRO()
        {
            InitializeComponent();
            dp = new DataOperations();
            load_data();



        }
        public void load_data()
        {
            try
            {
                string Query;
                //Query = @"SELECT [id]
                //     ,[code]
                //     ,[name]
                //     ,(CASE when status < 40 then 0
                //     when status > 80 then 0
                //     else 1 end) as status
                //        ,(Case when Comentario is null
                //                then 'Agrega un comentario...'
                //            else Comentario end) as comentario
                //    FROM [dbo].[FCT_Proyecciones_Ventas_v2]";
                Query = "sp_get_proyecciones_ventas_manto";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@visible_cerradas", toggleSwitch1.IsOn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                fCTData.__FCT_Proyecciones_Ventas_v2_.Clear();
                da.Fill(fCTData.__FCT_Proyecciones_Ventas_v2_);
                cn.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Problema al cargar los datos, contactar con el administrador.","Advertencia");
            }  
        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Si no ha guardado los cambios puede ser que se pierdan","Advertencia de datos no guardados",MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_Refresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (MessageBox.Show("Si no ha guardado los cambios se perderan.", "Refrescar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                load_data();
            }

        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("¿Desea guardar los cambios?","Guardar",MessageBoxButtons.YesNo,MessageBoxIcon.Question) ==DialogResult.Yes)
            {
                //int id, status;
                dp = new DataOperations();


                try
                {
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                    cn.Open();
                    //foreach (DataRow rows in fCTData.__FCT_Proyecciones_Ventas_v2_.Rows)
                    foreach (FCTData.__FCT_Proyecciones_Ventas_v2_Row rows in fCTData.__FCT_Proyecciones_Ventas_v2_.Rows)
                    {


                        //if (Convert.ToBoolean(rows["status"]))
                        //{
                        //    status = 1;
                        //}
                        //else
                        //{
                        //    status = 0;
                        //}

                        //id = rows.id;
                        string queryup;
                        queryup = @"FCT_Proyecciones_Ventas_v2_Update_status";//  = " +
                                    //id + ", @status = " + rows.status + ", @comentario = '" + rows.comentario + @"';";
                        
                        SqlCommand cmd = new SqlCommand(queryup, cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", rows.id);
                        cmd.Parameters.AddWithValue("@status",rows.status);
                        cmd.Parameters.AddWithValue("@comentario",rows.comentario);
                        cmd.ExecuteNonQuery();
                        
                    }
                    cn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar los datos. Contacte con el administrador.: " + ex.Message, "Actualizar");
                }
                
                //if (MessageBox.Show("Se ha guardado con exito, ¿Desea cerrar?", "Guardar y cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    CajaDialogo.InformationAuto();
                    this.DialogResult = DialogResult.Yes;
                    this.Close();
                }

            }
        }

        private void repositoryItemCheckEdit1_Click(object sender, EventArgs e)
        {
            var GridView = (GridView)gridControl1.FocusedView;
            var Row = (FCTData.__FCT_Proyecciones_Ventas_v2_Row)GridView.GetFocusedDataRow();
            try
            {
                if (Row.status)
                {
                    Row.status = false;
                }
                else
                {
                    Row.status = true;
                }

            }
            catch (Exception)
            {

               
            }
           
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            var GridView = (GridView)gridControl1.FocusedView;
            var Row = (FCTData.__FCT_Proyecciones_Ventas_v2_Row)GridView.GetFocusedDataRow();
            FCT_Manten fctMan = new FCT_Manten(Row.id);
            if (fctMan.ShowDialog() == DialogResult.OK)
            {
                load_data();

            }

        }

        private void repositoryItemButtonEdit2_Click(object sender, EventArgs e)
        {
            var GridView = (GridView)gridControl1.FocusedView;
            var Row = (FCTData.__FCT_Proyecciones_Ventas_v2_Row)GridView.GetFocusedDataRow();
            string input = Microsoft.VisualBasic.Interaction.InputBox("Agrega un comentario", "Ingresa un comentario al cambio", Row.comentario.ToString(), -1, -1);
            if (input != Row.comentario)
            {
                Row.comentario = input;

            }
        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            load_data();
        }
    }
}