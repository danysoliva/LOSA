using ACS.Classes;
using DevExpress.XtraEditors;
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

namespace LOSA.MigracionACS.Produccion.Eficiencia
{
    public partial class frmPT_Adicional_Eficiencia : DevExpress.XtraEditors.XtraForm
    {
        int VaridH;
        int LineaId;
        DateTime Fechai;
        DateTime FechaF;
        public frmPT_Adicional_Eficiencia(int paridH, int pLineaId)
        {
            InitializeComponent();
            VaridH = paridH;
            LineaId = pLineaId;
           
        }

        private void LoadLotes(int varidH, int lineaId)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_detalle_lotes_reg_prb_eficiencia", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idh", varidH);
                cmd.Parameters.AddWithValue("@linea", lineaId);
                dsEficiencia1.PRB_Detalle_lotes.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsEficiencia1.PRB_Detalle_lotes);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnlote_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"Select fecha_ini, fecha_fin
                                from ACS.dbo.PRB_Registro_H
                                where id = " + VaridH;
                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    Fechai = dr.GetDateTime(0);
                    FechaF = dr.GetDateTime(1);
                    dr.Close();

                    PRB_Lote_Pick_v3 lote_Pick = new PRB_Lote_Pick_v3(Fechai, FechaF, VaridH, LineaId);
                    
                    if (lote_Pick.ShowDialog() == DialogResult.Yes)
                    {
                        int lote = lote_Pick.devolver();

                        int IdPresentacionRow = lote_Pick.IdPresentacion;


                        SqlCommand cmdx = new SqlCommand("sp_set_detalle_lote_registro_prb_v2", cn);
                        cmdx.CommandType = CommandType.StoredProcedure;
                        cmdx.Parameters.AddWithValue("@id_reg_h_prb", VaridH);
                        cmdx.Parameters.AddWithValue("@lote", lote);
                        cmdx.Parameters.AddWithValue("@id_linea", LineaId);
                        cmdx.Parameters.AddWithValue("@codigo", lote_Pick.Code);
                        cmdx.Parameters.AddWithValue("@descripcion", lote_Pick.Descripcion);
                        cmdx.Parameters.AddWithValue("@cantidad", lote_Pick.spinSacosProducidos.EditValue);
                        cmdx.Parameters.AddWithValue("@fechai", DBNull.Value);
                        cmdx.Parameters.AddWithValue("@fechaf", DBNull.Value);
                        cmdx.Parameters.AddWithValue("@horas", 0);

                        if (IdPresentacionRow == 0)
                            cmdx.Parameters.AddWithValue("@id_presentacion", DBNull.Value);
                        else
                            cmdx.Parameters.AddWithValue("@id_presentacion", IdPresentacionRow);

                        cmdx.ExecuteNonQuery();

                        cn.Close();
                        LoadLotes(VaridH, LineaId);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
    }
}