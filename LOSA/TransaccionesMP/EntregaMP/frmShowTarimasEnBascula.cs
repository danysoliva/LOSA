using DevExpress.XtraEditors;
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
using LOSA.Classes;
using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Clases;

namespace LOSA.TransaccionesMP.EntregaMP
{
    public partial class frmShowTarimasEnBascula : DevExpress.XtraEditors.XtraForm
    {
        public int Id_RegistroBascula;
        public int BascuilaID;

        public enum TipoVentana 
        {
            Vista = 1,
            Seleccion = 2
        }
        TipoVentana tipoVentana;

        public frmShowTarimasEnBascula(frmShowTarimasEnBascula.TipoVentana pTipo)
        {
            InitializeComponent();
            tipoVentana = pTipo;

            load_date();

            switch (tipoVentana)
            {
                case TipoVentana.Vista:
                    gridView1.OptionsMenu.EnableColumnMenu = false;
                    gridView1.Columns["selected"].Visible = false;
                    break;
                case TipoVentana.Seleccion:
                    gridView1.OptionsMenu.EnableColumnMenu = true;
                    gridView1.Columns["selected"].Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void load_date()
        {
            try
            {
                DataOperations dp = new DataOperations();
                string query = @"sp_get_tarimas_en_proceso_bascula";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("",);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsTransaccionesMP1.tarimas_bascula.Clear();
                adat.Fill(dsTransaccionesMP1.tarimas_bascula);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void reposSelect_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)gridDetalle.FocusedView;
            var row = (dsTransaccionesMP.tarimas_basculaRow)gridview.GetFocusedDataRow();

            if (row.id > 0)
            {
                AlimentacionBasculas ali = new AlimentacionBasculas();
                ali.RecuperarRegistros(row.id);

                if (ali.EnProceso)
                {
                    CajaDialogo.Error("Este Pesaje ya esta en Proceso.\nDebe completar el pesaje en la Bascula.");
                    return;
                }
                else
                {
                    Id_RegistroBascula = row.id;
                    BascuilaID = row.bascula;
                    
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

            }
            

            
        }
    }
}