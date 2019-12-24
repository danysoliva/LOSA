using ACS.Classes;
using DevExpress.XtraReports.UI;
using LOSA.Clases;
using LOSA.RecepcionMP;
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

namespace LOSA.Produccion
{
    public partial class frmAddTarimaPT : Form
    {
        UserLogin UsuarioLogeado;
        int Lote;
        int IdProd;
        decimal bolsa;
        public frmAddTarimaPT(UserLogin UsuarioLogeado, int plote, int pidProd)
        {
            InitializeComponent();
            LoadNumeroTransaccion();
            bolsa = 1;
            this.UsuarioLogeado = UsuarioLogeado;
            Lote = plote;
            txtLote.Text = plote.ToString();
            IdProd = pidProd;
            DataOperations dp = new DataOperations();
            dtFechaProduccion.EditValue = dp.Now();
            DateTime fechav = Convert.ToDateTime(dtFechaProduccion.EditValue);
            dtFechaVence.EditValue = fechav.AddDays(Convert.ToInt32(txtDias.Text));
            ProductoTerminado pt = new ProductoTerminado(dp.ConnectionStringCostos);
            if (pt.Recuperar_producto(pidProd))
            {
                txtProductoName.Text = pt.descripcion;
                int idbag = pt.id_bag;
                if (idbag > 0)
                {
                    BagsPT bg = new BagsPT();
                    if (bg.RecuperarRegistro(idbag))
                    {
                        txtProductoName.Text = pt.descripcion;
                        bolsa = bg.net;
                        txtPresentacion.Text = bg.Descripcion;
                        if (bolsa <= 25)
                        {
                            txtUnidades.Text = "70";
                        }
                        else
                        {
                            txtUnidades.Text = "25";
                        }
                        decimal peso_ = Convert.ToDecimal(txtUnidades.Text) * bolsa;
                        txtPesoKg.Text = string.Format("{0:###,##0.00}", peso_);
                    }
                }
            }
        }
        private void LoadNumeroTransaccion()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();
                SqlCommand cmm2 = new SqlCommand("sp_generar_codigo_from_tables_id", con);
                cmm2.CommandType = CommandType.StoredProcedure;
                cmm2.Parameters.AddWithValue("@id", 2);
                string num_ingreso = cmm2.ExecuteScalar().ToString();
                txtNumTransaccion.Text = num_ingreso;
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void labelControl10_Click(object sender, EventArgs e)
        {

        }

        private void txtDias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtUnidades_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txtUnidades.Text) <= 0)
            {
                CajaDialogo.Error("No se puede registrar una tarima con unidades de materia en cero (0)!");
                return;
            }

            if (string.IsNullOrEmpty(txtLote.Text))
            {
                CajaDialogo.Error("Es obligatorio llenar el lote para la tarima!");
                return;
            }
            if (string.IsNullOrEmpty(dtFechaVence.Text))
            {
                CajaDialogo.Error("Es obligatorio llenar la fecha de vencimiento de la materia prima!");
                return;
            }

            int cant = 0;
            try
            {
                cant = Convert.ToInt32(txtCantidadTarimasTotal.Text);
            }
            catch
            {
                cant = 0;
            }

            if (cant <= 0)
            {
                CajaDialogo.Error("No se puede registrar menos de una (1) tarima!");
                return;
            }

            bool Guardo = false;
            int vid_tarima = 0;
            ArrayList List = new ArrayList();

            for (int i = 1; i <= cant; i++)
            {
                try
                {
                    DataOperations dp = new DataOperations();
                    SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                    con.Open();

                    SqlCommand cmm = new SqlCommand("sp_generar_codigo_from_tables_id", con);
                    cmm.CommandType = CommandType.StoredProcedure;
                    cmm.Parameters.AddWithValue("@id", 1);
                    string barcode = cmm.ExecuteScalar().ToString();

                    SqlCommand cmd = new SqlCommand("sp_insert_tarima_pt", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                   // cmd.Parameters.AddWithValue("@itemcode", this.ItemCode);
                    //cmd.Parameters.AddWithValue("@id_proveedor", txtCodigoProveedor.Text);
                    //cmd.Parameters.AddWithValue("@fecha_ingreso", dtFechaIngreso.EditValue);
                    cmd.Parameters.AddWithValue("@numero_transaccion", txtNumTransaccion.Text);
                    cmd.Parameters.AddWithValue("@fecha_vencimiento", dtFechaVence.EditValue);
                    //cmd.Parameters.AddWithValue("@fecha_produccion_materia_prima", dtFechaProduccion.EditValue);
                    cmd.Parameters.AddWithValue("@lote_producto_termiado", txtLote.Text);
                    //cmd.Parameters.AddWithValue("@id_presentacion", gridLookUpEditPresentacion.EditValue);
                    cmd.Parameters.AddWithValue("@id_usuario", UsuarioLogeado.Id);
                    cmd.Parameters.AddWithValue("@id_producto_termiado", IdProd);
                    cmd.Parameters.AddWithValue("@codigo_barra", barcode);
                    cmd.Parameters.AddWithValue("@cantidad", txtUnidades.Text);
                    cmd.Parameters.AddWithValue("@peso", Convert.ToDecimal(txtPesoKg.Text));
                    vid_tarima = Convert.ToInt32(cmd.ExecuteScalar());

                    List.Add(vid_tarima);

                    Guardo = true;
                    con.Close();
                    //CajaDialogo.InformationAuto();
                    //this.DialogResult = DialogResult.OK;
                    //this.Close();
                }
                catch (Exception ec)
                {
                    CajaDialogo.Error(ec.Message);
                }
            }

            if (Guardo)
            {
                DialogResult r = CajaDialogo.Pregunta("Desea Imprimir la(s) Hoja(s) de Ingreso?");
                if (r == DialogResult.Yes)
                {
                    for (int i = 0; i <= (List.Count - 1); i++)
                    {
                        int id_tarimax = Convert.ToInt32(List[i]);
                        rptReporteTarimaPT report = new rptReporteTarimaPT(id_tarimax);
                        report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                        ReportPrintTool printReport = new ReportPrintTool(report);
                        printReport.ShowPreview();
                    }
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }





        }











    }
}
