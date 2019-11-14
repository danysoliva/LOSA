using System;
using System.Data;
using System.Windows.Forms;
using LOSA.Mantenimientos.Modelos;
using System.Data.SqlClient;
using ACS.Classes;

namespace LOSA.Mantenimientos
{
    public partial class frmEstadoRequisicionCRUD : Form
    {
        DataOperations dp = new DataOperations();
        private EstadoRequisicion estadoRequisicion;
      

        public frmEstadoRequisicionCRUD()
        {
            InitializeComponent();
        }

        public frmEstadoRequisicionCRUD(EstadoRequisicion estadoRequisicion)
        {
            InitializeComponent();
            this.estadoRequisicion = estadoRequisicion;
        }

        private void frmEstadoRequisicionCRUD_Load(object sender, EventArgs e)
        {
            memoDescripcion.Text = estadoRequisicion.Descripcion;
            chkEnable.Checked = estadoRequisicion.Enable;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            estadoRequisicion.Descripcion = memoDescripcion.Text;
            estadoRequisicion.Enable = chkEnable.Checked;

            using (SqlConnection conexionLOSA = new SqlConnection(dp.ConnectionStringLOSA))
            {
                try
                {
                    if (memoDescripcion.Text.Length <= 0)
                    {
                        CajaDialogo.Error("Debe de llenar todos los campos del formulario");
                        return;

                    }
                    else
                    {
                        conexionLOSA.Open();
                        using (SqlCommand command = new SqlCommand("spInsertarActualizarEstadosRequisiciones", conexionLOSA))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add("@Id", SqlDbType.Int).Value = estadoRequisicion.Id;
                            command.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = estadoRequisicion.Descripcion;
                            command.Parameters.Add("@Enable", SqlDbType.Bit).Value = estadoRequisicion.Enable;
                            command.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = estadoRequisicion.Fecha;
                            command.ExecuteNonQuery();

                            this.DialogResult = DialogResult.OK;

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
