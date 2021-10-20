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

namespace LOSA.Calidad
{
    public partial class frmRespuestasCalidad : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public int id_respuesta;
        public string Respuesta;
        bool ismanual;
        public frmRespuestasCalidad(bool Pismanual)
        {
            InitializeComponent(); 
            load_repuestas();
            ismanual = Pismanual;
        }

        public void load_repuestas()
        {
            string query= @"sp_cargar_respuestas_parametros";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsMantenimientoC.respuesta.Clear();
                da.Fill(dsMantenimientoC.respuesta);
                cn.Close();


            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }

        }

        private void frmRespuestasCalidad_Load(object sender, EventArgs e)
        {
            checkEdit1.Checked = ismanual;
            if (!checkEdit1.Checked)
            {
                grd_seleccion.Visible = true;
                txtmanual.Visible = false;
                grd_seleccion.ShowPopup();
            }
            else
            {
                grd_seleccion.Visible = false;
                txtmanual.Visible = true;
                txtmanual.Focus();
            }
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkEdit1.Checked)
            {
                grd_seleccion.Visible = true;
                txtmanual.Visible = false;
                grd_seleccion.ShowPopup();
            }
            else
            {
                grd_seleccion.Visible = false;
                txtmanual.Visible = true;
                txtmanual.Focus();
            }
        }

        private void btnSeleccioanr_Click(object sender, EventArgs e)
        {
                if (checkEdit1.Checked)
                {      //Si es manual
                    if (txtmanual.Text == "")
                    {
                        CajaDialogo.Error("Debe definer la informacion manual para poder guardar.");
                        txtmanual.Focus();
                        return;
                    }
                    id_respuesta = 0;
                    Respuesta = txtmanual.Text;
                this.DialogResult = DialogResult.OK;
                }
                else
                {
                    if (grd_seleccion.EditValue == null)
                    {
                        CajaDialogo.Error("Debe definer la informacion manual para poder guardar.");
                        grd_seleccion.ShowPopup();
                        return;
                    }
                    id_respuesta = Convert.ToInt32(grd_seleccion.EditValue);
                    Respuesta = grd_seleccion.Text;
                this.DialogResult = DialogResult.OK;

            }

           
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}