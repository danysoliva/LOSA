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

namespace LOSA.MigracionACS.Produccion.Configuraciones
{
    public partial class xfrmTipoMaquina : DevExpress.XtraEditors.XtraForm
    {
        public xfrmTipoMaquina()
        {
            InitializeComponent();
            Load();
        }


        private void Load()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
                {
                    cnx.Open();

                    dsConfiguraciones.MaquinaDadoTipo.Clear();
                    SqlDataAdapter da = new SqlDataAdapter("dbo.sp_get_EQ_maquinas_dado_tipo", cnx);
                    da.Fill(dsConfiguraciones.MaquinaDadoTipo);
                    cnx.Close();

                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void gvTipoMaquinaDado_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                var row = (dsConfiguraciones.MaquinaDadoTipoRow)gvTipoMaquinaDado.GetFocusedDataRow();

                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
                {
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("dbo.sp_insert_Update_EQ_Maquina_Dado_Tipo",cnx);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = row.id;
                    cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = row.descripcion;
                    cmd.Parameters.Add("@codigo", SqlDbType.NVarChar).Value = row.codigo;

                    cmd.ExecuteNonQuery();
                    cnx.Close();
                }

                Load();

                //CajaDialogo.Error(row.id.ToString());
                //CajaDialogo.Error(row.descripcion.ToString());
                //CajaDialogo.Error(row.codigo.ToString());
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (XtraMessageBox.Show("DESEA ELIMINAR ESTE REGISTRO?", "CONFIRMACIÓN", MessageBoxButtons.YesNo) != DialogResult.No)
            {
                try
                {
                    DataOperations dp = new DataOperations();
                    SqlConnection connectionBD = new SqlConnection(dp.ConnectionStringAPMS);
                    var row = (dsConfiguraciones.MaquinaDadoTipoRow)gvTipoMaquinaDado.GetFocusedDataRow();


                    string sql = @"UPDATE dbo.EQ_Maquinas_dado_tipo
                                            SET enable = 0
                                            WHERE id = " + row.id;

                    using (SqlCommand command = new SqlCommand(sql, connectionBD))
                    {
                        connectionBD.Open();
                        command.ExecuteNonQuery();
                        connectionBD.Close();

                        Load();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}