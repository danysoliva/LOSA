using ACS.Classes;
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

namespace LOSA.TransaccionesMP
{
    public partial class frmOrdenFabricacionDetalle : Form
    {
        UserLogin UsuarioLogeado;
        int DocEntry;
        string comentario;
        public frmOrdenFabricacionDetalle(int pIdOrdenFabricacion, UserLogin puser, string Comment)
        {
            InitializeComponent();
            UsuarioLogeado = puser;
            DocEntry = pIdOrdenFabricacion;
            comentario = Comment;
            LoadData(pIdOrdenFabricacion);
        }

        private void LoadData(int pIdOrdenFabricacion)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_detalle_orden_fabricacion", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Docentry", pIdOrdenFabricacion);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsTransaccionesMP1.orden_fabricacion_d.Clear();
                adat.Fill(dsTransaccionesMP1.orden_fabricacion_d);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
           
            DialogResult r = CajaDialogo.Pregunta("Confirme para generar la requisición?");
            if (r != DialogResult.Yes)
                return;

            DataOperations dp = new DataOperations();
            //using (SqlConnection connection = new SqlConnection(dp.ConnectionStringLOSA))
            //{
            SqlConnection connection = new SqlConnection(dp.ConnectionStringLOSA);
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
                //Insert encabezado
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_insert_requisicion_h_mp";
                command.Parameters.AddWithValue("@id_usuario", UsuarioLogeado.Id);
                command.Parameters.AddWithValue("@DocEntry", DocEntry);
                command.Parameters.AddWithValue("@comentario", comentario);
                int IdEncabezado = Convert.ToInt32(command.ExecuteScalar());

                //Insert detalle.
                foreach (dsTransaccionesMP.orden_fabricacion_dRow row in dsTransaccionesMP1.orden_fabricacion_d.Rows)
                {
                    MateriaPrima mp = new MateriaPrima();
                    if (mp.RecuperarRegistroFromCode(row.Codigo))
                    {
                        command.Parameters.Clear();
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "sp_insert_requiscion_detalle";
                        command.Parameters.AddWithValue("@id_requisicion", IdEncabezado);
                        command.Parameters.AddWithValue("@idmp", mp.IdMP_ACS);
                        command.Parameters.AddWithValue("@code", row.Codigo);
                        command.Parameters.AddWithValue("@cant", row.Planificado);
                        command.Parameters.AddWithValue("@id_unidad", 2);//KG
                        command.ExecuteNonQuery();
                    }
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
                    CajaDialogo.Error(ex.Message + " Mensaje 2: " + ex2.Message);
                }
            }
            //}












        }
    }
}
