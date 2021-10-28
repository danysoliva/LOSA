using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ACS.Classes;
using LOSA.Clases;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.Nir
{
    public partial class frmUnirLigaduras : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        string Sap;
        string odoo;
        string MP;
        int id_lote;
        string lote;
        int n_referencia;
        DataOperations dp = new DataOperations();

        public frmUnirLigaduras(UserLogin Puser,
                                string pSap,
                                string podoo,
                                string pMP,
                                int pid_lote,
                                string plote,
                                int pn_referencia)
        {
            InitializeComponent();
            UsuarioLogeado = Puser;
            Sap = pSap;
            odoo = podoo;
            MP = pMP;
            id_lote = pid_lote;
            lote = plote;
            n_referencia = pn_referencia;
            txtingreso.Text = n_referencia.ToString();
            txtlote.Text = lote;
            txtmp.Text = MP;
            txtsap.Text = Sap;
            txtodoo.Text = odoo;
            load_Data();
                
        }
          public void load_Data() 
        {
            string Query = @"sp_load_ingreso_lecturas_ingreso_lote_nir";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_ingreso", id_lote);
                dsNir.lecturas_ingreso.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsNir.lecturas_ingreso);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnUnir_Click(object sender, EventArgs e)
        {
            try
            {
                frmSeleccionarLectura frm = new frmSeleccionarLectura(UsuarioLogeado, id_lote);
                if (frm.ShowDialog()== DialogResult.OK)
                {

                    load_Data();
                    
                }


            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnDesvincular_Click(object sender, EventArgs e)
        {
            
                if (CajaDialogo.Pregunta("Deseas disvincular esta lectura?") == DialogResult.Yes)
                {
                    try
                    {
                        var gridView = (GridView)grd_lecturas.FocusedView;
                        var row = (dsNir.lecturas_ingresoRow)gridView.GetFocusedDataRow();
                        
                            string query = @"sp_delete_link_ingreso_lectura_nir";
                            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                            cn.Open();
                            SqlCommand cmd = new SqlCommand(query, cn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_lectura", row.id);
                            cmd.ExecuteNonQuery();

                            load_Data();
                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                    }
                }
           
        }
    }
}