using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using LOSA.Clases;
using ACS.Classes;
using System.Data.SqlClient;
using LOSA.Micro;

namespace LOSA.MicroIngredientes
{
    public partial class xfrmSpinBatchPlan : DevExpress.XtraEditors.XtraForm
    {
        public int cantBatch = 0;
        int Id;
        decimal TotalKgParaMezcladora;
        public xfrmSpinBatchPlan(int pId, string pCodigoOrden)
        {
            InitializeComponent();
            Id = pId;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                DataOperations dp = new DataOperations();
                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
                {
                    cnx.Open();
                    dsMicros1.DetalleOrdenesMicro.Clear();
                    SqlDataAdapter da = new SqlDataAdapter("[sp_get_detalle_orden_pesaje_micros_interfacev4]", cnx);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@orden_id", SqlDbType.Int).Value = Id;
                    da.Fill(dsMicros1.DetalleOrdenesMicro);
                    cnx.Close();
                    foreach (dsMicros.DetalleOrdenesMicroRow row in dsMicros1.DetalleOrdenesMicro)
                    {
                        row.Batch_Plan = 1;
                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void cmdCheck_Click(object sender, EventArgs e)
        {
            //Validar que los Kg No superen el setpoing Permitido.
            MicroIngrediente Micro = new MicroIngrediente();
            decimal SetPoinMezcladora = Micro.SetPointMezcladora;
            if (SetPoinMezcladora > 0)
            {
                if (TotalKgParaMezcladora <= 500)
                {
                    cantBatch = Convert.ToInt32(seBatch.EditValue);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    CajaDialogo.Error("No se puede generar esta cantidad de Batch! Sobrepasa la cantidad maxima de la mezcladora de Micro Ingredientes!");
                    return;
                }
            }
            else 
            {
                CajaDialogo.Error("No esta definido el Set Point maximo que utiliza la Mezcladora!");
            }
            
        }

        private void cmdUp_Click(object sender, EventArgs e)
        {
            int val = Convert.ToInt32(seBatch.EditValue); 
            if(val < 200)
            {
                seBatch.EditValue= val+1;
            }
        }

        private void cmdDown_Click(object sender, EventArgs e)
        {
            int val = Convert.ToInt32(seBatch.EditValue);
            if (val > 1)
            {
                seBatch.EditValue = val - 1;
            }
        }

        private void seBatch_EditValueChanged(object sender, EventArgs e)
        {
            //dsMicro1
            int nBatch = Convert.ToInt32(seBatch.EditValue);
            decimal KgBatch = 0;
            foreach(dsMicros.DetalleOrdenesMicroRow row in dsMicros1.DetalleOrdenesMicro)
            {
                row.Batch_Plan = nBatch;
                row.Total = row.Peso_por_Batch* nBatch;
                KgBatch += row.Total;
            }
            TotalKgParaMezcladora = KgBatch;
        }

        private void cmdSum10_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(seBatch.EditValue);
            if(n== 1)
            {
                seBatch.EditValue = 10;
            }
            else
            {
                seBatch.EditValue = Convert.ToInt32(seBatch.EditValue) + 10;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(seBatch.EditValue) - 10;
            if (n < 1)
            {
                seBatch.EditValue = 1;
            }
            else
            {
                seBatch.EditValue = n;
            }
        }
    }
}