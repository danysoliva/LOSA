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
    public partial class frmMP_Granel_Selec_Lote : DevExpress.XtraEditors.XtraForm
    {
        ArrayList vLista = new ArrayList();
        public ArrayList ListaResultados;
        string itemcode;
        public frmMP_Granel_Selec_Lote(ArrayList pArray)
        {
            InitializeComponent();
            vLista = pArray;

            LoadListaLotesActivos();
            foreach (ItemMP_Lote item in pArray)
            {
                dsRecepcionMPx.cruce_lote_mpRow row1 = dsRecepcionMPx1.cruce_lote_mp.Newcruce_lote_mpRow();
                row1.itemcode = item.ItemCode;
                row1.card_name = item.Card_Name;
                //pendiente agregar el valor de lote
                dsRecepcionMPx1.cruce_lote_mp.Addcruce_lote_mpRow(row1);
                dsRecepcionMPx1.AcceptChanges();
            }
            
        }
        public frmMP_Granel_Selec_Lote(ArrayList pArray, int id_externo)
        {
            InitializeComponent();
            vLista = pArray;
            //LoadListaLotesActivos();

            foreach (ItemMP_Lote item in pArray)
            {
                dsRecepcionMPx.cruce_lote_mpRow row1 = dsRecepcionMPx1.cruce_lote_mp.Newcruce_lote_mpRow();
                row1.itemcode = item.ItemCode;
                row1.card_name = item.Card_Name;
                //pendiente agregar el valor de lote
                dsRecepcionMPx1.cruce_lote_mp.Addcruce_lote_mpRow(row1);
                dsRecepcionMPx1.AcceptChanges();
            }

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

        public void LoadListaLotesActivos()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                //SqlCommand cmd = new SqlCommand("sp_get_lista_lotes_activos_granel", con);
                SqlCommand cmd = new SqlCommand("sp_get_granel_en_externo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                //cmd.Parameters.AddWithValue("@itemcode", pitemcode);
                dsRecepcionMPx1.lista_lotes_granel.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsRecepcionMPx1.lista_lotes_granel);

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

                #region Codigo Validacion Anterior

                //switch (vItemCod)
                //{
                //    case "MP00002":
                //    case "MP00003":
                //    case "MP00004":
                //        //row.id_lote = id_lote_selected;
                //        //row.lote_b = row.lote = GridLoook1.Text;
                //        if (vItemCod != row.itemcode)
                //        {
                //            //Significa que no es la misma materia prima
                //            CajaDialogo.Error("Debe seleccionar un lote que pertenezca a la misma Materia Prima!");
                //            GridLoook1.EditValue = "";
                //            GridLoook1.Text = "";
                //            row.id_lote = 0;
                //            return;
                //        }
                //        else
                //        {
                //            row.id_lote = id_lote_selected;
                //            row.lote_b = row.lote = GridLoook1.Text;
                //        }
                //        break;
                //    default:
                //        if (vItemCod != row.itemcode)
                //        {
                //            //Significa que no es la misma materia prima
                //            CajaDialogo.Error("Debe seleccionar un lote que pertenezca a la misma Materia Prima!");
                //            GridLoook1.EditValue = "";
                //            GridLoook1.Text = "";
                //            row.id_lote = 0;
                //            return;
                //        }
                //        else
                //        {
                //            row.id_lote = id_lote_selected;
                //            row.lote_b = row.lote = GridLoook1.Text;
                //        }
                //        break;
                //}//end switch
                #endregion

                //Bypass para unificar las soyas en un solo codigo
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
            bool Next = false;
            foreach(dsRecepcionMPx.cruce_lote_mpRow row in dsRecepcionMPx1.cruce_lote_mp.Rows)
            {
                if(row.id_lote > 0)
                {
                    Next = true;
                    break;
                }
            }
            if (!Next)
            {
                CajaDialogo.Error("No hay ningun Lote correctamente Seleccionado!\nNo se puede continuar!");
                return;
            }

            ListaResultados = new ArrayList();
            foreach (dsRecepcionMPx.cruce_lote_mpRow row in dsRecepcionMPx1.cruce_lote_mp.Rows)
            {
                if (row.id_lote > 0)
                {
                    ItemMP_Lote Item = new ItemMP_Lote();
                    Item.ItemCode = row.itemcode;
                    Item.Lote = row.lote_b; 
                    Item.Card_Name = row.card_name;
                    Item.IdLote = row.id_lote;
                    //Item.FechaProd = 
                    ListaResultados.Add(Item);
                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();

        }







    }
}