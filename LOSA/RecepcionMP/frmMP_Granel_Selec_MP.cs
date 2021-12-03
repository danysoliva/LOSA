using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;
using LOSA.Clases;
using ACS.Classes;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.RecepcionMP
{
    public partial class frmMP_Granel_Selec_MP : DevExpress.XtraEditors.XtraForm
    {
        ArrayList vLista = new ArrayList();
        public ArrayList ListaResultados;
        public MateriaPrima ItemSelected;
        public frmMP_Granel_Selec_MP(ArrayList pArray, string CodigoSAP_MP)
        {
            InitializeComponent();
            vLista = pArray;
            LoadListaMP_Permitidas(CodigoSAP_MP);

            //foreach (MateriaPrima item in pArray)
            //{
            //    dsRecepcionMPx.cruce_lote_mpRow row1 = dsRecepcionMPx1.cruce_lote_mp.Newcruce_lote_mpRow();
            //    row1.itemcode = item.CodeMP_SAP;
            //    row1.card_name = item.Name;
            //    //pendiente agregar el valor de lote
            //    dsRecepcionMPx1.cruce_lote_mp.Addcruce_lote_mpRow(row1);
            //    dsRecepcionMPx1.AcceptChanges();
            //}
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdSelectLote_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //buscar en la lista de lotes

        }

        public void LoadListaMP_Permitidas(string pItemCode)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_lista_mp_permitidas_alosy", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@code", pItemCode);
                dsRecepcionMPx1.cruce_lote_mp.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsRecepcionMPx1.cruce_lote_mp);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        public string GetItemCodeFromLoteIdActivo(int pId)
        {
            string vItemCode_ = "";
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringBascula);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_validate_id_lote_with_itemcode", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", pId);
                vItemCode_ = cmd.ExecuteScalar().ToString();

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return vItemCode_;
        }

        private void GridLookUpEditLoteEmbedded_EditValueChanged(object sender, EventArgs e)
        {
            //Selecciono un lote
            GridLookUpEdit GridLoook1 = (GridLookUpEdit)sender;

            int id_lote_selected = 0;
            if (GridLoook1.EditValue != null && GridLoook1.EditValue.ToString() != "")
            {
                try
                {
                    id_lote_selected = Convert.ToInt32(GridLoook1.EditValue);
                }
                catch { }

                string vItemCod = GetItemCodeFromLoteIdActivo(id_lote_selected);
                var gridView = (GridView)gridControl1.FocusedView;
                var row = (dsRecepcionMPx.cruce_lote_mpRow)gridView.GetFocusedDataRow();

                if (vItemCod != row.itemcode)
                {
                    //Significa que no es la misma materia prima
                    CajaDialogo.Error("Debe seleccionar un lote que pertenezca a la misma Materia Prima!");
                    GridLoook1.EditValue = "";
                    GridLoook1.Text = "";
                    row.id_lote = 0;
                    return;
                }
                else
                {
                    row.id_lote = id_lote_selected;
                    row.lote_b = row.lote = GridLoook1.Text;
                }
            }
        }

        private void cmdSiguiente_Click(object sender, EventArgs e)
        {
            //bool Next = false;
            //foreach(dsRecepcionMPx.cruce_lote_mpRow row in dsRecepcionMPx1.cruce_lote_mp.Rows)
            //{
            //    if(row.id_lote > 0)
            //    {
            //        Next = true;
            //        break;
            //    }
            //}
            //if (!Next)
            //{
            //    CajaDialogo.Error("No hay ningun Lote correctamente Seleccionado!\nNo se puede continuar!");
            //    return;
            //}

            ListaResultados = new ArrayList();
            foreach (dsRecepcionMPx.cruce_lote_mpRow row in dsRecepcionMPx1.cruce_lote_mp.Rows)
            {
                //if (row.id_lote > 0)
                //{
                //    ItemMP_Lote Item = new ItemMP_Lote();
                //    Item.ItemCode = row.itemcode;
                //    Item.Lote = row.lote_b; 
                //    Item.Card_Name = row.card_name;
                //    Item.IdLote = row.id_lote;
                //    ListaResultados.Add(Item);
                //}
                ItemSelected = new MateriaPrima();
                ItemSelected.CodeMP_SAP = row.itemcode;
                ItemSelected.Name = row.card_name;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            dsRecepcionMPx.cruce_lote_mpRow row = (dsRecepcionMPx.cruce_lote_mpRow)sender;
            ListaResultados = new ArrayList();
            //foreach (dsRecepcionMPx.cruce_lote_mpRow row in dsRecepcionMPx1.cruce_lote_mp.Rows)
            //{
                //if (row.id_lote > 0)
                //{
                //    ItemMP_Lote Item = new ItemMP_Lote();
                //    Item.ItemCode = row.itemcode;
                //    Item.Lote = row.lote_b; 
                //    Item.Card_Name = row.card_name;
                //    Item.IdLote = row.id_lote;
                //    ListaResultados.Add(Item);
                //}
                ItemSelected = new MateriaPrima();
                ItemSelected.CodeMP_SAP = row.itemcode;
                ItemSelected.Name = row.card_name;
            //}
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}