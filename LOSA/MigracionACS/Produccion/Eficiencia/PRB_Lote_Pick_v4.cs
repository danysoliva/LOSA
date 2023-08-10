using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using ACS.Classes;
using LOSA.MigracionACS.DataSetx;
using DevExpress.XtraGrid.Views.Grid;
using System;
using LOSA.Clases;

namespace LOSA.MigracionACS.Produccion.Eficiencia
{
    public partial class PRB_Lote_Pick_v4 : DevExpress.XtraEditors.XtraForm
    {
        public DateTime desde;
        public DateTime hasta;
        public int lote;
        public string Descripcion;
        public string Code;
        int IdRegh;
        int IdLinea;
        public decimal horas;
        decimal HorasSelected;
        decimal vHorasAsignadas;
        bool PermitirGuardar = false;
        public int IdPresentacion;
        public int cantidad;
        public int id_alimentacion;
        public DataTable TmSelecionadas;
        public int IdDado;
        TipoVentana TipoVentanaActual;
        public enum TipoVentana
        {
            PRB_Registro = 1,
            PRB_Brom = 2
        }

        public PRB_Lote_Pick_v4(DateTime Pardesde, DateTime Parhasta, int pIdRegH, int pIdLinea, decimal phoras_asignadas)
        {
            InitializeComponent();
            TipoVentanaActual = TipoVentana.PRB_Registro;
            PermitirGuardar = false;
            //LoadPresentacionSacos();
            vHorasAsignadas = phoras_asignadas;
            APMS_OrderProduction fn = new APMS_OrderProduction();
            HorasSelected = fn.GetHorasMaquinaFromId(pIdLinea, pIdRegH);
            textEdit1.Text = Math.Round((HorasSelected - phoras_asignadas), 2).ToString();
            txtTotalHorasMotor.Text = HorasSelected.ToString();
            desde = Pardesde;
            hasta = Parhasta;
            IdRegh = pIdRegH;
            IdLinea = pIdLinea;
            load_data();
            TmSelecionadas = dsLotePick.tm;

            if (IdLinea == 3)
            {
                gridLookUpEdit_Dado.Enabled = false;
            }
            else
            {
                LoadDadosMaestro();
            }
        }

        private void LoadDadosMaestro()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringAPMS);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_eficiencia_get_datos_dado", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_maquina", IdLinea);
                dsEficiencia1.dados.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsEficiencia1.dados);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        public int devolver()
        {
            return lote;
        }
        public PRB_Lote_Pick_v4(DateTime Pardesde, DateTime Parhasta, int pIdRegH)
        {
            InitializeComponent();
            TipoVentanaActual = TipoVentana.PRB_Brom;
            desde = Pardesde;
            hasta = Parhasta;
            IdRegh = pIdRegH;
            //IdLinea = pIdLinea;
            load_data_brom();
        }

        public void load_data()
        {
            try
            {
                string data = @"sp_obtener_produccion_lote_pick";
                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(data, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desde", desde.AddDays(-10));
                cmd.Parameters.AddWithValue("@hasta", hasta.AddDays(3));
                cmd.Parameters.AddWithValue("@id_registro", IdRegh);
                cmd.Parameters.AddWithValue("@idlinea", IdLinea);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsLotePick.lote_pick.Clear();
                da.Fill(dsLotePick.lote_pick);
                cn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public void load_data_brom()
        {
            try
            {
                string data = "sp_get_lotes_for_bromatologia_prd";
                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringAPMS);
                cn.Open();
                SqlCommand cmd = new SqlCommand(data, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@fechai", DateTime.Now.AddDays(-7));
                cmd.Parameters.AddWithValue("@fechai", desde);
                //cmd.Parameters.AddWithValue("@fechaf", DateTime.Now.AddDays(3));
                cmd.Parameters.AddWithValue("@fechaf", hasta);
                cmd.Parameters.AddWithValue("@idregh", IdRegh);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                pRB_DATA2.loadlot.Clear();
                da.Fill(pRB_DATA2.loadlot);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            
            if (lote > 0 && PermitirGuardar && IdPresentacion > 0 && cantidad != 0)
            {
                if (gridLookUpEdit_Dado.Enabled)//cuando es extruder enable = false
                {
                    //validaremos seleccion de dado si es una linea 1 o linea 2.
                    if (string.IsNullOrEmpty(gridLookUpEdit_Dado.Text))
                    {
                        CajaDialogo.Error("Es necesario especificar el dado utlizado en linea de Pelletizado!");
                        return;
                    }
                    else
                    {
                        int idDado = 0;
                        try
                        {
                            idDado = Convert.ToInt32(gridLookUpEdit_Dado.EditValue);
                        }
                        catch{ }

                        if (idDado > 0)
                        {
                            IdDado = idDado;
                            errorProvider1.Clear();
                            this.DialogResult = DialogResult.Yes;
                        }
                        else
                        {
                            CajaDialogo.Error("Es necesario especificar el dado utlizado en linea de Pelletizado!");
                            return;
                        }
                    }
                }
                else
                {
                    //significa que es linea de extruder.
                    errorProvider1.Clear();
                    this.DialogResult = DialogResult.Yes;
                }
            }
            else
            {
                errorProvider1.SetError(cmdGuardar, "Necesita completar los datos de hora de inicio y fin correctamente, así como el lote y la cantidad de sacos!");
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void dtFechaf_EditValueChanged(object sender, EventArgs e)
        {
            desde = Convert.ToDateTime(dtFechai.EditValue);
            hasta = Convert.ToDateTime(dtFechaf.EditValue);
            if (hasta > desde)
            {
                Funciones fn = new Funciones();
                horas = fn.GetDifHorasforDecimal(desde, hasta);
                txtHorasSeleccionadas.Text = Math.Round(horas, 2).ToString();
                if ((HorasSelected - vHorasAsignadas) < horas)
                {
                    errorProvider1.SetError(txtHorasSeleccionadas, "No puede asignar mas horas de las trabajadas! Debe reducir las horas a ingresar...");
                    PermitirGuardar = false;
                }
                else
                {
                    errorProvider1.Clear();
                    PermitirGuardar = true;
                }
            }
        }

        private void dtFechai_EditValueChanged(object sender, EventArgs e)
        {
            desde = Convert.ToDateTime(dtFechai.EditValue);
            hasta = Convert.ToDateTime(dtFechaf.EditValue);
            if (hasta > desde)
            {
                Funciones fn = new Funciones();
                horas = fn.GetDifHorasforDecimal(desde, hasta);
                txtHorasSeleccionadas.Text = Math.Round(horas, 2).ToString();
                if ((HorasSelected - vHorasAsignadas) < horas)
                {
                    errorProvider1.SetError(txtHorasSeleccionadas, "No puede asignar mas horas de las trabajadas! Debe reducir las horas a ingresar...");
                    PermitirGuardar = false;
                }
                else
                {
                    errorProvider1.Clear();
                    PermitirGuardar = true;
                }
            }
        }

        private void grdv_data_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            grdv_data_CellValueChanged(sender, e);
        }

        private void grdv_data_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var GridView = (GridView)grd_data.FocusedView;
                var row = (dsLotePick.lote_pickRow)GridView.GetFocusedDataRow();
                lote = Convert.ToInt32(row.lote_pt);
                Descripcion = row.Descripcion;
                Code = row.Codigo;
                IdPresentacion = row.id_presentacion;
                cantidad = row.seleccionado;
                id_alimentacion = row.id;
                if (lote > 0 && PermitirGuardar && IdPresentacion > 0 && row.seleccionado == 0)
                {
                    errorProvider1.Clear();
                    this.DialogResult = DialogResult.Yes;
                }
                else
                {
                    errorProvider1.SetError(cmdGuardar, "Necesita completar los datos de hora de inicio y fin correctamente, así como el lote y la cantidad de sacos!");
                }
            }
            catch (Exception)
            {

            }
        }

        private void grdv_data_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                var GridView = (GridView)grd_data.FocusedView;
                var row = (dsLotePick.lote_pickRow)GridView.GetFocusedDataRow();
                if (e.Column.Name == "colseleccionado")
                {
                    if (row.Disponible < Convert.ToInt32(e.Value))
                    {
                        row.seleccionado = row.Disponible;
                    }
                    else
                    {
                        row.seleccionado = Convert.ToInt32(e.Value);
                    }

                    row.AcceptChanges();
                }
            }
            catch (Exception )
            {

            }
        }

        private void grdv_data_Click(object sender, EventArgs e)
        {
           
        }

        private void grdv_data_RowClick(object sender, RowClickEventArgs e)
        {
            try
            {
                var GridView = (GridView)grd_data.FocusedView;
                var row = (dsLotePick.lote_pickRow)GridView.GetFocusedDataRow();
                lote = Convert.ToInt32(row.lote_pt);
                Descripcion = row.Descripcion;
                Code = row.Codigo;
                IdPresentacion = row.id_presentacion;
                cantidad = row.seleccionado;
                id_alimentacion = row.id;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnver_Click(object sender, EventArgs e)
        {
            var GridView = (GridView)grd_data.FocusedView;
            var row = (dsLotePick.lote_pickRow)GridView.GetFocusedDataRow();
            frmDetalleActivado frm = new frmDetalleActivado(row.lote_pt);
            frm.Show();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                var GridView = (GridView)grd_data.FocusedView;
                var row = (dsLotePick.lote_pickRow)GridView.GetFocusedDataRow();
                frm_seleccion_tarimas frm = new frm_seleccion_tarimas(row.lote_pt, TmSelecionadas);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    TmSelecionadas = new DataTable();
                    TmSelecionadas = frm.Result;
                    TmSelecionadas.AcceptChanges();
                    foreach (dsLotePick.lote_pickRow rw in dsLotePick.lote_pick.Rows)
                    {
                        rw.seleccionado = 0;
                    }
                    dsLotePick.lote_pick.AcceptChanges();
                     GridView = (GridView)grd_data.FocusedView;
                     row = (dsLotePick.lote_pickRow)GridView.GetFocusedDataRow();
                      row.seleccionado = Convert.ToInt32(frm.cant);
                    row.AcceptChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        private void btnSacosLigados_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSacosLigados_Click(object sender, EventArgs e)
        {
            PRB_LotesLigados frm = new PRB_LotesLigados();
            frm.ShowDialog();
        }
    }
}