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

namespace LOSA.Compras
{
    public partial class frmKardexDetalle : DevExpress.XtraEditors.XtraForm
    {
        string Capitulo;
        string PartidaArancelaria;
        public frmKardexDetalle(string pcapitulo, string ppartida_aran)
        {
            InitializeComponent();

            txtCapitulo.Text = Capitulo = pcapitulo;
            txtPartidaArancelaria.Text = PartidaArancelaria = ppartida_aran;
            if (PartidaArancelaria.Length > 2)
            {
                txtPartidaArancelaria.Visible = true;
                labelControl1.Visible = true;
            }
            else
            {
                txtPartidaArancelaria.Visible = false;
                labelControl1.Visible = false;
            }
            LoadData();

        }

        private void LoadData()
        {
            try
            {
                try
                {
                    DataOperations dp = new DataOperations();
                    string query = @"sp_get_detalle_por_capitulo_y_partida";
                    SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Capitulo",Capitulo);
                    cmd.Parameters.AddWithValue("@PartidaArancelaria",PartidaArancelaria);
                    if (PartidaArancelaria.Length > 2)
                        cmd.Parameters.AddWithValue("@tipo_busqueda", 2);
                    else
                        cmd.Parameters.AddWithValue("@tipo_busqueda", 1);
                    SqlDataAdapter adat = new SqlDataAdapter(cmd);
                    dsCompras1.kardex_detalle.Clear();
                    adat.Fill(dsCompras1.kardex_detalle);
                    conn.Close();
                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}