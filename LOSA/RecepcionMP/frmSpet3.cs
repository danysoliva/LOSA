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
using System.Data.SqlClient;
using LOSA.Clases;
using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.AlmacenesExterno;
using LOSA.Liquidos;

namespace LOSA.RecepcionMP
{
    public partial class frmSpet3 : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        public int Tipo_Ingreso_Selected = 0;
        public string Descripcion_Tipo_Selected = "";
        public bool isTraslado = true;
        public int id_Traslado_Seleccionado;
        public int id_Transferencia_Seleccionado;
        public int DocEntry;
        public int id_mp;
        public frmSpet3(UserLogin Puser, string Ptipo_descripcion, int Pid_tipo)
        {
            InitializeComponent();
            UsuarioLogeado = Puser;
            Tipo_Ingreso_Selected = Pid_tipo;
            Descripcion_Tipo_Selected = Ptipo_descripcion;
            labelControl1.Text = labelControl1.Text + " Tipo de Ingreso: " + Descripcion_Tipo_Selected;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();

        }

        private void btnBuscarIngreso_Click(object sender, EventArgs e)
        {
            try
            {
                
                xfrmBuscarIngresosAlmacen frm = new xfrmBuscarIngresosAlmacen();

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    id_Traslado_Seleccionado = frm.ingreso_h.ID;
                    txtIngresoSeleccionado.Text = id_Traslado_Seleccionado.ToString();
                    string query = @"sp_lotes_in_ingreso_externo";
                    DataOperations dp = new DataOperations();
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(query,cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_ingreso_Externo", id_Traslado_Seleccionado);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    dsWizard.verLotes.Clear();
                    da.Fill(dsWizard.verLotes);
                    cn.Close();
                                                                     

                }

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void grd_data_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (txtIngresoSeleccionado.Text == "")
            {
                //CajaDialogo.Error("Debe selecionar un ingreso externo para poder continuar con esta gestion.");
                CajaDialogo.Error("Debe selecionar una transferencia para poder continuar con esta gestion.");
                return;
            }
            switch (Tipo_Ingreso_Selected)
            {
                case 1:   // 1 pues es sacos
                    //frmTarima_V2 frm = new frmTarima_V2(isTraslado,UsuarioLogeado, id_Traslado_Seleccionado);
                    frmTarima_V2 frm = new frmTarima_V2(isTraslado, UsuarioLogeado, id_Traslado_Seleccionado, id_Transferencia_Seleccionado, DocEntry, id_mp);
                    switch (frm.ShowDialog())
                    {
                        case DialogResult.OK:
                            this.DialogResult = DialogResult.OK;
                            break;
                        case DialogResult.Abort:
                            break;
                        case DialogResult.Cancel:
                            this.DialogResult = DialogResult.Cancel;
                            break;
                        default:
                            break;
                    }
                    break;
                case 2:
                    frmMP_Granel frmGranel = new frmMP_Granel(UsuarioLogeado,isTraslado, id_Traslado_Seleccionado);


                    if (this.MdiParent != null)
                    {
                        frmGranel.MdiParent = this.MdiParent;
                        frmGranel.FormBorderStyle = FormBorderStyle.Sizable;
                    }
                    frmGranel.WindowState = FormWindowState.Maximized;
                    switch (frmGranel.ShowDialog())
                    {
                        case DialogResult.OK:
                            this.DialogResult = DialogResult.OK;
                            break;
                        case DialogResult.Abort:
                            break;
                        case DialogResult.Cancel:
                            this.DialogResult = DialogResult.Cancel;
                            break;
                        default:
                            break;
                    }
                    break;
                case 4:

                    xfrmIngresoLiquidos frmLiquidos = new xfrmIngresoLiquidos(UsuarioLogeado, isTraslado, id_Traslado_Seleccionado);
                    switch (frmLiquidos.ShowDialog())
                    {
                        case DialogResult.OK:
                            this.DialogResult = DialogResult.OK;
                            break;
                        case DialogResult.Abort:
                            break;
                        case DialogResult.Cancel:
                            this.DialogResult = DialogResult.Cancel;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;

                    
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmdEditarLote_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)grd_data.FocusedView;
            var row = (dsWizard.verLotesRow)gridView.GetFocusedDataRow();

            frmEditLoteExterno frm = new frmEditLoteExterno(row.lote);
            if(frm.ShowDialog()== DialogResult.OK)
            {
                try
                {
                    DataOperations dp = new DataOperations();
                    SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                    con.Open();

                    SqlCommand cmd = new SqlCommand("sp_set_update_lote_externo_alosy_d", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@lote", frm.NewLoteSet_user);
                    cmd.Parameters.AddWithValue("@lote_old", row.lote);
                    cmd.Parameters.AddWithValue("@id", row.id);
                    cmd.Parameters.AddWithValue("@id_user", this.UsuarioLogeado.Id);
                    cmd.ExecuteNonQuery();
                    row.lote = frm.NewLoteSet_user;
                    con.Close();
                }
                catch (Exception ec)
                {
                    CajaDialogo.Error(ec.Message);
                }
            }
        }

        private void btnBuscarTransferencia_Click(object sender, EventArgs e)
        {
            try
            {

                //xfrmBuscarIngresosAlmacen frm = new xfrmBuscarIngresosAlmacen();
                xfrmSeleccionarTransferencia frm = new xfrmSeleccionarTransferencia(UsuarioLogeado);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    id_Transferencia_Seleccionado = frm.salid_plan.Id_header;
                    txtIngresoSeleccionado.Text = id_Transferencia_Seleccionado.ToString();
                    id_Traslado_Seleccionado = frm.salid_plan.Id_ingreso;
                    DocEntry = frm.salid_plan.DocEntry;
                    id_mp = frm.salid_plan.id_mp;

                    string query = @"sp_get_lote_salida_externa_plan_lote_for_id";
                    DataOperations dp = new DataOperations();
                    SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_header", id_Transferencia_Seleccionado);
                    //cmd.Parameters.AddWithValue("@id_ingreso", id_Traslado_Seleccionado);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    dsWizard.verLotes.Clear();
                    da.Fill(dsWizard.verLotes);
                    conn.Close();

                    //id_Traslado_Seleccionado = frm.ingreso_h.ID;
                    //txtIngresoSeleccionado.Text = id_Traslado_Seleccionado.ToString();
                    //string query = @"sp_lotes_in_ingreso_externo";
                    //DataOperations dp = new DataOperations();
                    //SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                    //cn.Open();
                    //SqlCommand cmd = new SqlCommand(query, cn);
                    //cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.AddWithValue("@id_ingreso_Externo", id_Traslado_Seleccionado);
                    //SqlDataAdapter da = new SqlDataAdapter(cmd);
                    //dsWizard.verLotes.Clear();
                    //da.Fill(dsWizard.verLotes);
                    //cn.Close();


                }

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
    }
}