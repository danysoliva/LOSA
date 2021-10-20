using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.Logistica
{
    public partial class xfrmBuscarLotePT : DevExpress.XtraEditors.XtraForm
    {
        public ArrayList ListaLotesInt;
        public xfrmBuscarLotePT()
        {
            InitializeComponent();
            ListaLotesInt = new ArrayList();
            LoadDatos();
        }

        private void LoadDatos()
        {
            //
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringAPMS);
                string SQL = @"sp_get_detalle_lotes_for_reproceso";
                SqlCommand cmd = new SqlCommand(SQL, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsLogistica21.lotes_pt.Clear();
                adat.Fill(dsLogistica21.lotes_pt);
                cn.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            //var gridView = (GridView)gridControl1.FocusedView;
            //var row = (dsLogistica2.lotes_ptRow)gridView.GetFocusedDataRow();
            int count_ = 0;
            foreach(dsLogistica2.lotes_ptRow row in dsLogistica21.lotes_pt.Rows)
            {
                if(row.seleccion)
                {
                    count_++;
                    break;
                }    
            }

            if(count_ == 0)
            {
                CajaDialogo.Error("Debe seleccionar al menos un lote para continuar!");
                return;
            }

            foreach (dsLogistica2.lotes_ptRow row in dsLogistica21.lotes_pt.Rows)
            {
                if (row.seleccion)
                {
                    ListaLotesInt.Add(row.lote);
                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}