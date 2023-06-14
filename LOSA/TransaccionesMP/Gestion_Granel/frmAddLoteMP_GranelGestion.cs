using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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

namespace LOSA.TransaccionesMP.Gestion_Granel
{
    public partial class frmAddLoteMP_GranelGestion : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        int IdMP;
        int TypeMP;
        public class ItemBusquedaLocal
        {
            public int id;
            public string lote;
            public int idmp;
            public string ItemCode;
            public string ItemName;
            public ItemBusquedaLocal()
            {
                id = 0;
                lote = "";
                idmp = 0;
                ItemCode = "";
                ItemName = "";
            }
        }

        public ItemBusquedaLocal ItemSeleccionado; 
        public frmAddLoteMP_GranelGestion(UserLogin pUsuarioLogeado, int pIdMP)
        {
            InitializeComponent();
            ItemSeleccionado = new ItemBusquedaLocal();
            UsuarioLogeado = pUsuarioLogeado;
            IdMP = pIdMP;
            if (IdMP == 12)
                TypeMP = 0;//Trigo
            else
                TypeMP = 1;//Soya
            LoadLotes();
        }

        private void LoadLotes()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_lotes_granel_config_cola", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_mp", IdMP);
                dsGestionGranel1.seleccion_lote.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsGestionGranel1.seleccion_lote);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
           
        }

        

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdConfirma_Click(object sender, EventArgs e)
        {
            DialogResult r = CajaDialogo.Pregunta("Confirme que desea aplicar este cambio?");
            if (r != DialogResult.Yes)
                return;

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_insert_lote_to_gestion_lotes_granel", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_mp", ItemSeleccionado.idmp);
                cmd.Parameters.AddWithValue("@lot", ItemSeleccionado.lote);
                cmd.Parameters.AddWithValue("@id_user_created", this.UsuarioLogeado.Id);
                cmd.Parameters.AddWithValue("@id_type", TypeMP);
                int val = Convert.ToInt32(cmd.ExecuteScalar());
                     
                con.Close();
                if (val == 1)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    CajaDialogo.Error("Ya se encuentra activo este lote para esta materia Prima!");
                }
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "Seleccionado")
            {
                var gridView = (GridView)gridControl1.FocusedView;
                var row = (dsGestionGranel.seleccion_loteRow)gridView.GetFocusedDataRow();
                if (Convert.ToBoolean(e.Value))
                {
                    ItemSeleccionado.lote = row.lote;
                    ItemSeleccionado.ItemCode = row.code_sap;
                    ItemSeleccionado.ItemName = row.nombre_comercial;
                    ItemSeleccionado.idmp = row.id_mp;
                    row.Seleccionado = true;
                }

                foreach (dsGestionGranel.seleccion_loteRow row1 in dsGestionGranel1.seleccion_lote)
                {
                    if (row1.id_mp != ItemSeleccionado.idmp || row1.lote != ItemSeleccionado.lote)
                        row1.Seleccionado = false;
                }
            }
        }
    }
}