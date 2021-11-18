using ACS.Classes;
using DevExpress.XtraEditors;
using LOSA.Clases;
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

namespace LOSA.Liquidos
{
    public partial class xfrmChooseMP : DevExpress.XtraEditors.XtraForm
    {
        int id_tanque;
        UserLogin usuarioLogueado;

        public xfrmChooseMP(int pId_tanque,UserLogin userLogged)
        {
            InitializeComponent();
            id_tanque = pId_tanque;
            usuarioLogueado = userLogged;
            LoadMP();
        }


        private void LoadMP()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringBascula);

                string SQL = @"dbo.sp_get_MP_disponible_liquidos_tanque";
                SqlCommand cmd = new SqlCommand(SQL, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@codigo_barra", "");
                dsLiquidos_.Materia_prima.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsLiquidos_.Materia_prima);

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelect_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {

                ItemMP_Lote mp = new ItemMP_Lote();
                var row = (dsLiquidos_.Materia_primaRow)gvMP.GetFocusedDataRow();

                if (row!= null)
                {
                    mp.Card_Name= row.Producto;
                    mp.ItemCode = row.itemcode;

                    frmIngresoCamion frm = new frmIngresoCamion(usuarioLogueado,mp,id_tanque);

                    frm.ShowDialog();

                    this.Close();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}