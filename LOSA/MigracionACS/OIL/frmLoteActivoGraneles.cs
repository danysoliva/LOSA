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
using System.Data.SqlClient;
using ACS.Classes;

namespace LOSA.MigracionACS.OIL
{
    public partial class frmLoteActivoGraneles : DevExpress.XtraEditors.XtraForm
    {
        public frmLoteActivoGraneles()
        {
            InitializeComponent();
            Silo1 = new BinGranel();
            Silo2= new BinGranel();
            Silo3= new BinGranel();
            Silo4= new BinGranel();

            Modulo1= new BinGranel();
            Modulo2= new BinGranel();
            Modulo3= new BinGranel();
            Modulo4= new BinGranel();

            //BIN
            if(Silo1.RecuperaRegistro(BinGranel.TipoBin.Silo, BinGranel.Bin.Silo1))
            {
                lblMateriaPrimaSilo1.Text = Silo1.LoteMP;
            }
            if (Silo2.RecuperaRegistro(BinGranel.TipoBin.Silo, BinGranel.Bin.Silo2))
            {
                lblMateriaPrimaSilo2.Text = Silo2.LoteMP;
            }
            if (Silo3.RecuperaRegistro(BinGranel.TipoBin.Silo, BinGranel.Bin.Silo3))
            {
                lblMateriaPrimaSilo3.Text = Silo3.LoteMP;
            }
            if (Silo4.RecuperaRegistro(BinGranel.TipoBin.Silo, BinGranel.Bin.Silo4))
            {
                lblMateriaPrimaSilo4.Text = Silo4.LoteMP;
            }


            //Modulos
            if (Modulo1.RecuperaRegistro(BinGranel.TipoBin.Modulo, BinGranel.Bin.Modulo1))
            {
                lblModulo1.Text = Modulo1.LoteMP;
            }
            if (Modulo2.RecuperaRegistro(BinGranel.TipoBin.Modulo, BinGranel.Bin.Modulo2))
            {
                lblModulo2.Text = Modulo2.LoteMP;
            }
            if (Modulo3.RecuperaRegistro(BinGranel.TipoBin.Modulo, BinGranel.Bin.Modulo3))
            {
                lblModulo3.Text = Modulo3.LoteMP;
            }
            if (Modulo4.RecuperaRegistro(BinGranel.TipoBin.Modulo, BinGranel.Bin.Modulo4))
            {
                lblModulo4.Text = Modulo4.LoteMP;
            }

        }

        BinGranel Silo1;
        BinGranel Silo2;
        BinGranel Silo3;
        BinGranel Silo4;

        BinGranel Modulo1;
        BinGranel Modulo2;
        BinGranel Modulo3;
        BinGranel Modulo4;


        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdCambiarSilo1_Click(object sender, EventArgs e)
        {
            frmLotesDisponiblesGranel frm = new frmLotesDisponiblesGranel();
            if(frm.ShowDialog()== DialogResult.OK)
            {
                SetId_LoteBin(frm.IdLoteActivo, (int)Silo1.BinIdActual, frm.Lote);
                lblMateriaPrimaSilo1.Text = (frm.Lote + " - " + frm.MP);
            }
        }

        private void SetId_LoteBin(int idLoteActivo, int pId_ubicacion, string pLote)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_set_update_id_lote_activo_bin_granel_LOSA", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_lote", idLoteActivo);
                cmd.Parameters.AddWithValue("@id_ubicacion", pId_ubicacion);
                cmd.Parameters.AddWithValue("@lote", pLote);
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdCambiarSilo2_Click(object sender, EventArgs e)
        {
            frmLotesDisponiblesGranel frm = new frmLotesDisponiblesGranel();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                SetId_LoteBin(frm.IdLoteActivo, (int)Silo2.BinIdActual, frm.Lote);
                lblMateriaPrimaSilo2.Text = (frm.Lote + " - " + frm.MP);
            }
        }

        private void cmdCambiarSilo3_Click(object sender, EventArgs e)
        {
            frmLotesDisponiblesGranel frm = new frmLotesDisponiblesGranel();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                SetId_LoteBin(frm.IdLoteActivo, (int)Silo3.BinIdActual, frm.Lote);
                lblMateriaPrimaSilo3.Text = (frm.Lote + " - " + frm.MP);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
        }

        private void cmdCambiarSilo4_Click(object sender, EventArgs e)
        {
            frmLotesDisponiblesGranel frm = new frmLotesDisponiblesGranel();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                SetId_LoteBin(frm.IdLoteActivo, (int)Silo4.BinIdActual, frm.Lote);
                lblMateriaPrimaSilo4.Text = (frm.Lote + " - " + frm.MP);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmLotesDisponiblesGranel frm = new frmLotesDisponiblesGranel();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                SetId_LoteBin(frm.IdLoteActivo, (int)Modulo1.BinIdActual, frm.Lote);
                lblModulo1.Text = (frm.Lote + " - " + frm.MP);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmLotesDisponiblesGranel frm = new frmLotesDisponiblesGranel();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                SetId_LoteBin(frm.IdLoteActivo, (int)Modulo2.BinIdActual, frm.Lote);
                lblModulo2.Text = (frm.Lote + " - " + frm.MP);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmLotesDisponiblesGranel frm = new frmLotesDisponiblesGranel();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                SetId_LoteBin(frm.IdLoteActivo, (int)Modulo3.BinIdActual, frm.Lote);
                lblModulo3.Text = (frm.Lote + " - " + frm.MP);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLotesDisponiblesGranel frm = new frmLotesDisponiblesGranel();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                SetId_LoteBin(frm.IdLoteActivo, (int)Modulo4.BinIdActual, frm.Lote);
                lblModulo4.Text = (frm.Lote + " - " + frm.MP);
            }
        }
    }//end clase
}