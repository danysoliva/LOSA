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
using ACS.Classes;
using System.Data.SqlClient;

namespace LOSA.MigracionACS.RRHH.Liquidaciones
{
    public partial class frmConfDeduccionesOP : DevExpress.XtraEditors.XtraForm
    {
        int Id;
        string Descripcion;
        DataOperations dp = new DataOperations();
        public enum tipotrans
        {
            insert = 1,
            update = 2
        }
        tipotrans vtipotrans;

        public frmConfDeduccionesOP()
        {
            InitializeComponent();
            vtipotrans = tipotrans.insert;
            lblDeduccion.Text = "Crear Deduccion";
            tsAtributo.Visible = false;
        }

        public frmConfDeduccionesOP(int pid, string pdescripcion)
        {
            InitializeComponent();
            vtipotrans = tipotrans.update;
            lblDeduccion.Text = "Editar Deduccion";
            Id = pid;
            Descripcion = pdescripcion;
            txtDescripcion.Text = Descripcion;
            tsAtributo.Visible = true;
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                CajaDialogo.Error("La descripcion se encuentra Vacia!");
                return;
            }

            switch (vtipotrans)
            {
                case tipotrans.insert:

                    string query = @"[sp_insert_RRHH_atributo]";
                    try
                    {
                        DataOperations dp = new DataOperations();
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                    }
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                    CajaDialogo.Information("Atributo Creado!");
                    break;
                case tipotrans.update:

                    string query2 = @"[sp_update_RRHH_atributo]"; //Aqui va el SP pero no lo e echo!
                    try
                    {
                        SqlConnection conn2 = new SqlConnection(dp.ConnectionStringCostos);
                        conn2.Open();
                        SqlCommand cmd2 = new SqlCommand(query2, conn2);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.AddWithValue("@id", Id);
                        cmd2.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
                        cmd2.Parameters.AddWithValue("@enable", tsAtributo.IsOn);
                        cmd2.ExecuteNonQuery();
                        conn2.Close();   
                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                    }
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                    CajaDialogo.Information("Atributo Actualizado!");
                    break;

                default:
                    CajaDialogo.Error("No se definio una operacion de transaccion (INSERT-UPDATE) para este formulario");
                    break;

                   
            }
        }
    }
}