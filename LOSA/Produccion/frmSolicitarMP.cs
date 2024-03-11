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
using LOSA.Clases;
using System.Data.SqlClient;

namespace LOSA.Produccion
{
    public partial class frmSolicitarMP : DevExpress.XtraEditors.XtraForm
    {

        public int id_mp;
        public string mpdes;
        public string itemcode;
        public decimal cant_pendiente, tolerancia10porciento, cant_solicitado;
        UserLogin UsuarioLogeado;
        int id_requisa;
        int id_requisa_manual;
        private bool existe_mp;
        private bool mp_nueva_en_requisa;
        DataOperations dp = new DataOperations();
        public frmSolicitarMP(int Pid, UserLogin Puser, int pid_req_manual)
        {
            InitializeComponent();
            id_requisa = Pid;
            id_requisa_manual = pid_req_manual;
            UsuarioLogeado = Puser;
        }

        private void LimpiarVariables()
        {
            mpdes = "";
            itemcode = "";
            id_mp = 0;
            txtMP.Text = "";
        }

        private void bn_Mp_Click(object sender, EventArgs e)
        {
            frm_seleccionarMPInorder frm = new frm_seleccionarMPInorder(id_requisa);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                mpdes = frm.descripcion;
                itemcode = frm.itemcode;
                id_mp = frm.id_mp;
                txtMP.Text = mpdes;
            }

            bool Proceder = false;
            //Se debe Validar si la MP de la Requisa Original ya fue entregada para Proceder

            try
            {
                if (id_mp == 1101 || id_mp == 1110)
                {
                    //En la requisa original no habra MP Reproceso!
                    Proceder = true;
                }
                else
                {
                    string sql = "sp_get_mp_pendiente_por_id_requisa_y_mp";
                    SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_requisa", id_requisa);
                    cmd.Parameters.AddWithValue("@id_mp", id_mp);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        cant_pendiente = dr.GetDecimal(0);
                        cant_solicitado = dr.GetDecimal(1);
                    }
                    dr.Close();

                    tolerancia10porciento = cant_solicitado * 5 / 100; //Sacar el 5%

                    if (cant_pendiente < tolerancia10porciento)
                    {
                        //Todo bien en el Porcentaje de Tolerencia!
                        Proceder = true;
                    }
                    else
                    {
                        Proceder = false;
                    }
                }

                if (Proceder == false)
                {
                    CajaDialogo.Error("No se a completado la entrega de la MP: " + itemcode + "-" + mpdes + " de la Requisa Origen: " + id_requisa);
                    LimpiarVariables();
                    return;
                }

                //Vamos a Validar la Requisa Manual, si existe la MP
                
                string query = "sp_get_bool_validar_mp_requisa_manual";
                SqlConnection connection = new SqlConnection(dp.ConnectionStringLOSA);
                connection.Open();
                SqlCommand command= new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id_requisa_manual", id_requisa_manual);
                command.Parameters.AddWithValue("@id_mp", id_mp);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    existe_mp = reader.GetBoolean(0);
                }

                if (existe_mp)
                {
                    string sql2 = "sp_get_mp_pendiente_por_id_requisa_y_mp";
                    SqlConnection conn2 = new SqlConnection(dp.ConnectionStringLOSA);
                    conn2.Open();
                    SqlCommand cmd2 = new SqlCommand(sql2, conn2);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@id_requisa", id_requisa_manual);
                    cmd2.Parameters.AddWithValue("@id_mp", id_mp);
                    SqlDataReader dr2 = cmd2.ExecuteReader();
                    if (dr2.Read())
                    {
                        cant_pendiente = dr2.GetDecimal(0);
                        cant_solicitado = dr2.GetDecimal(1);
                    }
                    dr2.Close();

                    tolerancia10porciento = cant_solicitado * 5 / 100; //Sacar el 5%

                    if (cant_pendiente < tolerancia10porciento)
                        Proceder = true; //Todo bien en el Porcentaje de Tolerencia!
                    else
                        Proceder = false;

                    if (Proceder == false)
                    {
                        CajaDialogo.Error("No se a completado la entrega de la MP: " + itemcode + "-" + mpdes + " de la Requisa Adicional: " + id_requisa_manual);
                        LimpiarVariables();
                    }
                }
                else
                {
                    //No existe la MP en Requisa Manual, hay que crear el detalle
                    mp_nueva_en_requisa = true;
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

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMP.Text == "")
                {
                    CajaDialogo.Error("Debe de seleccionar una materia prima para hacer esta requisa.");
                    return;
                }
                if (txt_kg.Text == "0.00")
                {
                    CajaDialogo.Error("Debe de agregar una cantidad de kg para hacer esta requisa.");
                    return;
                }
                if (txt_kg.Text == "")
                {
                    CajaDialogo.Error("Debe de agregar una cantidad de kg para hacer esta requisa.");
                    return;
                }

                string query = @"sp_inserd_in_requisas_manuales";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_req", id_requisa);
                cmd.Parameters.AddWithValue("@id_mp", id_mp);
                cmd.Parameters.AddWithValue("@itemcode", itemcode);
                cmd.Parameters.AddWithValue("@kg", txt_kg.Text);
                cmd.Parameters.AddWithValue("@id_usuario", UsuarioLogeado.Id);
                cmd.ExecuteNonQuery();

                CajaDialogo.Information("Operacion Realizada con Exito");
                this.DialogResult = DialogResult.OK;
                this.Close();
                
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
               
            }
        }
    }
}