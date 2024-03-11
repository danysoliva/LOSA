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
using ACS.Classes;
using LOSA.Clases;
using System.Data.SqlClient;
using LOSA.TransaccionesMP.Liquidos;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.TransaccionesMP.VentanasMensajes;
using LOSA.MicroIngredientes;

namespace LOSA.TransaccionesMP
{
    public partial class frmWizardSelectGranel_Liqu : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public UserLogin UsuarioLogeadol;
        string barcode_requisa;
        int id_requisa = 0;
        decimal cant_necesaria = 0;

        string lote, bodega;
        decimal cant_a_requisar;
        int id_materia_p,id_bodega;

        public frmWizardSelectGranel_Liqu(UserLogin pUserLogin, string pbarcode_requisa)
        {
            InitializeComponent();
            UsuarioLogeadol = pUserLogin;
            barcode_requisa = pbarcode_requisa;

            Requisicion req1 = new Requisicion();
            req1.RecuperarRegistroFromBarcodeClass(barcode_requisa);
            txtBarCodeRequisa.Text = req1.Barcode1;
            txtLotePT.Text = Convert.ToString(req1.Lote);
            id_requisa = req1.IdRequisicion1;
            
            Load_Detalle(id_requisa);
        }

        private void Load_Detalle(int pid_requisa)
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand("[sp_get_detalle_requisa_granel_liquidoV2]", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_requisa", pid_requisa);
                cmd.Parameters.AddWithValue("@isgranel", 1);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsTransaccionesMP1.requisiciones_d.Clear();
                adat.Fill(dsTransaccionesMP1.requisiciones_d);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void gridvDetalleRequisa_RowStyle(object sender, RowStyleEventArgs e)
        {
            //var gridview = (GridView)gridDetalleRequisa.FocusedView;
            //var row = (dsTransaccionesMP.requisiciones_dRow)gridview.GetFocusedDataRow();

            //foreach (dsTransaccionesMP.requisiciones_dRow item in dsTransaccionesMP1.requisiciones_d.Rows)
            //{
            //    if (item.solicitada <= item.entregada)
            //    {
            //        e.Appearance.BackColor = Color.LightGreen;
            //    }
            //    else
            //    {
            //        e.Appearance.BackColor = Color.White;
            //    }

            //    //GridView View = sender as GridView;
            //    //if (e.RowHandle >= 0)
            //    //{
            //    //    if (row.solicitada >= row.entregada)
            //    //    {
            //    //        e.Appearance.BackColor = Color.Green;
            //    //    }
            //    //    else
            //    //    {
            //    //        e.Appearance.BackColor = Color.White;
            //    //    }
            //    //}
            //}
        }

        private void timerLimpiarMensaje_Tick(object sender, EventArgs e)
        {
            timerLimpiarMensaje.Stop();
            timerLimpiarMensaje.Enabled = false;
            panelNotificacion.BackColor = Color.White;
            //txtCantidadT.Text = txtPeso.Text = "0";
            //txtTarima.Text = "";
            //gcTarima.DataSource = null;
            lblMensaje.Text = "";
            ///txtTarima.Focus();
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void repositemEntregar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)gridDetalleRequisa.FocusedView;
            var row = (dsTransaccionesMP.requisiciones_dRow)gridview.GetFocusedDataRow();

            if (row.entregada >= row.solicitada)
            {
                CajaDialogo.Error("Ya se completo la Materia Prima solicitada en la requisa!");
                return;
            }
            else
            {
                cant_necesaria = row.solicitada - row.entregada;

                frmLotes_Existencia_Granel_Liquidos frm = new frmLotes_Existencia_Granel_Liquidos(row.id_materia_prima, cant_necesaria);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    lote = frm.lote;
                    bodega = frm.bodega;
                    cant_a_requisar = frm.cant_a_requisar;
                    id_materia_p = frm.id_materia_p;
                    id_bodega = frm.id_bodega;

                    try
                    {
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("sp_insert_kardex_requisicion_granel_liquidos", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@lote", lote);
                        cmd.Parameters.AddWithValue("@bodega ", bodega);
                        cmd.Parameters.AddWithValue("@cant_a_requisar", dp.ValidateNumberDecimal(cant_a_requisar));
                        cmd.Parameters.AddWithValue("@id_materia_p", id_materia_p);
                        cmd.Parameters.AddWithValue("@id_requisa", id_requisa);
                        cmd.Parameters.AddWithValue("@id_bodega", id_bodega);
                        cmd.Parameters.AddWithValue("@user_id", UsuarioLogeadol.Id);
                        cmd.ExecuteNonQuery();

                        Load_Detalle(id_requisa);

                        //Mensaje de transaccion exitosa
                        lblMensaje.Text = "Transacción Exitosa!";
                        panelNotificacion.BackColor = Color.MediumSeaGreen;
                        timerLimpiarMensaje.Enabled = true;
                        timerLimpiarMensaje.Start();
                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                    }
                    

                }
            }
            //this.DialogResult = DialogResult.OK;
            //this.Close();
        }
    }
}