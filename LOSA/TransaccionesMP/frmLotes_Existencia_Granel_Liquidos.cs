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
    public partial class frmLotes_Existencia_Granel_Liquidos : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public int id_materia_p;
        decimal cant_necesaria_requisa = 0;
        public string lote;
        public decimal cant_a_requisar = 0;
        public string bodega;

        public frmLotes_Existencia_Granel_Liquidos(int pid_mp, decimal pcant_necesaria_requisa)
        {
            InitializeComponent();
            id_materia_p = pid_mp;
            cant_necesaria_requisa = pcant_necesaria_requisa;
            load_detalle_lote();
        }

        private void load_detalle_lote()
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_detalle_lote_for_id_mp", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_mp", id_materia_p);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsTransaccionesMP1.detalle_lote_granel_liquidos.Clear();
                adat.Fill(dsTransaccionesMP1.detalle_lote_granel_liquidos);
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

        private void reportItem_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)grdLoteExist.FocusedView;
            var row = (dsTransaccionesMP.detalle_lote_granel_liquidosRow)gridview.GetFocusedDataRow();

            if (row.existencia_kg < cant_necesaria_requisa)
            {
                cant_a_requisar = row.existencia_kg;
            }
            else
            {
                cant_a_requisar = cant_necesaria_requisa;
            }

            lote = row.lote_mp;
            id_materia_p = row.id_mp;
            bodega = row.whs_equivalente;
            id_materia_p = row.id_mp;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}