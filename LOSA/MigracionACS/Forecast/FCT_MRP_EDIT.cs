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
using LOSA.MigracionACS.DataSetx;
using ACS.Classes;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.MigracionACS.Forecast
{
    public partial class FCT_MRP_EDIT : DevExpress.XtraEditors.XtraForm
    { DataOperations dp;
        int idofMRP;
        public FCT_MRP_EDIT()
        {
            InitializeComponent();
            dp = new DataOperations();
            Load_Data();
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();

        }
        public void Load_Data()
        {
            try
            {
                string Query;
                Query = @" SELECT A.[id]
                            ,A.[nombre]
                            ,B.[nombre] AS usuario
                            ,(CASE WHEN status = 'a'
	                            then 1
                            else 0 end) as status
                            ,(Case when comentario is null
                                then 'Agrega un comentario...'
                            else comentario end) as comentario
                    FROM [dbo].[FCT_MRP] A
                    INNER JOIN [dbo].[conf_usuarios] B ON A.[usuario_c] = B.[id]";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                fCTData.MRP.Clear();
                da.Fill(fCTData.MRP);

            }
            catch (Exception)
            {

               
            }
            

        }

        private void repositoryItemCheckEdit1_Click(object sender, EventArgs e)
        {
            var GridView = (GridView)gridControl1.FocusedView;
            var Row = (FCTData.MRPRow)GridView.GetFocusedDataRow();
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
                barEditItem3.Enabled = true;
                barEditItem3.EditValue = Row.comentario;
                idofMRP = Convert.ToInt32(Row.id.ToString());
                barButtonItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;

            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Se va restablecer la configuracion","Restablecer",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
            {
                Load_Data();


            }
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("¿Desea guardar los cambios?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id, status; dp = new DataOperations();

                foreach (DataRow rows in fCTData.MRP.Rows)
                {
                    try
                    {

                        if (Convert.ToBoolean(rows["status"].ToString()))
                        {
                            status = 1;
                        }
                        else
                        {
                            status = 0;
                        }

                        id = Convert.ToInt32(rows["id"].ToString());
                        string queryup;
                        queryup = @"EXEC MRP_Update_Status @id = " + id + ", @status = " + status + ",@comentario = '"+rows["comentario"]+@"' ;";
                        SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                        cn.Open();
                        SqlCommand cmd = new SqlCommand(queryup, cn);
                        cmd.ExecuteNonQuery();
                        cn.Close();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar los datos. Contacte con el administrador.: " + ex.Message, "Actualizar");
                    }


                }
                if (MessageBox.Show("Se ha guardado con exito, ¿Desea cerrar?", "Guardar y cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.DialogResult = DialogResult.Yes;
                    this.Close();
                }

            }

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (DataRow row in fCTData.MRP.Rows)
            {
                if (Convert.ToInt32(row["id"].ToString()) == idofMRP)
                {
                    row["comentario"] = barEditItem3.EditValue;
                }
            }
        }

        private void repositoryItemTextEdit3_EditValueChanged(object sender, EventArgs e)
        {
          
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            var GridView = (GridView)gridControl1.FocusedView;
            var Row = (FCTData.MRPRow)GridView.GetFocusedDataRow();
            string input = Microsoft.VisualBasic.Interaction.InputBox("Agrega un comentario", "Ingresa un comentario al cambio", Row.comentario.ToString(), -1, -1);
            if (input != Row.comentario)
            {
                Row.comentario = input;

            }
        }
    }
}