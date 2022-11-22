using ACS.Classes;
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

namespace LOSA.MigracionACS.Produccion
{
    public partial class PRB_Add_Reproceso : Form
    {
        int IdLinea = 0;
        int IdRegH = 0;

        public PRB_Add_Reproceso(int pIdLInea, int pIdreg)
        {
            InitializeComponent();
            LoadPresentaciones();
            IdLinea = pIdLInea;
            IdRegH = pIdreg;
            LoadData();
            LoadTipoReproceso();
        }

        private void LoadTipoReproceso()
        {
            try
            {
                string query = @"SELECT [id]
                                      ,[descripcion]
                                  FROM [dbo].[PRB_Registro_tipo_Reproceso]
                                  where id_linea = @idlinea
	                                    and enable = 1";
                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@idlinea", IdLinea);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                prB_DATA21.tipo_reproceso.Clear();
                da.Fill(prB_DATA21.tipo_reproceso);
                cn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los datos, contacte con el administrador", "Error");
            }
        }

        private void LoadData()
        {
            try
            {
                string data;
                data = @"Select DISTINCT D.fp_lot_number,
                                C.code as Codigo
                              , C.long_name as Descripcion
                        From [dbo].[OP_Batch_Intake_Data_RM] A
                        left JOIN [dbo].[OP_Production_Orders_Main_Mix] D
		                        ON A.[order_mix_id] = D.[id] 
                        left JOIN [dbo].[OP_Production_Orders_Main] B
		                        ON A.[order_id] = B.[id]
                        left JOIN [dbo].[MD_Finished_Products] C
		                        ON B.[fp_id] = C.[id]
		                where d.start_date between '" + DateTime.Now.AddDays(-7).ToString("yyyy-MM-dd") +
                            @"'and '" + DateTime.Now.AddDays(3).ToString("yyyy-MM-dd") + @"'"
                        + @" and D.fp_lot_number not in (SELECT [lote]
                                                          FROM [AQFSVR003].ACS.[dbo].[PRB_Registro_H_Lotes]
                                                          where enable = 1
                                                                and id_reg_h_prb = " + IdRegH
                                                                + " and id_linea = " + IdLinea + ")";
                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringAPMS);
                cn.Open();
                SqlCommand cmd = new SqlCommand(data, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                prB_DATA21.loadlot.Clear();
                da.Fill(prB_DATA21.loadlot);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadPresentaciones()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();
                string sql = @"SELECT [id]
                                  ,[net] as description
                              FROM [dbo].[PT_Products_Bags]
                              where enable = 1";
                SqlCommand cmd = new SqlCommand(sql, con);
                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                dsEficiencia1.presentaciones.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsEficiencia1.presentaciones);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DialogResult r = CajaDialogo.Pregunta("Esta seguro de guardar este Registro de Reproceso?");
            //if (r != DialogResult.Yes)
            //    return;
            if (toggleSwitchAplicaReproceso.IsOn)
            {
                if (string.IsNullOrEmpty(gridLookUpEditLote.Text))
                {
                    CajaDialogo.Error("Debe ingresar obligatoriamente el Lote!");
                    return;
                }

                //gridLookUpEditTipoReproceso
                if (string.IsNullOrEmpty(gridLookUpEditTipoReproceso.Text))
                {
                    CajaDialogo.Error("Debe ingresar obligatoriamente el Tipo de Reproceso!");
                    return;
                }
            }

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();
                string sql = @"sp_set_reproceso_registro_prd_h";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_h", IdRegH);
                cmd.Parameters.AddWithValue("@id_linea", IdLinea);

                if (toggleSwitchAplicaReproceso.IsOn)
                {   
                    cmd.Parameters.AddWithValue("@cantidad", spinCantidad.EditValue);
                    cmd.Parameters.AddWithValue("@id_presentacion", gridLookPresentacion.EditValue);
                    cmd.Parameters.AddWithValue("@lote", gridLookUpEditLote.EditValue);
                    cmd.Parameters.AddWithValue("@id_tipo", gridLookUpEditTipoReproceso.EditValue);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@cantidad", 0);
                    cmd.Parameters.AddWithValue("@id_presentacion", DBNull.Value);
                    cmd.Parameters.AddWithValue("@lote", DBNull.Value);
                    cmd.Parameters.AddWithValue("@id_tipo", DBNull.Value);
                }

                cmd.ExecuteNonQuery();
                con.Close();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void gridLookPresentacion_EditValueChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void CalcularTotal()
        {
            spinEditTotal.EditValue = (Convert.ToDecimal(gridLookPresentacion.Text) * spinCantidad.Value);    
        }

        private void spinCantidad_EditValueChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void toggleSwitchAplicaReproceso_Toggled(object sender, EventArgs e)
        {
            if (!toggleSwitchAplicaReproceso.IsOn)
            {
                gridLookUpEditTipoReproceso.Enabled =
                gridLookUpEditLote.Enabled =
                spinCantidad.Enabled =
                gridLookPresentacion.Enabled = false;
            }
            else
            {
                gridLookUpEditTipoReproceso.Enabled =
                gridLookUpEditLote.Enabled =
                spinCantidad.Enabled =
                gridLookPresentacion.Enabled = true;
            }
        }
    }
}
