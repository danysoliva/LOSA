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

namespace LOSA.TransaccionesMP
{
    public partial class frmResumenToEntregar : DevExpress.XtraEditors.XtraForm
    {
        public decimal ExistenciaTM = 0;
        public decimal entregado = 0;
        public decimal Solicitado = 0;
        public decimal RestanteReq = 0;
        public decimal RestanteTm = 0;
        public decimal ExistenciaKg = 0;
        public decimal pesoKg = 0;
        public int id_tm;
        public decimal factor;
        public decimal ud_enviar = 0;
        public decimal kg_enviar = 0;

        DataOperations dp = new DataOperations();
        
        
        public frmResumenToEntregar(
                                    decimal ExistenciaTM,
                                    decimal PEntregado,
                                    decimal psolicitado,
                                    DataTable Tarima,
                                    int Pid_tm,
                                    decimal Pfactor)
        {

            InitializeComponent();
            //gcTarima.DataSource = Tarima;
            vGridControl1.DataSource = Tarima;
            this.ExistenciaTM = ExistenciaTM;
            ud_enviar = ExistenciaTM;
            factor = Pfactor;
            ExistenciaKg = ExistenciaTM * factor;
            lblTotalUd_en_tarima.Text = string.Format("{0:###,##0}", ExistenciaTM) + " Ud";
            entregado = PEntregado;
            Solicitado = psolicitado;
            id_tm = Pid_tm;




            Calculo();
            txtEnviados.Text = string.Format("{0:###,##0.00}", entregado);
            txtSolicitados.Text = string.Format("{0:###,##0.00}", Solicitado);
            txtPorEnviar.Text = string.Format("{0:###,##0.00}", ud_enviar);
            txtRestante.Text = string.Format("{0:###,##0.00}", RestanteReq);
            txtRestanteTarimasUnidades.Text = string.Format("{0:###,##0.00}", RestanteTm);
            obtener_factor();
            CalcularKg(dp.ValidateNumberInt32(Math.Round(ud_enviar,0)));
        }
        public void Calculo()
        {
            RestanteReq = Solicitado - entregado;
            if (RestanteReq < 0 )
            {
                RestanteReq = 0;
            }
            else
            {
                decimal aux = 0;
                aux  = RestanteReq - ExistenciaKg;

                if (aux < 0 || aux == 0)
                {
                    RestanteTm = ExistenciaKg - RestanteReq;
                    RestanteReq = 0;
                    //if (factor > 0)
                    //{
                    //    ud_enviar = Convert.ToInt32((ExistenciaKg - RestanteTm) / factor);
                    //    //RestanteTm = Convert.ToInt32(RestanteTm / factor);
                    //}
                    //else
                    //{
                    //    ud_enviar = 0;
                    //}
                }
                else
                {
                    RestanteTm = ExistenciaTM - ExistenciaKg / factor;
                    RestanteReq = aux;
                    ud_enviar = ExistenciaKg / factor;
                }

            }
        }

        public void obtener_factor() 
        {
            string qeyr = @"sp_obtener_presentacion_of_id_tm";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(qeyr,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_tarima", id_tm);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    factor = dr.GetDecimal(0);
                }
                else
                {
                    factor = 1;
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
               
        }
        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUP_Click(object sender, EventArgs e)
        {
            //if (ExistenciaKg + factor > ExistenciaTM * factor)
            //{

            //}
            //else
            //{
            //    ud_enviar = ud_enviar + 1;
            //    ExistenciaKg = ExistenciaKg + factor;
            //    CalculoUD();
            //    txtPorEnviar.Text = string.Format("{0:###,##0.00}", ud_enviar);
            //    txtRestante.Text = string.Format("{0:###,##0.00}", RestanteReq);
            //    textEdit1.Text = string.Format("{0:###,##0.00}", RestanteTm);
            //}
            int ud_enviar = dp.ValidateNumberInt32(txtPorEnviar.Text);
            if (ud_enviar == 0)
            {
                if (this.ExistenciaTM >= 1)
                {
                    txtPorEnviar.Text = "1";
                    ud_enviar = 1;
                }
            }
            else
            {
                if (ud_enviar < this.ExistenciaTM)
                {
                    if (kg_enviar + entregado < Solicitado)
                    {
                        ud_enviar++;
                        txtPorEnviar.Text = string.Format("{0:###,##0}", (ud_enviar));
                    }
                }
            }

            CalcularKg(ud_enviar);
        }

        private void CalcularKg(int pudAenviar)
        {
            if (pudAenviar > 0)
            {
                if (this.Solicitado < factor)
                    kg_enviar = this.Solicitado;
                else
                    kg_enviar = factor * pudAenviar;
            }
            else
            {
                kg_enviar = 0;
            }

            txtKgAEnviar.Text = string.Format("{0:###,##0.00}", kg_enviar);
            txtRestanteTarimasUnidades.Text = string.Format("{0:###,##0.00}", (ExistenciaTM - pudAenviar));
        }

        public void CalculoUD() 
        {
            ExistenciaKg = ud_enviar * factor;
            RestanteReq = Solicitado - ExistenciaKg - entregado;
            RestanteTm = ExistenciaTM - ud_enviar;
        } 
        private void btnDown_Click(object sender, EventArgs e)
        {
            int UdEnviar = dp.ValidateNumberInt32(txtPorEnviar.Text);
            if (UdEnviar > 0)
            {
                //if (ExistenciaKg - factor < 0)
                //{

                //}
                //else
                //{
                //    ud_enviar = ud_enviar - 1;
                //    ExistenciaKg = ExistenciaKg - factor;
                //    CalculoUD();
                //    txtPorEnviar.Text = string.Format("{0:###,##0.00}", ud_enviar);
                //    txtRestante.Text = string.Format("{0:###,##0.00}", RestanteReq);
                //    textEdit1.Text = string.Format("{0:###,##0.00}", RestanteTm);
                //}
                UdEnviar--;
                txtPorEnviar.Text = string.Format("{0:###,##0}", (UdEnviar));
            }
            CalcularKg(UdEnviar);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (ExistenciaKg == 0 )
            {
                Utileria.frmMensaje frm = new Utileria.frmMensaje(Utileria.frmMensaje.TipoMsj.error, "Debe seleccionar aun que sea una unidad");
                frm.ShowDialog();
                return;
            }
            pesoKg = ud_enviar * factor;
            this.DialogResult = DialogResult.OK;
        }

        private void chConsumirPendientes_CheckedChanged(object sender, EventArgs e)
        {
            if (chConsumirPendientes.Checked)
            {       //Vamos a consumir lo Pendiente
                RestanteReq = Solicitado - entregado; // Aqui tenemos lo restante en KG.
                ExistenciaKg = ExistenciaTM * factor; //AQui vemos los Kg que nos faltan.
                ud_enviar = 0; // Bueno inicializamos a 0 las enviar.
                decimal Validador = 0; // Es ayuda a llevar la cuenta de los kg que vamos a enviar.
                while (Validador <= RestanteReq && ExistenciaTM > ud_enviar)
                {
                    ud_enviar = ud_enviar + 1;
                    Validador = Validador + factor;
                }

                CalculoUD();

                txtPorEnviar.Text = string.Format("{0:###,##0.00}", ud_enviar);
                txtRestante.Text = string.Format("{0:###,##0.00}", RestanteReq);
                txtRestanteTarimasUnidades.Text = string.Format("{0:###,##0.00}", RestanteTm);


            }
        }

        private void frmResumenToEntregar_Load(object sender, EventArgs e)
        {
            //chConsumirPendientes.Checked = true;
        }
    }
}