using ACS.Classes;
using DevExpress.XtraEditors;
using LOSA.Clases;
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

namespace LOSA.MicroIngredientes._3erNivelBascula
{
    public partial class frmDetalleBatchAD : DevExpress.XtraEditors.XtraForm
    {
        Int64 IdBatch;
        Int64 IdOrder;
        int LotePT;
        public frmDetalleBatchAD(Int64 pIdBatch, Int64 pIdOrder, int pLotePT)
        {
            InitializeComponent();
            IdBatch = pIdBatch;
            IdOrder = pIdOrder;
            LotePT = pLotePT;

            if(IdBatch > 0 )
            {
                //Cargamos los datos en proceso del batch actual

            }
            else
            {
                //Creamos un nuevo batch

            }
        }

        private void frmDetalleBatchAD_Load(object sender, EventArgs e)
        {

        }

        private void teCodBarra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataOperations dp = new DataOperations();
                //int LotePT = dp.ValidateNumberInt32(txtLotePT1.Text);
                if (LotePT == 0)
                {
                    CajaDialogo.Error("No hay una orden activa en Consola en el mezclado 1!");
                    return;
                }

                AlimentacionTolvaMicrosPesaje alimentacionTolva = new AlimentacionTolvaMicrosPesaje();
                if (alimentacionTolva.RecuperaRegistro(teCodBarra.Text))
                {
                    if (alimentacionTolva.Lot != LotePT)
                    {
                        CajaDialogo.Error("Esta orden no pertenece al Lote: " + LotePT.ToString() + "!");
                        return;
                    }

                    xfrmMezclaMicroShow frm = new xfrmMezclaMicroShow(IdOrder, 0, teCodBarra.Text, alimentacionTolva.IdMP);
                    //xfrmMezclaMicroShow frm = new xfrmMezclaMicroShow( order_id,Convert.ToInt32(txtCodBarra.Text));
                    bool batchCompletados;
                    int tipo_pesaje = alimentacionTolva.TipoPesaje;
                    try
                    {

                        if (IdOrder == 0)
                        {
                            CajaDialogo.Error("NO HAY UNA ORDEN ACTIVA");
                            return;
                        }


                        //if (alimentacionTolva.RecuperaRegistro(Convert.ToInt32(teCodBarra.Text), order_id))
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
                            {
                                cnx.Open();

                                SqlCommand cmd = new SqlCommand("sp_insert_adicionMezclado_acumularBatch_v4", cnx);
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@codigo_barra_pesaje_individual", alimentacionTolva.CodigoBarra);

                                batchCompletados = Convert.ToBoolean(cmd.ExecuteScalar());
                                cnx.Close();
                            }



                            if (batchCompletados == true)
                            {
                                CajaDialogo.Error("NO SE PUEDE ADICIONAR MAS BATCH, YA SE COMPLETO");
                                teCodBarra.Text = "";
                                teCodBarra.Focus();
                                return;
                            }
                            else
                            {
                                if (tipo_pesaje == 1)
                                {
                                    //PESAJE DE NUCLEO
                                    //LoadData2();
                                }
                                else
                                {
                                    //PESAJE INDIVIDUAL
                                    //LoadDataIndividual();
                                }
                            }

                            teCodBarra.Text = "";
                            teCodBarra.Focus();

                        }

                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                    }
                }
            }
        }//teCodBarra_KeyDown

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}