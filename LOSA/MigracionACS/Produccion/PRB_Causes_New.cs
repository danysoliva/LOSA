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
using ACS.Classes;
using LOSA.MigracionACS.DataSetx;
using System.Data.SqlClient;

namespace LOSA.MigracionACS.Produccion
{
    public partial class PRB_Causes_New : DevExpress.XtraEditors.XtraForm
    {
        int Varid;
        DataOperations dp;
        int IdLinea;
        int IdCausaSelected;
        public int VaridDetalle;
        public PRB_Causes_New(int Parid, int pIdLinea, int pIdDetalle)
        {
            InitializeComponent();
            dp = new DataOperations();
            Varid = Parid;
            VaridDetalle = pIdDetalle;
            //load_data();
            IdLinea = pIdLinea;
            LoadMotivosParos();
            
        }
        public PRB_Causes_New()
        {
            InitializeComponent();
            dp = new DataOperations();
            LoadMotivosParos();

        }


        private void LoadMotivosParos()
        {
            try
            {
                string query = @"sp_get_lista_causas_tipo_paro_PRB";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                pRB_DATA.tipos_causas.Clear();
                da.Fill(pRB_DATA.tipos_causas);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los datos, contacte con el administrador", "Error");
            }
        }

        private void LoadParosPorMotivo(int pIdtipo)
        {
            try
            {
                string query = @"sp_get_lista_causas_paro_PRB";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_tipo", pIdtipo);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                pRB_DATA.CausaMain.Clear();
                da.Fill(pRB_DATA.CausaMain);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los datos, contacte con el administrador", "Error");
            }
        }

        public void load_data()
        {
            try
            {
                string Query;
                Query = @"Select id
                            ,causa
                            ,descripcion
                    From [dbo].[PRB_Causa]
                    where enable = 1";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                pRB_DATA.CausaMain.Clear();
                da.Fill(pRB_DATA.CausaMain);
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }


        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                string comentario;
                comentario = "";
                if (IdCausaSelected != 25)
                {
                    if (txtcomentario.Text == "")
                    {
                        MessageBox.Show("El comentario no puede ir vacio.", "Falta comentario");
                        txtcomentario.Focus();
                        return;
                    }
                    else
                    {
                        comentario = txtcomentario.Text;
                    }
                }

                //if (timehoras.Text == "00:00:00")
                //{
                //    MessageBox.Show("No se puede registrar la data, si la horas no han sido seleccionadas.");
                //    return;
                //}
                

                string query;
                query = @"INSERT INTO [dbo].[PRB_Transac_Regis_Caus]
                                   ([id_registro]
                                   ,[id_causa]
                                   ,[comentario]
                                   ,[enable]
                                   ,[horacausa]
                                   ,id_linea)
                             VALUES
                                   (" + Varid + @"
                                   ," + grdcausas.EditValue + @"
                                   ,'" + comentario + @"'
                                   ,1
                                   ,'"+timehoras.Text+"'"+
                                   "," + IdLinea + @")";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.ExecuteNonQuery();

                if(VaridDetalle == 0)
                {
                    //Agregar el row de detalle 
                    query = @"sp_set_insert_detalle_registro_prb";
                    
                    SqlCommand cmd1 = new SqlCommand(query, cn);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@idh", Varid);
                    cmd1.Parameters.AddWithValue("@idmaqui", IdLinea);
                    VaridDetalle = Convert.ToInt32(cmd1.ExecuteScalar());
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

        private void btnclose_Click(object sender, EventArgs e)
        {

        }

        private void btnsave_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void lblcomentario_Click(object sender, EventArgs e)
        {

        }

        private void gridLookMotivos_EditValueChanged(object sender, EventArgs e)
        {
            LoadParosPorMotivo((int)gridLookMotivos.EditValue);
            if(gridLookMotivos.EditValue != null)
            {
                grdcausas.Enabled = true;
                grdcausas.Focus();
            }
        }

        private void grdcausas_EditValueChanged(object sender, EventArgs e)
        {
            if(grdcausas.EditValue != null)
            {
                IdCausaSelected = Convert.ToInt32(grdcausas.EditValue);
                timehoras.Enabled = true;
                timehoras.Focus();
            }
        }

        private void timehoras_EditValueChanged(object sender, EventArgs e)
        {
            if(timehoras.EditValue != null)
            {
                txtcomentario.Enabled = true;
                txtcomentario.Focus();
            }
        }

        private void btnclose_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}