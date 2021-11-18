using DevExpress.XtraEditors;
using LOSA.MicroIngredientes.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.MicroIngredientes
{
    public partial class xfrmConfPlanBatch : DevExpress.XtraEditors.XtraForm
    {
       public PesajeIndividualNew pesaje = new PesajeIndividualNew();

        decimal pesoRealInicial;

        public xfrmConfPlanBatch(PesajeIndividualNew Ppesaje)
        {
            InitializeComponent();

            pesaje = Ppesaje;
        }

        private void cmdUp_Click(object sender, EventArgs e)
        {
            int val = Convert.ToInt32(seBatch.EditValue);

            if (val < 200)
            {
                if ((pesaje.PesoReal+pesoRealInicial) < pesaje.PesoTotal)
                {
                    seBatch.EditValue = val + 1;

                    pesaje.BatchPlan = Convert.ToInt32(seBatch.EditValue);

                    pesaje.PesoReal = pesaje.PesoPorBatch * pesaje.BatchPlan;

                    lblPesoReal.Text = pesaje.PesoReal.ToString();
                }
            }
        }

        private void cmdDown_Click(object sender, EventArgs e)
        {
            int val = Convert.ToInt32(seBatch.EditValue);
            
            if (val > 1)
            {

                    seBatch.EditValue = val - 1;

                    pesaje.BatchPlan = Convert.ToInt32(seBatch.EditValue);

                    pesaje.PesoReal = pesaje.PesoPorBatch * pesaje.BatchPlan;

                    lblPesoReal.Text = pesaje.PesoReal.ToString();

            }
        }

        private void cmdSum10_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(seBatch.EditValue);
            decimal tmpPesoReal;

            tmpPesoReal = pesoRealInicial+pesaje.PesoPorBatch * (pesaje.BatchPlan + 10);

            if (n == 1)
            {
                if (tmpPesoReal <= pesaje.PesoTotal )
                {
                    seBatch.EditValue = 10;
                    pesaje.BatchPlan = Convert.ToInt32(seBatch.EditValue);

                    pesaje.PesoReal = pesaje.PesoPorBatch * pesaje.BatchPlan;

                    lblPesoReal.Text = pesaje.PesoReal.ToString();
                }
            }
            else
            {
                if (tmpPesoReal <= pesaje.PesoTotal)
                {
                    seBatch.EditValue = Convert.ToInt32(seBatch.EditValue) + 10;

                    pesaje.BatchPlan = Convert.ToInt32(seBatch.EditValue);

                    pesaje.PesoReal = pesaje.PesoPorBatch * pesaje.BatchPlan;

                    lblPesoReal.Text = pesaje.PesoReal.ToString();
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //if ((Convert.ToInt32(seBatch.EditValue) - 10) >= planInicial)
            //{


                int n = Convert.ToInt32(seBatch.EditValue) - 10;
                if (n < 1)
                {
                    seBatch.EditValue = 1;

                    pesaje.BatchPlan = Convert.ToInt32(seBatch.EditValue);

                    pesaje.PesoReal = pesaje.PesoPorBatch * pesaje.BatchPlan;

                    lblPesoReal.Text = pesaje.PesoReal.ToString();
                }
                else
                {
                    seBatch.EditValue = n;

                    pesaje.BatchPlan = Convert.ToInt32(seBatch.EditValue);

                    pesaje.PesoReal = pesaje.PesoPorBatch * pesaje.BatchPlan;

                    lblPesoReal.Text = pesaje.PesoReal.ToString();
                }
            //}
        }

        private void xfrmConfPlanBatch_Load(object sender, EventArgs e)
        {
            lblPesoBatch.Text = pesaje.PesoPorBatch.ToString();
            lblPesoTotal.Text = pesaje.PesoTotal.ToString();
            //lblPesoReal.Text = pesaje.PesoReal.ToString();

            //if (pesaje.BatchPlan > 1)
            //{
                //seBatch.Text = pesaje.BatchPlan.ToString();
                //pesaje.PesoReal = pesaje.PesoPorBatch * Convert.ToInt32(seBatch.Text);

            pesoRealInicial = pesaje.PesoReal;
                lblPesoReal.Text = pesaje.PesoReal.ToString();

                //planInicial = pesaje.BatchPlan;

            //}
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}