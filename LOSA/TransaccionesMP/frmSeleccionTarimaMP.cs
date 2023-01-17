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
    public partial class frmSeleccionTarimaMP : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        
        public int id_materia_p,id_tarima;
        decimal cant_necesaria_requisa = 0;
        public string lote,itemcode,codigo_barra;
        public decimal cant_a_requisar = 0;
        UserLogin UsuarioLogeado;

        public frmSeleccionTarimaMP(int pid_mp, decimal pcant_necesaria_requisa)
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
                SqlCommand cmd = new SqlCommand("[sp_get_detalle_lote_for_id_mp_tarimas]", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_mp", id_materia_p);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsTransaccionesMP1.detalle_tarima_prd_liqui.Clear();
                adat.Fill(dsTransaccionesMP1.detalle_tarima_prd_liqui);
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

        private void reposSeleccionar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)grdtarimas.FocusedView;
            var row = (dsTransaccionesMP.detalle_tarima_prd_liquiRow)gridview.GetFocusedDataRow();

            if (row.existencia_kg < cant_necesaria_requisa)
            {
                cant_a_requisar = row.existencia_kg;
            }
            else
            {
                cant_a_requisar = cant_necesaria_requisa;
            }

            id_tarima = row.id_tarima_prd;
            id_materia_p = row.id_mp;
            itemcode = row.itemcode;
            lote = row.lote;
            codigo_barra = row.codigo_barra;

            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}