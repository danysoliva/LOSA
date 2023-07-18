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
using LOSA.Liquidos;

namespace LOSA.RecepcionMP
{
    public partial class frmSpet2 : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado; 
        public int Tipo_Ingreso_Selected = 0;
        public string Descripcion_Tipo_Selected = "";
        public bool isTraslado;
        public frmSpet2(UserLogin Puser, string Ptipo_descripcion, int Pid_tipo)
        {
            InitializeComponent();
            UsuarioLogeado = Puser;
            Tipo_Ingreso_Selected = Pid_tipo;
            Descripcion_Tipo_Selected = Ptipo_descripcion;
            labelControl1.Text = labelControl1.Text + " Tipo de Ingreso: " + Descripcion_Tipo_Selected;
        }

        public void Next_step()
        {
            if (isTraslado)
            {   //step 3
                //Ingreso directo
                frmSpet3 frm = new frmSpet3(UsuarioLogeado, Descripcion_Tipo_Selected, Tipo_Ingreso_Selected);
                switch (frm.ShowDialog())
                {
                    case DialogResult.OK:
                        break;
                    case DialogResult.Cancel:
                        this.DialogResult = DialogResult.Cancel;
                        this.Close();
                        break;
                    case DialogResult.Abort:
                        break;
                    default:
                        break;
                }
            }
            else
            {    //step4
                switch (Tipo_Ingreso_Selected)
                {
                    case 1:   // 1 pues es sacos
                        frmTarima_V2 frm = new frmTarima_V2(isTraslado, UsuarioLogeado, 0);
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

                    case 2: // granel

                        frmMP_Granel frmGranel = new frmMP_Granel(UsuarioLogeado);


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
                        xfrmIngresoLiquidos frmLiquidos = new xfrmIngresoLiquidos(UsuarioLogeado);

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
        }
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnyes_Click(object sender, EventArgs e)
        {

            btnyes.Appearance.BackColor = Color.FromArgb(0, 178, 149);
            btnNo.Appearance.BackColor = Color.FromArgb(235, 236, 239);
            isTraslado = true;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            btnNo.Appearance.BackColor = Color.FromArgb(0, 178, 149);
            btnyes.Appearance.BackColor = Color.FromArgb(235, 236, 239);
            isTraslado = false;

           
        }

        private void btnyes_DoubleClick(object sender, EventArgs e)
        {
            btnyes.Appearance.BackColor = Color.FromArgb(0, 178, 149);
            btnNo.Appearance.BackColor = Color.FromArgb(235, 236, 239);
            isTraslado = true;
            // Step 3
            Next_step();
        }

        private void btnNo_DoubleClick(object sender, EventArgs e)
        {
            btnNo.Appearance.BackColor = Color.FromArgb(0, 178, 149);
            btnyes.Appearance.BackColor = Color.FromArgb(235, 236, 239);
            isTraslado = false;
            Next_step();
            //step 4
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Next_step();
        }
    }
}