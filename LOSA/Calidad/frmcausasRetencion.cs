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
using System.Data.SqlClient;
using LOSA.Clases;
using ACS.Classes;

namespace LOSA.Calidad
{
    public partial class frmcausasRetencion : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado;
        string Lote;
        int id_mp;
        int ingreso;
        public enum Tipo_Reten
        {
                 Lote = 1,
                 Ingreso = 2
        }
        Tipo_Reten TipoOp;

        public frmcausasRetencion(UserLogin Puser
                                  ,string codigoP
                                  , int Id_mp
                                  , int Ingreso
                                  , string lote
                                  , string producto
                                  , Tipo_Reten POp)
        {
            InitializeComponent();
            UsuarioLogeado = Puser;
            txtitemcode.Text = codigoP;
            txtnombre.Text = producto;
            txtlote.Text = lote;
            txtingreso.Text = Ingreso.ToString();
            TipoOp = POp;
            Lote = lote;
            id_mp = Id_mp;
            ingreso = Ingreso;
        }


        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Abort;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmretencionadd frm = new frmretencionadd(2);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                int id = frm.id;
                foreach (DataRow Ite in dsCalidad.causaadd.Rows)
                {
                    if (Ite["id"].ToString() == id.ToString())
                    {
                        CajaDialogo.Error("Ya se ha registradio esta causa de retencion, por favor revisar las causas");
                        return;
                    }
                }
                DataRow Row = dsCalidad.causaadd.NewRow();
                Row["id"] = frm.id;
                Row["descripcion"] = frm.producto;
                Row["comentario"] = frm.comentario;
                dsCalidad.causaadd.Rows.Add(Row);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string Query = @"sp_load_idtm_from_lote";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                int bit = 0;
                if (TipoOp == Tipo_Reten.Lote)
                {
                    bit = 1;
                }
                else
                {
                    bit = 0;
                }
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lote", Lote);
                cmd.Parameters.AddWithValue("@bitloi", bit);
                cmd.Parameters.AddWithValue("@id_mp", id_mp);
                cmd.Parameters.AddWithValue("@ingreso" , ingreso);
                dsCalidad.Tarimas.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsCalidad.Tarimas);     
                foreach (dsCalidad.TarimasRow row in dsCalidad.Tarimas.Rows)
                {
                    cmd = new SqlCommand("sp_set_update_tarima_estado_calidad", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_estado", 3);
                    cmd.Parameters.AddWithValue("@id", row.IdTM);
                    cmd.ExecuteNonQuery();
                    foreach (dsCalidad.causaaddRow row2 in dsCalidad.causaadd.Rows)
                    {
                        cmd = new SqlCommand("sp_insert_into_calidad_tarimas", cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idtarima", row.IdTM);
                        cmd.Parameters.AddWithValue("@id_causa", row2.id);
                        cmd.Parameters.AddWithValue("@usuario", UsuarioLogeado.Id);
                        cmd.Parameters.AddWithValue("@comentario", row2.comentario);
                        cmd.ExecuteNonQuery();
                    }

                }

                cn.Close();
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}