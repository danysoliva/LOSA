using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACS.Classes;
using System.Data.SqlClient;
using LOSA.Clases;

namespace LOSA.MigracionACS.Formulas
{
    public partial class FML_FF_Edit : Form
    {
        FMOP fmop = new FMOP();
        DataOperations dp = new DataOperations();
        int IDFORMULA;
        string ActivoUser;
        public FML_FF_Edit(int idFormula, string ActiveUserCode)
        {
            InitializeComponent();
            ActivoUser = ActiveUserCode;
            this.IDFORMULA = idFormula;
            load_owner();
            loadstatus();
            load_acs_user();
            grdEstructura.DataSource = fmop.ext_formula_get_structure(IDFORMULA);
            load_data();
        }
        void load_acs_user()
        {
            try
            {//Usuarios configurados en ACS
                string Query;
                Query = @"SELECT [id]
                          ,[nombre]
                      FROM [dbo].[conf_usuarios]";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                sdformula.user.Clear();
                da.Fill(sdformula.user);
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        void loadstatus()
        {
            try
                //Carga de los tipos de status
            {
                string Query = @"SELECT  Distinct
                                          [status],
                                        ( Case when status = 30 then 'Pendientes de Aprobar'
		                                    when status = 35 then 'Pendientes de Aprobar'
		                                    when status = 40 then 'Aprobada'
		                                    when status = 90 then 'Descontinuada'
		                                    when status = 95 then 'Descontinuada' end) as Descripcion
                                      FROM [dbo].[FML_Fomulas_FF_H]";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                SqlCommand cmd = new SqlCommand(Query, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                sdformula.status.Clear();
                da.Fill(sdformula.status);
                cn.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
        void load_owner()
        {
            try
                //La company de las formulas o due;os
            {
                string query = @"SELECT  Distinct
                                  [lcl_owner]
	                              ,(Case when lcl_owner = 'N' then 'Nutreco' 
			                            when lcl_owner = 'R' then 'Regal' end) as descripcion
                              FROM [dbo].[FML_Fomulas_FF_H]";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn );
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                sdformula.Owner.Clear();
                da.Fill(sdformula.Owner);
                cn.Close();

            }
            catch (Exception)
            {

                throw;
            }

        }
        void load_data()
        {
            try 
            {/// cargado general de data de la formula
                string query = @"SELECT  
                               [src_company_code] -- 0
                              ,[src_company_name] -- 1
                              ,[src_mix_type]     --2
                              ,[src_mix_ref_code] --3
                              ,[src_formula_code] --4
                              ,[src_formula_name] --5
                              ,[src_batch_size_kg] --6
                              ,[lcl_loaded_date]  --7
                              ,[lcl_name]       --8
                              ,[lcl_loaded_by]   --9
                              ,[lcl_last_mod_by]  --10
                              ,[status]        --11
                              ,Coalesce([aprove_prod_u], 0)   --12
                              ,Coalesce([aprove_fin_u], 0)  --13
                              ,[lcl_owner]       --14
                            ,[available_date]    -15
                          FROM [dbo].[FML_Fomulas_FF_H]
                          where id = " + IDFORMULA + @"";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtID.Text = Convert.ToString(IDFORMULA);
                    txtcompanycode.Text = dr[0].ToString();
                    txtcompany.Text = dr[1].ToString();
                    txtMix.Text = dr[2].ToString();
                    txtMixRef.Text = dr[3].ToString();
                    txtformula.Text = dr[4].ToString();
                    txtfornombre.Text = dr[5].ToString();
                    txtbatch.Text = dr[6].ToString();
                    dtsrc_last_updated.Text = String.Format("{0:dd/MM/yyyy}",dr[7].ToString());
                    txtnamedecarga.Text = dr[8].ToString();
                    grdacsuser.EditValue = Convert.ToInt32(dr[9].ToString());
                    grdlastmod.EditValue = Convert.ToInt32(dr[10].ToString());
                    grdstatus.EditValue = Convert.ToInt32(dr[11].ToString());
                    grdaprobprod.EditValue = Convert.ToInt32(dr[12].ToString());
                    grdaprobAdmon.EditValue = Convert.ToInt32(dr[13].ToString());
                    grdowner.EditValue = dr[14].ToString();
                    dtavailable.Text = Convert.ToDateTime(dr[15]).ToString();


                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
           

         


        }

        private void buttonEdit1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEdit2_Click(object sender, EventArgs e)
        {
            load_data();
        }
        void insert_comment()
        {
            FMOP op = new FMOP();
            op.ext_formula_comment_entry(IDFORMULA, Convert.ToInt32(ActivoUser), "Edicion de formula", false);
            op.ext_formula_event_entry(IDFORMULA, Convert.ToInt32(ActivoUser), "EDIT", "Cambios generales.");
        }
        private void buttonEdit3_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Falta codigo de formula.");
                txtID.Focus();
                return;
            }
            if (txtcompany.Text == "")
            {
                MessageBox.Show("Falta el nombre de la Compañia");
                txtcompany.Focus();
                return;
            }
            if (txtcompanycode.Text == "")
            {
                MessageBox.Show("Falta el codigo de la Compañia");
                txtcompanycode.Focus();
                return;
            }
            if (txtMix.Text == "")
            {
                MessageBox.Show("Mix no puede quedar vacio");
                txtMix.Focus();
                return;
            }
            if (txtMixRef.Text == "")
            {
                MessageBox.Show("La referencia del mix no puede quedar vacio");
                txtMixRef.Focus();
                return;
            }
            if (txtbatch.Text == "")
            {
                MessageBox.Show("La inclusion de bach no puede quedar en vacia");
                txtbatch.Focus();
                return;
            }
            if (grdstatus.EditValue == DBNull.Value)
            {
                MessageBox.Show("El estatus no puede quedar vacio");
                grdstatus.Focus();
                return;
            }
            if (grdaprobprod.EditValue == DBNull.Value)
            {
                MessageBox.Show("El aprobador de produccion no puede ir vacio");
                grdaprobprod.Focus();
                return;
            }
            if (grdaprobAdmon.EditValue == DBNull.Value)
            {
                MessageBox.Show("El aprobador de Administracion no puede ir vacio");
                grdaprobAdmon.Focus();
                return; 
            }
            if (grdowner.EditValue == DBNull.Value)
            {
                MessageBox.Show("El dueño de la formula no puede ir vacia.");
                grdowner.Focus();
                return;

            }
            try
            {
                string guardar = @"UPDATE [dbo].[FML_Fomulas_FF_H]
                                       SET  [src_company_code] = @companycode
                                                                  ,[src_company_name] = @company
                                                                  ,[src_mix_type]    = @mix
                                                                  ,[src_mix_ref_code] = @mixref
                                                                  ,[src_batch_size_kg] = @batch
                                                                  ,[lcl_name]       = @lclname
                                                                  ,[lcl_last_mod_by]  = @lastmod
                                                                    ,lcl_last_mod_date = @datelastmod
                                                                  ,[status]     =  @status
                                                                  ,[lcl_owner] = @dueno
                                                                  ,[available_date] = @dateave
				                                    where  id = @id";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(guardar,cn);
                cmd.Parameters.Add("@company", SqlDbType.VarChar).Value = txtcompany.Text;
                cmd.Parameters.Add("@companycode", SqlDbType.VarChar).Value = txtcompanycode.Text;
                cmd.Parameters.Add("@mix", SqlDbType.VarChar).Value = txtMix.Text;
                cmd.Parameters.Add("@mixref", SqlDbType.VarChar).Value = txtMixRef.Text;
                cmd.Parameters.Add("@batch", SqlDbType.Decimal).Value = Convert.ToDecimal(txtbatch.Text);
                cmd.Parameters.Add("@lclname", SqlDbType.VarChar).Value = txtnamedecarga.Text;
                cmd.Parameters.Add("@lastmod", SqlDbType.Int).Value = Convert.ToInt32(ActivoUser);
                cmd.Parameters.Add("@datelastmod", SqlDbType.DateTime).Value = String.Format("{0:yyyy-MM-dd HH:mm:ss}",DateTime.Now);
                cmd.Parameters.Add("@status", SqlDbType.Int).Value = grdstatus.EditValue;
                cmd.Parameters.Add("@dueno", SqlDbType.VarChar).Value = grdowner.EditValue;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = IDFORMULA;
                cmd.Parameters.Add("@dateave", SqlDbType.DateTime).Value = String.Format("{0:yyyy-MM-dd HH:mm:ss}", dtavailable.Text); 
               cmd.ExecuteNonQuery();
                this.DialogResult = DialogResult.OK;
                this.Close();
                insert_comment();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
