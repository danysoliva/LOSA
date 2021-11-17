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
    public partial class xfrmLotesPorTanque : DevExpress.XtraEditors.XtraForm
    {
        int id_taque;
        UserLogin usuarioLogueado = new UserLogin();
        public xfrmLotesPorTanque(int pIdTanque,UserLogin userLogged)
        {
            InitializeComponent();
            id_taque = pIdTanque;
            usuarioLogueado = userLogged;
            LoadIngresosLiquidos();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {

                string code_mp="";
                MateriaPrima mp = new MateriaPrima();

                foreach (var item in dsLiquidos_.LOSA_Ingreso_liquidos)
                {
                    code_mp = item.codigo_mp;
                }

                if (grdv_boleta.RowCount==0)
                {
                    xfrmChooseMP frm = new xfrmChooseMP(id_taque,usuarioLogueado);

                    frm.ShowDialog();

                }
                else
                {
                    if (mp.RecuperarRegistroFromCode(code_mp))
                    {
                        frmIngresoCamion frm = new frmIngresoCamion(usuarioLogueado,mp,id_taque);

                        frm.Show();
                    }
                    
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void LoadIngresosLiquidos()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);

                string SQL = @"dbo.sp_get_ingresos_liquidos_by_tanque";
                SqlCommand cmd = new SqlCommand(SQL, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id_tanque", SqlDbType.Int).Value = id_taque;

                dsLiquidos_.LOSA_Ingreso_liquidos.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsLiquidos_.LOSA_Ingreso_liquidos);

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            LoadIngresosLiquidos();
        }
    }
}