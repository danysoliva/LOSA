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
        int idRM_Ext1;
        int idRM_Ext2;
        int idRM_Ext3;
        //LabelControl[] labels = new LabelControl[6];
        DataOperations dp = new DataOperations();
        int IngresoNuevo = 0;
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
                if (lblExistencia1.Text == "0 Kg")
                    IngresoNuevo = 1;
                else
                    IngresoNuevo = 0;
                xfrmLotesPorTanque frm = new xfrmLotesPorTanque(Convert.ToInt32(btnTanque1.Tag), usuarioLogueado, IngresoNuevo);

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
                if (lblExistencia2.Text == "0 Kg")
                    IngresoNuevo = 1;
                else
                    IngresoNuevo = 0;
                xfrmLotesPorTanque frm = new xfrmLotesPorTanque(Convert.ToInt32(btnTanque2.Tag), usuarioLogueado, IngresoNuevo);

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
                if (lblExistencia3.Text == "0 Kg")
                    IngresoNuevo = 1;
                else
                    IngresoNuevo = 0;
                xfrmLotesPorTanque frm = new xfrmLotesPorTanque(Convert.ToInt32(btnTanque3.Tag), usuarioLogueado, IngresoNuevo);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    loadMPTanques();
                }
            }
            
        }

        

        

        private void xfrmIngresoLiquidos_Load(object sender, EventArgs e)
        {
            //labels[0] = lblMP1;
            //labels[1] = lblMP2;
            //labels[2] = lblMP3;


            Tanque tanq1 = new Tanque(1);
            lblMP1.Text = tanq1.NombreMateriaP;
            idRM_Ext1 = tanq1.KeyMateriaPrima;
            lblExistencia1.Text = Convert.ToString(tanq1.TotalLleno)+ " Kg";

            Tanque tanq2 = new Tanque(2);
            lblMP2.Text = tanq2.NombreMateriaP;
            idRM_Ext2 = tanq2.KeyMateriaPrima;
            lblExistencia2.Text = Convert.ToString(tanq2.TotalLleno) + " Kg";

            Tanque tanq3 = new Tanque(3);
            lblMP3.Text = tanq3.NombreMateriaP;
            idRM_Ext3 = tanq3.KeyMateriaPrima;
            lblExistencia3.Text = Convert.ToString(tanq3.TotalLleno) + " Kg";


            //idRM_Ext1 = GetMaterialIdBin(88);
            //idRM_Ext2 = GetMaterialIdBin(90);
            //idRM_Ext3 = GetMaterialIdBin(91);

            //lblMP1.Text = GetMaterialName(idRM_Ext1);
            //lblMP2.Text = GetMaterialName(idRM_Ext2);
            //lblMP3.Text = GetMaterialName(idRM_Ext3);




            //loadMPTanques();

        }

        public int GetMaterialIdBin(int pIdBin)
        {
            int idRM = 0;
            try
            {
                string sql = @"SELECT [set_rm_id]
                               FROM [dbo].[MD_Bins]
                               where id = " + pIdBin;
                SqlConnection conn = new SqlConnection(dp.ConnectionStringAPMS);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                idRM = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Detalle del Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return idRM;
        }

        public string GetMaterialName(int pIdRM)
        {
            string RM = "";
            try
            {
                string sql = @"SELECT short_name
                               FROM [dbo].[MD_Raw_Material]
                               where id = " + pIdRM;
                SqlConnection conn = new SqlConnection(dp.ConnectionStringAPMS);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                RM = cmd.ExecuteScalar().ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Detalle del Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return RM;
        }


        private void loadMPTanques()
        {
            try
            {
                Tanque tanq1 = new Tanque(1);
                lblMP1.Text = tanq1.NombreMateriaP;
                idRM_Ext1 = tanq1.KeyMateriaPrima;
                lblExistencia1.Text = Convert.ToString(tanq1.TotalLleno) + " Kg";

                Tanque tanq2 = new Tanque(2);
                lblMP2.Text = tanq2.NombreMateriaP;
                idRM_Ext2 = tanq2.KeyMateriaPrima;
                lblExistencia2.Text = Convert.ToString(tanq2.TotalLleno) + " Kg";

                Tanque tanq3 = new Tanque(3);
                lblMP3.Text = tanq3.NombreMateriaP;
                idRM_Ext3 = tanq3.KeyMateriaPrima;
                lblExistencia3.Text = Convert.ToString(tanq3.TotalLleno) + " Kg";
                //DataOperations dp = new DataOperations();
                //Title_MP_Tanque title_MP_Tanque = new Title_MP_Tanque();
                //List< Title_MP_Tanque> titulos_Tanque = new List<Title_MP_Tanque>();

                //using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA))
                //{
                //    cnx.Open();

                //    SqlCommand cmd = new SqlCommand("dbo.sp_get_title_mp_tanques", cnx);

                //    SqlDataReader dr = cmd.ExecuteReader();

                //    while (dr.Read())
                //    {
                //        title_MP_Tanque = new Title_MP_Tanque();

                //        title_MP_Tanque.TanqueID = dr.GetInt32(0);
                //        title_MP_Tanque.MP = dr.GetString(1);

                //        titulos_Tanque.Add(title_MP_Tanque);

                //        //Tanque1
                //        if (Convert.ToInt32(lblMP1.Tag)==dr.GetInt32(0))
                //        {
                //            lblMP1.Text= dr.GetString(1);
                //        }

                //        //Tanque2
                //        if (Convert.ToInt32(lblMP2.Tag) == dr.GetInt32(0))
                //        {
                //            lblMP2.Text = dr.GetString(1);
                //        }

                //        //Tanque3
                //        if (Convert.ToInt32(lblMP3.Tag) == dr.GetInt32(0))
                //        {
                //            lblMP3.Text = dr.GetString(1);
                //        }
                //    }

                //    cnx.Close();
                //}


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

        private void btnTraslado_Click(object sender, EventArgs e)
        {
            //Esto debe llevar nivel de validacion de Permiso!

            xfrmTrasladoTanqueExt frm = new xfrmTrasladoTanqueExt(usuarioLogueado);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                xfrmIngresoLiquidos_Load(sender, e);
            }
        }
    }
}