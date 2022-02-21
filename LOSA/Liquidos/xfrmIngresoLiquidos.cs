using ACS.Classes;
using DevExpress.XtraEditors;
using LOSA.Clases;
using LOSA.Liquidos.Models;
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

namespace LOSA.Liquidos
{
    public partial class xfrmIngresoLiquidos : DevExpress.XtraEditors.XtraForm
    {
        UserLogin usuarioLogueado = new UserLogin();
        bool Istrastado;
        int id_lote_ext;

        LabelControl[] labels = new LabelControl[6];

        public xfrmIngresoLiquidos(UserLogin userLogged)
        {
            InitializeComponent();
            Istrastado = false;
           usuarioLogueado = userLogged;
        }

        public xfrmIngresoLiquidos(UserLogin userLogged, bool isTraslado, int idlote)
        {
            InitializeComponent();
            usuarioLogueado = userLogged;
            Istrastado = true;
            id_lote_ext = idlote;
        }



        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void btnTanque1_Click(object sender, EventArgs e)
        {
            if (Istrastado)
            {
                xfrmLotesPorTanque frm = new xfrmLotesPorTanque(Convert.ToInt32(btnTanque1.Tag), usuarioLogueado, Istrastado,id_lote_ext);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    loadMPTanques();
                }
            }
            else
            {
                xfrmLotesPorTanque frm = new xfrmLotesPorTanque(Convert.ToInt32(btnTanque1.Tag), usuarioLogueado);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    loadMPTanques();
                }
            }
        }

        private void btnTanque2_Click(object sender, EventArgs e)
        {
            if (Istrastado)
            {
                xfrmLotesPorTanque frm = new xfrmLotesPorTanque(Convert.ToInt32(btnTanque2.Tag), usuarioLogueado, Istrastado, id_lote_ext);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    loadMPTanques();
                }
            }
            else
            {
                xfrmLotesPorTanque frm = new xfrmLotesPorTanque(Convert.ToInt32(btnTanque2.Tag), usuarioLogueado);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    loadMPTanques();
                }
            }
            
        }

       

        private void btnTanque3_Click(object sender, EventArgs e)
        {

            if (Istrastado)
            {
                xfrmLotesPorTanque frm = new xfrmLotesPorTanque(Convert.ToInt32(btnTanque3.Tag), usuarioLogueado, Istrastado, id_lote_ext);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    loadMPTanques();
                }
            }
            else
            {
                xfrmLotesPorTanque frm = new xfrmLotesPorTanque(Convert.ToInt32(btnTanque3.Tag), usuarioLogueado);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    loadMPTanques();
                }
            }
            
        }

        

        

        private void xfrmIngresoLiquidos_Load(object sender, EventArgs e)
        {
            labels[0] = lblMP1;
            labels[1] = lblMP2;
            labels[2] = lblMP3;


            loadMPTanques();

        }


        private void loadMPTanques()
        {
            try
            {

                DataOperations dp = new DataOperations();
                Title_MP_Tanque title_MP_Tanque = new Title_MP_Tanque();
                List< Title_MP_Tanque> titulos_Tanque = new List<Title_MP_Tanque>();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA))
                {
                    cnx.Open();

                    SqlCommand cmd = new SqlCommand("dbo.sp_get_title_mp_tanques", cnx);

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        title_MP_Tanque = new Title_MP_Tanque();

                        title_MP_Tanque.TanqueID = dr.GetInt32(0);
                        title_MP_Tanque.MP = dr.GetString(1);

                        titulos_Tanque.Add(title_MP_Tanque);

                        //Tanque1
                        if (Convert.ToInt32(lblMP1.Tag)==dr.GetInt32(0))
                        {
                            lblMP1.Text= dr.GetString(1);
                        }

                        //Tanque2
                        if (Convert.ToInt32(lblMP2.Tag) == dr.GetInt32(0))
                        {
                            lblMP2.Text = dr.GetString(1);
                        }

                        //Tanque3
                        if (Convert.ToInt32(lblMP3.Tag) == dr.GetInt32(0))
                        {
                            lblMP3.Text = dr.GetString(1);
                        }
                    }

                    cnx.Close();
                }


                //lblMP1.Text = titulos_Tanque.Where(x => x.TanqueID == Convert.ToInt32(lblMP1.Tag)).FirstOrDefault().MP;
                //lblMP2.Text = titulos_Tanque.Where(x => x.TanqueID == Convert.ToInt32(lblMP2.Tag)).FirstOrDefault().MP;
                //lblMP3.Text = titulos_Tanque.Where(x => x.TanqueID == Convert.ToInt32(lblMP3.Tag)).FirstOrDefault().MP;
              


                //for (int i = 0; i < titulos_Tanque.Count; i++)
                //{

                //    labels[i].Text = titulos_Tanque[i].MP;

                //}

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                throw;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            loadMPTanques();
        }
    }
}