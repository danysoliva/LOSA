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
    public partial class frmWizardEntregaBinesRequisa : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public UserLogin UsuarioLogeadol;
        string barcode_requisa;
        int id_requisa = 0;

        public frmWizardEntregaBinesRequisa(UserLogin pUserLogin, string pbarcode_requisa)
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
                cmd.Parameters.AddWithValue("@isgranel", 0);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsTransaccionesMP1.detalle_requisa_liquidos_en_tarimas.Clear();
                adat.Fill(dsTransaccionesMP1.detalle_requisa_liquidos_en_tarimas);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void repositemEntregar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)gridDetalleRequisa.FocusedView;
            var row = (dsTransaccionesMP.detalle_requisa_liquidos_en_tarimasRow)gridview.GetFocusedDataRow();

            if (row.entregada >= row.solicitada)
            {
                CajaDialogo.Error("Ya se completo la Materia Prima Solicitada en la requisa!");
                return;
            }
            else
            {

            }

        }
    }
}