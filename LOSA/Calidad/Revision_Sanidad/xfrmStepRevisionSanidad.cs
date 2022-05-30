using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using LOSA.Calidad.Revision_Sanidad.RPT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.Calidad.Revision_Sanidad
{
    public partial class xfrmStepRevisionSanidad : DevExpress.XtraEditors.XtraForm
    {
        public xfrmStepRevisionSanidad()
        {
            InitializeComponent();

            xfrmWizardRevisionanidadFirstStep uc = new xfrmWizardRevisionanidadFirstStep();
            uc.Dock = DockStyle.Fill;
            //uc.mainNavigate = this;
            this.Controls.Add(uc);
        }

        public int id_h=0;

        public xfrmStepRevisionSanidad(int id_h_p)
        {
            InitializeComponent();


            xfrmWizardRevisionanidadFirstStep uc = new xfrmWizardRevisionanidadFirstStep();
            uc.Dock = DockStyle.Fill;
            uc.id_h = id_h_p;
            //uc.mainNavigate = this;
            this.Controls.Add(uc);

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Controls.Clear();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           xrSanidad report = new xrSanidad(6);

            using (ReportPrintTool printTool = new ReportPrintTool(report))
            {
                // Send the report to the default printer.
                printTool.ShowPreviewDialog();
            }
        }
    }
}