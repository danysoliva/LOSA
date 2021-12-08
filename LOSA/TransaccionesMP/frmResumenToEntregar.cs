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
        public decimal selecionado = 0;
        public decimal pesoKg = 0;
        public int id_tm;
        public decimal factor;
        public decimal ud_enviar = 0;
        DataOperations dp = new DataOperations();
        
        public frmResumenToEntregar(
                                    decimal ExistenciaTM,
                                    decimal PEntregado,
                                    decimal psolicitado,
                                    DataTable Tarima,
                                    int Pid_tm
                                    ,decimal Pfactor)
        {

            InitializeComponent();
            gcTarima.DataSource = Tarima;
            this.ExistenciaTM = ExistenciaTM;
            ud_enviar = ExistenciaTM;
            factor = Pfactor;
            selecionado = ExistenciaTM * factor;
            entregado = PEntregado;
            Solicitado = psolicitado;
            id_tm = Pid_tm;




            Calculo();
            txtEnviados.Text = string.Format("{0:###,##0.00}", entregado);
            txtSolicitados.Text = string.Format("{0:###,##0.00}", Solicitado);
            txtPorEnviar.Text = string.Format("{0:###,##0.00}", ud_enviar);
            txtRestante.Text = string.Format("{0:###,##0.00}", RestanteReq);
            textEdit1.Text = string.Format("{0:###,##0.00}", RestanteTm);
            obtener_factor();
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
                aux  = RestanteReq - selecionado;

                if (aux < 0 || aux == 0)
                {
                    RestanteTm = selecionado - RestanteReq;
                    RestanteReq = 0;
                    ud_enviar = Convert.ToInt32((selecionado - RestanteTm)  / factor);
                    RestanteTm = Convert.ToInt32(RestanteTm / factor);
                }
                else
                {
                   
                    RestanteTm= ExistenciaTM - selecionado / factor;
                    RestanteReq = aux;
                    ud_enviar = selecionado / factor;
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
            if (selecionado + factor > ExistenciaTM * factor)
            {

            }
            else
            {
                ud_enviar = ud_enviar + 1;
                selecionado = selecionado + factor;
                CalculoUD();
                txtPorEnviar.Text = string.Format("{0:###,##0.00}", ud_enviar);
                txtRestante.Text = string.Format("{0:###,##0.00}", RestanteReq);
                textEdit1.Text = string.Format("{0:###,##0.00}", RestanteTm);
            }
        }

        public void CalculoUD() 
        {
            selecionado = ud_enviar * factor;
            RestanteReq = Solicitado - selecionado - entregado;
            RestanteTm = ExistenciaTM - ud_enviar;
        } 
        private void btnDown_Click(object sender, EventArgs e)
        {
            if (selecionado - factor < 0)
            {

            }
            else
            {
                ud_enviar = ud_enviar - 1;
                selecionado = selecionado - factor;
                CalculoUD();
                txtPorEnviar.Text = string.Format("{0:###,##0.00}", ud_enviar);
                txtRestante.Text = string.Format("{0:###,##0.00}", RestanteReq);
                textEdit1.Text = string.Format("{0:###,##0.00}", RestanteTm);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (selecionado ==0 )
            {
                Utileria.frmMensaje frm = new Utileria.frmMensaje(Utileria.frmMensaje.TipoMsj.error, "Debe seleccionar aun que sea una unidad");
                frm.ShowDialog();
                return;
            }
            pesoKg = ud_enviar * factor;
            this.DialogResult = DialogResult.OK;
        }
    }
}