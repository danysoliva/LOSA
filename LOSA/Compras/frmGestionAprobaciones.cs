using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;
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

namespace LOSA.Compras
{
    public partial class frmGestionAprobaciones : Form
    {
        UserLogin UsuarioLogeado;
        public frmGestionAprobaciones(UserLogin pUsuarioLogeado)
        {
            InitializeComponent();
            UsuarioLogeado = pUsuarioLogeado;
            LoadPendientes(UsuarioLogeado.Id);
        }

        private void LoadPendientes(int pIdUsuario)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[sp_get_detalle_ordenes_compra_pendiente_aprobacion]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_usuario", pIdUsuario);
                dsAutorizacionesCompras1.pendienes_aprobacion.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsAutorizacionesCompras1.pendienes_aprobacion);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        

        private void cmdGestionar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsAutorizacionesCompras.pendienes_aprobacionRow)gridView.GetFocusedDataRow();

            if(row.Isid_estadoNull())
            {
                return;
            }
            else
            {
                if (row.id_estado > 1)
                {
                    CajaDialogo.Error("Esta orden de compra ya fue gestionada!");
                    return;
                }
            }

            CMOrdenCompraH pOrdenActual = new CMOrdenCompraH();
            if(pOrdenActual.RecuperarRegistro(row.id))
            {
                frmConfirmationAutorization frm = new frmConfirmationAutorization(pOrdenActual);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    bool IsCommit = false;
                    int idEstadoNew = 0;
                    string EstadoNameNew = string.Empty;
                    DataOperations dp = new DataOperations();
                    using (SqlConnection connection = new SqlConnection(dp.ConnectionStringLOSA))
                    {
                        connection.Open();

                        SqlCommand command = connection.CreateCommand();
                        SqlTransaction transaction;

                        // Start a local transaction.
                        transaction = connection.BeginTransaction("SampleTransaction");

                        // Must assign both transaction object and connection
                        // to Command object for a pending local transaction
                        command.Connection = connection;
                        command.Transaction = transaction;

                        try
                        {

                            //Transaccion de aprobacion
                            command.CommandText = "dbo.sp_set_insert_aprobacion_orden_compra_h";
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Clear();

                            
                            if (frm.IsApproved)
                                idEstadoNew = 2;//Autorizado
                            else
                                idEstadoNew = 3;//Rechazado

                            command.Parameters.AddWithValue("@id_estado", idEstadoNew);
                            command.Parameters.AddWithValue("@id_user_aprobo",this.UsuarioLogeado.Id);
                            command.Parameters.AddWithValue("@id_solicitud_aprobacion", row.id);
                            command.Parameters.AddWithValue("@comentario", frm.txtCommentsAprobador.Text);
                            command.ExecuteNonQuery();


                            //transaccion en kardex de las lineas de orden de compra
                            if (idEstadoNew == 2)
                            {
                                command.CommandText = "dbo.sp_set_insert_lineas_orden_compra_for_kardex";
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.Clear();
                                command.Parameters.AddWithValue("@id_orden_compra_h", row.id_ordenH);
                                command.Parameters.AddWithValue("@user_id", this.UsuarioLogeado.Id);
                                command.ExecuteNonQuery();
                            }                            

                            transaction.Commit();
                            IsCommit = true;
                        }
                        catch (Exception ex)
                        {
                            // Attempt to roll back the transaction.
                            try
                            {
                                transaction.Rollback();
                                CajaDialogo.Error(ex.Message);
                            }
                            catch (Exception ex2)
                            {
                                CajaDialogo.Error(ex2.Message);
                            }
                        }
                    }//Using Connection for Transaction

                    //cambio de estado en el grid
                    if(IsCommit)
                    {
                        row.id_estado = idEstadoNew;
                        CM_OrdenCompra_EstadosAprobacion EstadoActual = new CM_OrdenCompra_EstadosAprobacion();
                        if (EstadoActual.RecuperarRegistro(idEstadoNew))
                        {
                            row.EstadoNombre = EstadoActual.descripcion;
                        }
                    }

                }
            }
            else
            {
                CajaDialogo.Error("Ha ocurrido un error, no se pudo recuperar el objeto Orden de Compra H!");
            }
        }

        private void cmdActualizar_Click(object sender, EventArgs e)
        {
            LoadPendientes(this.UsuarioLogeado.Id);
        }

        private void reposCmdVistaOrden_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
