using ACS.Classes;
using DevExpress.XtraCharts.Native;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Calidad.LoteConfConsumo;
using LOSA.Clases;
using LOSA.Mantenimientos;
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

namespace LOSA.Trazabilidad
{
    public partial class frmCRUD_PlantasPRV : DevExpress.XtraEditors.XtraForm
    {
        string ProveedorN;
        string CardCode;
        int IdUser;
        int IdPlanta;

        public enum TipoAccion
        {
            Insert = 1,
            Update = 2
        }

        TipoAccion TipoAccionActual;
        Proveedor vProveedor;
        PlantaPrvTrz vPlanta;

        public frmCRUD_PlantasPRV(string pcardCode, int pIdPlanta, TipoAccion ptipoAccion, int pIduser)
        {
            InitializeComponent();
            TipoAccionActual = ptipoAccion;
            IdPlanta = pIdPlanta;
            CardCode = pcardCode;
            IdUser = pIduser;
            vProveedor = new Proveedor();
            vPlanta = new PlantaPrvTrz();
            CargarTiposGMO();
            CargarAprobacionesASC();

            switch (TipoAccionActual)
            {
                case TipoAccion.Insert:
                    if (vProveedor.RecuperarRegistroWithRTN(pcardCode))
                    {
                        txtProveedor.Text = vProveedor.Nombre;
                        txtNombre.Focus();
                    }
                    break;
                case TipoAccion.Update:
                    if (vProveedor.RecuperarRegistroWithRTN(pcardCode))
                    {
                        txtProveedor.Text = vProveedor.Nombre;
                        if (vPlanta.RecuperarRegistro(IdPlanta))
                        {
                            txtNombre.Text = vPlanta.Nombre;
                            txtDireccion.Text = vPlanta.Direccion;
                            txtComentario.Text = vPlanta.Comentario;
                            LoadDetalleMPs(vPlanta.Id);
                        }
                    }
                    break;
            }
        }

        private void CargarAprobacionesASC()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.sp_get_aprobaciones_asc_list", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@id_planta", );
                dsMantoTrazabilidad1.aprobacion_asc.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMantoTrazabilidad1.aprobacion_asc);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void CargarTiposGMO()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.sp_list_tipos_gmo_para_plantas_proveedores_mp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@id_planta", );
                dsMantoTrazabilidad1.tipos_gmo.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMantoTrazabilidad1.tipos_gmo);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadDetalleMPs(int pIdPlanta)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.sp_list_detalle_mps_de_planta_proveedor", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_planta", pIdPlanta);
                dsMantoTrazabilidad1.planta_detalle_mp.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMantoTrazabilidad1.planta_detalle_mp);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                CajaDialogo.Error("No se permite dejar el nombre vacio!");
                return;
            }

            switch (TipoAccionActual)
            {
                case TipoAccion.Insert:
                    if (vProveedor.RecuperarRegistroWithRTN(CardCode))
                    {
                        vPlanta.Nombre = txtNombre.Text;
                        vPlanta.Direccion = txtDireccion.Text;
                        vPlanta.Comentario = txtComentario.Text;
                        vPlanta.Id_user = IdUser;
                        //if (vPlanta.GuardarRegistro(CardCode))
                        //{
                        //    this.DialogResult = DialogResult.OK;
                        //    this.Close();
                        //}

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
                                command.CommandText = "sp_set_insert_planta_prv_trz";
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.AddWithValue("@nombre", vPlanta.Nombre);
                                command.Parameters.AddWithValue("@direccion", vPlanta.Direccion);
                                command.Parameters.AddWithValue("@comentario", vPlanta.Comentario);
                                command.Parameters.AddWithValue("@id_user", vPlanta.Id_user);
                                command.Parameters.AddWithValue("@cardcode", CardCode);
                                int id_planta = Convert.ToInt32(command.ExecuteScalar());

                                foreach (dsMantoTrazabilidad.planta_detalle_mpRow row in dsMantoTrazabilidad1.planta_detalle_mp)
                                {
                                    command.Parameters.Clear();
                                    command.CommandText = "dbo.sp_insert_detalle_mp_planta";
                                    command.Parameters.AddWithValue("@id_user", this.IdUser);
                                    command.Parameters.AddWithValue("@id_mp", row.id_mp);
                                    command.Parameters.AddWithValue("@id_tipo_gmo", row.tipo_gmo_id);
                                    command.Parameters.AddWithValue("@id_planta", id_planta);
                                    command.Parameters.AddWithValue("@aprobado_asc", row.aprobado_asc);
                                    command.ExecuteNonQuery();
                                }

                                // Attempt to commit the transaction.
                                transaction.Commit();
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }
                            catch (Exception ex)
                            {
                                // Attempt to roll back the transaction.
                                try
                                {
                                    transaction.Rollback();
                                }
                                catch (Exception ex2)
                                {
                                    CajaDialogo.Error(ex2.Message);
                                }
                            }
                        }
                    }
                    break;
                case TipoAccion.Update:
                    if (vProveedor.RecuperarRegistroWithRTN(CardCode))
                    {
                        vPlanta.Nombre = txtNombre.Text;
                        vPlanta.Direccion = txtDireccion.Text;
                        vPlanta.Comentario = txtComentario.Text;
                        vPlanta.Id_user = IdUser;
                        //if (vPlanta.UpdateRegistro(IdPlanta))
                        //{
                        //    this.DialogResult = DialogResult.OK;
                        //    this.Close();
                        //}

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
                                command.CommandText = "sp_set_update_planta_prv_trz";
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.AddWithValue("@nombre", vPlanta.Nombre);
                                command.Parameters.AddWithValue("@direccion", vPlanta.Direccion);
                                command.Parameters.AddWithValue("@comentario", vPlanta.Comentario);
                                command.Parameters.AddWithValue("@id", vPlanta.Id);
                                command.ExecuteNonQuery();

                                foreach (dsMantoTrazabilidad.planta_detalle_mpRow row in dsMantoTrazabilidad1.planta_detalle_mp)
                                {
                                    command.Parameters.Clear();
                                    command.CommandText = "dbo.sp_update_or_insert_plantas_proveedor_mp";
                                    command.Parameters.AddWithValue("@id", row.id);
                                    command.Parameters.AddWithValue("@id_user", this.IdUser);
                                    command.Parameters.AddWithValue("@id_mp", row.id_mp);
                                    command.Parameters.AddWithValue("@id_tipo_gmo", row.tipo_gmo_id);
                                    command.Parameters.AddWithValue("@id_planta", vPlanta.Id);
                                    command.Parameters.AddWithValue("@aprobado_asc", row.aprobado_asc);
                                    command.ExecuteNonQuery();
                                }

                                // Attempt to commit the transaction.
                                transaction.Commit();
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }
                            catch (Exception ex)
                            {
                                // Attempt to roll back the transaction.
                                try
                                {
                                    transaction.Rollback();
                                }
                                catch (Exception ex2)
                                {
                                    CajaDialogo.Error(ex2.Message);
                                }
                            }
                        }
                    }
                    break;
            }
        }

        private void txtComentario_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void frmCRUD_PlantasPRV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void cmdEliminar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Eliminar row del grid
            DialogResult r = MessageBox.Show("¿Desea Eliminar ésta linea?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r != DialogResult.Yes)
                return;

            var gridView1 = (GridView)gridControl1.FocusedView;
            var row = (dsMantoTrazabilidad.planta_detalle_mpRow)gridView1.GetFocusedDataRow();

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_update_materia_prima_planta_proveedor", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_planta_id_mp", row.id);
                cmd.ExecuteNonQuery();

                con.Close();
                gridView1.DeleteRow(gridView1.FocusedRowHandle);
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdAgregarMP_Click(object sender, EventArgs e)
        {
            frmSearchMP frm = new frmSearchMP(frmSearchMP.TipoBusqueda.MateriaPrima);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                switch (TipoAccionActual)
                {
                    case TipoAccion.Insert:
                        dsMantoTrazabilidad.planta_detalle_mpRow row1 = dsMantoTrazabilidad1.planta_detalle_mp.Newplanta_detalle_mpRow ();
                        row1.id_mp = frm.ItemSeleccionado.id;
                        MateriaPrima mp1 = new MateriaPrima();
                        if (mp1.RecuperarRegistroFromID_MP(row1.id_mp))
                        {
                            row1.itemcode = mp1.CodeMP_SAP;
                            row1.descripcion = mp1.NameComercial;
                            row1.aprobado_asc = 0;
                            try
                            {
                                row1.tipo_gmo_id = 3;
                                row1.id = 0;
                            }
                            catch { }
                        }
                        dsMantoTrazabilidad1.planta_detalle_mp.Addplanta_detalle_mpRow (row1);
                        dsMantoTrazabilidad1.AcceptChanges();
                        break;
                    case TipoAccion.Update:
                        //Validaremos si el registro ya existe en el grid
                        bool existe = false;
                        foreach(dsMantoTrazabilidad.planta_detalle_mpRow row in dsMantoTrazabilidad1.planta_detalle_mp)
                        {
                            if (row.id_mp == frm.ItemSeleccionado.id)
                            {
                                existe = true;
                                break;
                            }
                        }

                        if (!existe)
                        {
                            dsMantoTrazabilidad.planta_detalle_mpRow row2 = dsMantoTrazabilidad1.planta_detalle_mp.Newplanta_detalle_mpRow();
                            row2.id_mp = frm.ItemSeleccionado.id;
                            MateriaPrima mp2 = new MateriaPrima();
                            if (mp2.RecuperarRegistroFromID_MP(row2.id_mp))
                            {
                                row2.itemcode = mp2.CodeMP_SAP;
                                row2.descripcion = mp2.NameComercial;
                                row2.aprobado_asc = 0;
                                try
                                {
                                    row2.tipo_gmo_id = 3;
                                    row2.id = 0;
                                }
                                catch { }
                            }
                            dsMantoTrazabilidad1.planta_detalle_mp.Addplanta_detalle_mpRow(row2);
                            dsMantoTrazabilidad1.AcceptChanges();
                        }
                        break;
                    default:

                        break;
                }
            }
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

        }
    }
}