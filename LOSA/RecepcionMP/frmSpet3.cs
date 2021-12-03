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

namespace LOSA.RecepcionMP
{
    public partial class frmSpet3 : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        public int Tipo_Ingreso_Selected = 0;
        public string Descripcion_Tipo_Selected = "";
        public bool isTraslado = true;
        public int id_Traslado_Seleccionado;
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
            switch (Tipo_Ingreso_Selected)
            {
                case 1:   // 1 pues es sacos
                    frmTarima_V2 frm = new frmTarima_V2(isTraslado,UsuarioLogeado, id_Traslado_Seleccionado);
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
                default:
                    break;

                    
            }
        }
    }
}