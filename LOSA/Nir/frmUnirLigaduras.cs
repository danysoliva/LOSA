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
        int id_lote, id_mp;
        string lote;
        int n_transaccion;
        DataOperations dp = new DataOperations();

        //public frmUnirLigaduras(UserLogin Puser,
        //                        string pSap,
        //                        string podoo,
        //                        string pMP,
        //                        int pid_lote,
        //                        string plote,
        //                        int pn_referencia)
        //{
        //    InitializeComponent();
        //    UsuarioLogeado = Puser;
        //    Sap = pSap;
        //    odoo = podoo;
        //    MP = pMP;
        //    id_lote = pid_lote;//Id_ingreso
        //    lote = plote;
        //    n_transaccion = pn_referencia;
        //    txtingreso.Text = n_transaccion.ToString();
        //    txtlote.Text = lote;
        //    txtmp.Text = MP;
        //    txtsap.Text = Sap;
        //    txtodoo.Text = odoo;
        //    MateriaPrima mp = new MateriaPrima();
        //    mp.RecuperarRegistroFromCode(Sap);
        //    id_mp = mp.IdMP_ACS;
        //    load_Data();
                
        //}

        public frmUnirLigaduras(UserLogin Puser,
                                string pSap,
                                string podoo,
                                string pMP,
                                int pid_lote,
                                string plote,
                                int pn_referencia,
                                int pid_mp)
        {

            InitializeComponent();
            UsuarioLogeado = Puser;
            Sap = pSap;
            odoo = podoo;
            MP = pMP;
            id_lote = pid_lote;
            lote = plote;
            n_transaccion = pn_referencia;
            txtingreso.Text = n_transaccion.ToString();
            txtlote.Text = plote;
            txtmp.Text = MP;
            txtodoo.Text = odoo;
            txtsap.Text = Sap;
            id_mp = pid_mp;
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
                cmd.Parameters.AddWithValue("@num_transaccion", txtingreso.Text.Trim());
                cmd.Parameters.AddWithValue("@id_mp", id_mp);
                cmd.Parameters.AddWithValue("@lote", txtlote.Text.Trim());
                //cmd.Parameters.AddWithValue("@id_ingreso", id_lote);//Id_ingreso

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
                frmSeleccionarLectura frm = new frmSeleccionarLectura(UsuarioLogeado, n_transaccion, id_mp, lote);
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

        private void btnAllDesvincular_Click(object sender, EventArgs e)
        {
            if (CajaDialogo.Pregunta("Deseas disvincular todas las lectura?") == DialogResult.Yes)
            {
                try
                {
                        string query = @"sp_delete_link_ingreso_lectura_nir";
                        SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                        cn.Open();

                    foreach (dsNir.lecturas_ingresoRow row in dsNir.lecturas_ingreso.Rows)
                    {
                       
                        SqlCommand cmd = new SqlCommand(query, cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_lectura", row.id);
                        cmd.ExecuteNonQuery();
                        
                    }
                        cn.Close();
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