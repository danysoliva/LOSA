using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LOSA.Clases;
using ACS.Classes;
using System.Data.SqlClient;

namespace LOSA.Calidad
{
    public partial class frmNoConfirmidadMP : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        private int id_ingreso, id_tipo_ingreso, numero_transaccion, id_no_conformidad, Id_Boleta;
        private string lote;
        private int Tipo_Operacion;
        NoConformidad Document;
        UserLogin UsuarioLogueado;

        public DataTable dt;

        public frmNoConfirmidadMP(int PId_ingreso, string pLote, UserLogin pUSerLog, int pnum_transaccion)
        {
            InitializeComponent();
            UsuarioLogueado = pUSerLog;
            Id_ingreso = PId_ingreso;
            Lote = pLote;
            numero_transaccion = pnum_transaccion;

            Document = new NoConformidad(Id_ingreso, Lote, numero_transaccion);
            Inizalidar();
        }

        public void Inizalidar()
        {
            txtUser.Text = UsuarioLogueado.NombreUser;
            dt_fecha.DateTime = Document.Fecha_documento;
            txtAcciones.Text = Document.acciones;
            txtCorrelativo.Text = Document.No_correlativo.ToString();
            txtDescripcion.Text = Document.Motivo;
            txtkg.Text = Document.Cantidad_kg.ToString();
            txtsacos.Text = Document.Cantidad_sacos.ToString();
            txtplaca.Text = Document.Placa;
            txtoc.Text = Document.Oc.ToString();
            txttrasportista.Text = Document.Trasportistas;
            txtTransporte.Text = Document.Trasporte;
            txt_proveedor.Text = Document.Proveedor;
            txt_mp.Text = Document.MaterialMp;
            txtingreso.Text = Document.Numero_referencia.ToString();
            id_tipo_ingreso = Document.Id_TipoIngreso;
            id_no_conformidad = Document.ID;
            Tipo_Operacion = Document.Id_Tipo_OP;
            txtLote.Text = Lote;
            txtCardcodeProv.Text = Document.Cardcode;
            Id_Boleta = Document.Id_Boleta;
            if (Tipo_Operacion == 1) //Insert
            {
                switch (id_tipo_ingreso)
                {
                    case 1: //Tarimas
                        btnSelectTarimas.Visible = true;
                        break;

                    case 2: //Granel
                        btnSelectTarimas.Visible = false;

                        break;

                    case 4: //Tanques Externos
                        btnSelectTarimas.Visible = false;

                        break;

                    default:
                        btnSelectTarimas.Visible = false;

                        break;
                }
            }
            else //Update
            {
                switch (id_tipo_ingreso)
                {
                    case 1: //Tarimas
                        btnSelectTarimas.Visible = true;
                        break;

                    case 2: //Granel
                        btnSelectTarimas.Visible = false;

                        break;

                    case 4: //Tanques Externos
                        btnSelectTarimas.Visible = false;

                        break;

                    default:
                        btnSelectTarimas.Visible = false;

                        break;
                }
            }

        }
        public int Id_ingreso { get => id_ingreso; set => id_ingreso = value; }
        public string Lote { get => lote; set => lote = value; }

        private void btnSelectTarimas_Click(object sender, EventArgs e)
        {

        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDescripcion_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "Escribe el motivo...")
            {
                txtDescripcion.SelectAll();
            }
        }

        private void txtAcciones_Click(object sender, EventArgs e)
        {
            if (txtAcciones.Text == "Escribe la accion correctiva...")
            {
                txtAcciones.SelectAll();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DialogResult r = CajaDialogo.Pregunta("Desea Guardar los cambios?");
            if (r != DialogResult.Yes)
                return;

            if (Convert.ToInt32(txtsacos.EditValue) == 0)
            {
                CajaDialogo.Error("No puede dejar el Campo: Cantidad de KG en 0");
                return;
            }

            if (Convert.ToInt32(txtkg.EditValue) == 0)
            {
                CajaDialogo.Error("No puede dejar el Campo: Cantidad de Sacos en 0");
                return;
            }

            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                CajaDialogo.Error("No puede dejar el Campo: Causa de No Conformidad Vacio");
                return;
            }

            if (string.IsNullOrEmpty(txtAcciones.Text))
            {
                CajaDialogo.Error("No puede dejar el Campo: Acciones Correctivas Vacio");
                return;
            }
            bool Guardar = false;
            if (id_tipo_ingreso == 1) //Son Tarimas
            {
                SqlTransaction transaction = null;

                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                

                try
                {
                    conn.Open();
                    transaction = conn.BeginTransaction("Transaction Order");

                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "[sp_calidad_no_conformidad_insert_update]";
                    cmd.Connection = conn;
                    cmd.Transaction = transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@num_transaccion", numero_transaccion);
                    cmd.Parameters.AddWithValue("@lote", txtLote.Text);
                    cmd.Parameters.AddWithValue("@fecha_registro", dt_fecha.EditValue);
                    cmd.Parameters.AddWithValue("@card_code", txtCardcodeProv.Text);
                    cmd.Parameters.AddWithValue("@card_name", txt_proveedor.Text);
                    cmd.Parameters.AddWithValue("@id_boleta", Id_Boleta);
                    cmd.Parameters.AddWithValue("@doc_num", txtoc.Text);
                    cmd.Parameters.AddWithValue("@causa", txtDescripcion.Text);
                    cmd.Parameters.AddWithValue("@accion_correctiva", txtAcciones.Text);
                    cmd.Parameters.AddWithValue("@id_usuario", UsuarioLogueado.Id);
                    cmd.Parameters.AddWithValue("@id_sig", txtCorrelativo.Text);


                    int id_header = Convert.ToInt32(cmd.ExecuteScalar());

                    //foreach (dsEstudiantes.detalle_telefonosRow row in dsEstudiantes1.detalle_telefonos.Rows)
                    //{
                    //    cmd.Parameters.Clear();
                    //    cmd.CommandText = "sp_calidad_no_conformidad_detalle";
                    //    cmd.Connection = conn;
                    //    cmd.Transaction = transaction;
                    //    cmd.CommandType = CommandType.StoredProcedure;
                    //    cmd.Parameters.AddWithValue("", id_header);
                    //    cmd.ExecuteNonQuery();
                    //}

                    transaction.Commit();
                    Guardar = true;



                }
                catch (Exception ec)
                {
                    transaction.Rollback();
                    CajaDialogo.Error(ec.Message);
                    Guardar = false;
                }
            }
            else
            {

            }

            

            if (Guardar)
            {
                CajaDialogo.Information("Guardado con Exito!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}