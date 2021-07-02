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
using DevExpress.XtraGrid.Views.Grid;
using LOSA.AlmacenesExterno.Models;
using ACS.Classes;
using System.Data.SqlClient;

namespace LOSA.AlmacenesExterno
{
    public partial class xfrmMovimientoStock : DevExpress.XtraEditors.XtraForm
    {
        Materia_Prima_Transferencia materia_Prima_Transferencia = new Materia_Prima_Transferencia();

        public xfrmMovimientoStock()
        {
            InitializeComponent();
            ObtenerBodegas();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarProd_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {

            materia_Prima_Transferencia = new Materia_Prima_Transferencia();
            xfrmBuscarMP_Ingresos_Externos frm = new xfrmBuscarMP_Ingresos_Externos();

                var gv = (GridView)gcTransferencia.FocusedView;
                var row = (dsAlmacenesExternos.Transferencia_StockRow)gv.GetDataRow(gv.FocusedRowHandle);

            if (frm.ShowDialog()== DialogResult.OK)
            {

                    if (row == null)
                    {


                DataRow workRow = dsAlmacenesExternos.Transferencia_Stock.NewRow();

                workRow[0]= frm.materia_Prima_Transferencia.CodeItem;
                workRow[1]= frm.materia_Prima_Transferencia.CodeName;
                workRow["cantidad_kilos"]= frm.materia_Prima_Transferencia.Peso;
                workRow["unidades"]= frm.materia_Prima_Transferencia.Unidades;

                dsAlmacenesExternos.Transferencia_Stock.Rows.Add(workRow);
            
                        gvTransferencia.PostEditor();
                    }
                    else
                    {
                        row.codeItem = frm.materia_Prima_Transferencia.CodeItem;
                        row.mp = frm.materia_Prima_Transferencia.CodeName;
                        row.cantidad_kilos = frm.materia_Prima_Transferencia.Peso;
                        row.unidades = frm.materia_Prima_Transferencia.Unidades;

                        gv.FocusedColumn = colmp;
                        //gv.RefreshData();
                        dsAlmacenesExternos.AcceptChanges();
                        //gvTransferencia.PostEditor();
                    }

            }
           

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void gvTransferencia_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var gv = (GridView)gcTransferencia.FocusedView;
            var row = (dsAlmacenesExternos.Transferencia_StockRow)gv.GetDataRow(gv.FocusedRowHandle);



        }

        private void ObtenerBodegas()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA))
                {
                    cnx.Open();

                    dsAlmacenesExternos.Warehouse.Clear();
                    SqlDataAdapter da = new SqlDataAdapter("sp_get_almacenes_externos_bodegas",cnx);
                    da.Fill(dsAlmacenesExternos.Warehouse);


                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
            
        }
    }
}