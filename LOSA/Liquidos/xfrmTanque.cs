using ACS.Classes;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LOSA.Liquidos.xfrmTanqueCRUD;

namespace LOSA.Liquidos
{
    public partial class xfrmTanque : DevExpress.XtraEditors.XtraForm
    {
        public xfrmTanque()
        {
            InitializeComponent();
            LoadTanques();
        }


        private void LoadTanques()
        {
            try
            {

                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringCostos))
                {
                    cnx.Open();

                    dsLiquidos_.Tanque.Clear();

                    SqlDataAdapter da = new SqlDataAdapter("dbo.sp_get_tanques", cnx);
                    da.Fill(dsLiquidos_.Tanque);

                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnEditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var row = (dsLiquidos_.TanqueRow)gvTanque.GetFocusedDataRow();

                if (row!=null)
                {
                    xfrmTanqueCRUD frm = new xfrmTanqueCRUD(row.id,row.descripcion,Convert.ToInt32( ModoForm.editar));

                    if (frm.ShowDialog()== DialogResult.OK)
                    {
                        LoadTanques();
                    }

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            xfrmTanqueCRUD xfrm = new xfrmTanqueCRUD(0,null,Convert.ToInt32(ModoForm.nuevo));

            if (xfrm.ShowDialog()== DialogResult.OK)
            {
                LoadTanques();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (XtraMessageBox.Show("DESEA ELIMINAR ESTE REGISTRO?", "Confirmation", MessageBoxButtons.YesNo) != DialogResult.No)
            {
                try
                {
                   DataOperations dp = new DataOperations();
                    SqlConnection dbConnection = new SqlConnection(dp.ConnectionStringCostos);


                    var row = (dsLiquidos_.TanqueRow)gvTanque.GetFocusedDataRow();

                    using (SqlCommand command = new SqlCommand("dbo.sp_delete_tanque", dbConnection))
                    {
                        dbConnection.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@id", SqlDbType.Int).Value = row.id;

                        command.ExecuteNonQuery();
                        dbConnection.Close();

                       LoadTanques();
                    }
                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }
            }
        }
    }
}