using ACS.Classes;
using DevExpress.XtraEditors;
using LOSA.Clases;
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

namespace LOSA.Calidad
{
    public partial class xfrmTrazabilidadClientesLotes : DevExpress.XtraEditors.XtraForm
    {
        UserLogin login = new UserLogin();
        int idCliente = 0;

        public xfrmTrazabilidadClientesLotes(UserLogin log)
        {
            InitializeComponent();
            login = log;
            LoadClientes();
        }

        public xfrmTrazabilidadClientesLotes(UserLogin log,int cliente_id_p)
        {
            InitializeComponent();
            login = log;
            idCliente = cliente_id_p;
            LoadClientes();

            LoadDespachadosClientes2();
            //txtNumIngreso.EditValue
        }


        private void LoadClientes()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA))
                {
                    cnx.Open();

                    SqlDataAdapter da = new SqlDataAdapter("dbo.sp_get_Direccion_Clientes",cnx);
                    dsCalidad.Direccion_Clientes.Clear();

                    da.Fill(dsCalidad.Direccion_Clientes);

                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }



          private void LoadDespachadosClientes()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA))
                {
                    cnx.Open();

                    SqlDataAdapter da = new SqlDataAdapter("dbo.sp_get_Direccion_Clientes", cnx);
                    dsCalidad.Direccion_Clientes.Clear();

                    da.Fill(dsCalidad.Direccion_Clientes);

                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void LoadDespachadosClientes2()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA))
                {
                    cnx.Open();

                    SqlDataAdapter da = new SqlDataAdapter("sp_DespachadoClientes", cnx);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.Int).Value = idCliente;
                    dsCalidad.DespachadoClientes.Clear();

                    da.Fill(dsCalidad.DespachadoClientes);

                    cnx.Close();

                  slueCliente.EditValue = idCliente;
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }



        private void btnVer_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var row = (dsCalidad.DespachadoClientesRow)gvDespachado.GetFocusedDataRow();
                frmreporte_trazabilidad frm = new frmreporte_trazabilidad(login,row.lote_producto_termiado);


                if (this.MdiParent != null)
                    frm.MdiParent = this.MdiParent;

                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void slueCliente_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                DataOperations dp = new DataOperations();


                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA))
                {
                    cnx.Open();

                    SqlDataAdapter da = new SqlDataAdapter("sp_DespachadoClientes", cnx);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.Int).Value = slueCliente.EditValue;

                    dsCalidad.DespachadoClientes.Clear();

                    da.Fill(dsCalidad.DespachadoClientes);

                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}