using ACS.Classes;
using LOSA.MigracionACS.Produccion.Configuraciones.Model;
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
using static LOSA.MigracionACS.Produccion.Configuraciones.xfrmMaquinasDadoCRUD;

namespace LOSA.MigracionACS.Produccion.Configuraciones
{
    public partial class xfrmMaquinasDadoMain : DevExpress.XtraEditors.XtraForm
    {
        public xfrmMaquinasDadoMain()
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

                    dsConfiguraciones.MaquinaDado.Clear();
                    SqlDataAdapter da = new SqlDataAdapter("dbo.sp_get_maquinas_dado", cnx);
                    da.Fill(dsConfiguraciones.MaquinaDado);
                    cnx.Close();

                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                   xfrmMaquinasDadoCRUD frm = new xfrmMaquinasDadoCRUD((int)TipoTransaccion.Nuevo,null);

                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        Load();
                    }
          

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnEditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var row = (dsConfiguraciones.MaquinaDadoRow)gvMaquinaDado.GetFocusedDataRow();

                if (row != null)
                {

                MaquinaDado maquinaDado = new MaquinaDado();
                maquinaDado.ID = row.id;
                maquinaDado.Descripcion = row.descripcion;
                maquinaDado.MaquinaID = row.id_maquina;
                maquinaDado.Tipo = row.id_tipo;

                xfrmMaquinasDadoCRUD frm = new xfrmMaquinasDadoCRUD((int)TipoTransaccion.Editar,maquinaDado);

                    if (frm.ShowDialog()== DialogResult.OK)
                    {
                        Load();
                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnEliminar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (XtraMessageBox.Show("DESEA ELIMINAR ESTE REGISTRO?", "CONFIRMACIÓN", MessageBoxButtons.YesNo) != DialogResult.No)
            {
                try
                {
                    DataOperations dp = new DataOperations();
                    SqlConnection connectionBD = new SqlConnection(dp.ConnectionStringAPMS);
                    var row = (dsConfiguraciones.MaquinaDadoRow)gvMaquinaDado.GetFocusedDataRow();


                    string sql = @"UPDATE dbo.EQ_Maquinas_dado
                                            SET enable = 0
                                            WHERE id = "+ row.id;

                    using (SqlCommand command = new SqlCommand(sql, connectionBD))
                    {
                        connectionBD.Open();
                        //command.CommandType = CommandType.StoredProcedure;
                        //command.Parameters.Add("@id", SqlDbType.Int).Value = row.id;

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

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}