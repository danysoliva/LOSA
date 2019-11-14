using ACS.Classes;
using LOSA.Mantenimientos.Modelos;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LOSA.Mantenimientos
{
    public partial class frmTipoPresentacion : Form
    {
        DataOperations dp = new DataOperations();
       public frmTipoPresentacion()
        {
            InitializeComponent();
            CargarDatos();
        }

        void CargarDatos()
        {
            try
            {
                using (SqlConnection conexionLOSA = new SqlConnection(dp.ConnectionStringLOSA))
                {
                    dsMantenimiento.TiposPresentacionesDataTable.Clear();
                    SqlDataAdapter adapter = new SqlDataAdapter("exec spObtenerTiposPresentaciones", conexionLOSA);
                    adapter.Fill(dsMantenimiento.TiposPresentacionesDataTable);
                }

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }


        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmTipoPresentacionCRUD frm = new frmTipoPresentacionCRUD(new TipoPresentacion());
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarDatos();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            TipoPresentacion tipoPresentacion = new TipoPresentacion
            {
                Id = Convert.ToInt32(gvTiposPresentaciones.GetRowCellValue(gvTiposPresentaciones.GetRowHandle(gvTiposPresentaciones.GetSelectedRows()[0]), colid)),
                Descripcion = gvTiposPresentaciones.GetRowCellValue(gvTiposPresentaciones.GetRowHandle(gvTiposPresentaciones.GetSelectedRows()[0]), coldescripcion).ToString(),
                Enable = Convert.ToBoolean(gvTiposPresentaciones.GetRowCellValue(gvTiposPresentaciones.GetRowHandle(gvTiposPresentaciones.GetSelectedRows()[0]), colenable))
            };

            frmTipoPresentacionCRUD frm = new frmTipoPresentacionCRUD(tipoPresentacion);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarDatos();
            }
        }
    }
}
