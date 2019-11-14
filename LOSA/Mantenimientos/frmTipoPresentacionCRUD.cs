using System;
using System.Data;
using System.Windows.Forms;
using LOSA.Mantenimientos.Modelos;
using System.Data.SqlClient;
using ACS.Classes;

namespace LOSA.Mantenimientos
{
    public partial class frmTipoPresentacionCRUD : Form
    {
        DataOperations dp = new DataOperations();
        private TipoPresentacion tipoPresentacion;
        public frmTipoPresentacionCRUD()
        {
            InitializeComponent();
        }

        public frmTipoPresentacionCRUD(TipoPresentacion tipoPresentacion)
        {
            InitializeComponent();
            this.tipoPresentacion = tipoPresentacion;
        }

        private void frmTipoPresentacionCRUD_Load(object sender, EventArgs e)
        {
            memoDescripcion.Text = tipoPresentacion.Descripcion;
            chkEnable.Checked = tipoPresentacion.Enable;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            tipoPresentacion.Descripcion = memoDescripcion.Text;
            tipoPresentacion.Enable = chkEnable.Checked;

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
                        using (SqlCommand command = new SqlCommand("spInsertarActualizarTiposPresentaciones", conexionLOSA))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add("@Id", SqlDbType.Int).Value = tipoPresentacion.Id;
                            command.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = tipoPresentacion.Descripcion;
                            command.Parameters.Add("@Enable", SqlDbType.Bit).Value = tipoPresentacion.Enable;
                            command.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = tipoPresentacion.Fecha;
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