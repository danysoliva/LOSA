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
using System.Data;
using LOSA.Presupuesto;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.Presupuesto
{
    public partial class frmGeneracionDetallePresupuesto : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado = new UserLogin();
        int idPresupuesto;

        List<int> ListDepartament = new List<int>();

        public frmGeneracionDetallePresupuesto(UserLogin pUserLog, int pIdpresupuesto, List<int> pList)
        {
            InitializeComponent();
            idPresupuesto = pIdpresupuesto;
            UsuarioLogeado = pUserLog;
            ListDepartament = pList;
            LoadData();

            foreach (int idDepartament in ListDepartament)
            {
                foreach (dsPresupuesto.generacion_automaticaRow item in dsPresupuesto1.generacion_automatica)
                {
                    if (idDepartament == item.id_departamento)
                    {
                        item.selected = false;
                    }
                }
            }
            
        }

        private void LoadData()
        {
            try
            {
                string query = @"sp_presupuesto_generar_detalle_auto";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@userId", UsuarioLogeado.Id);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsPresupuesto1.generacion_automatica.Clear();
                adat.Fill(dsPresupuesto1.generacion_automatica);
                conn.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnCloseHeader_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddHeader_Click(object sender, EventArgs e)
        {
            foreach (int lsita in ListDepartament)
            {
                foreach (dsPresupuesto.generacion_automaticaRow row in dsPresupuesto1.generacion_automatica)
                {
                    if (row.selected)
                    {
                        if (lsita == row.id_departamento)
                        {
                            CajaDialogo.Error("Ya se creo el Detalle de este Departamento: " + row.descripcion_departamento);
                            return;
                        }
                    }
                    
                }
            }


            DialogResult r = CajaDialogo.Pregunta("Dese crear los Detalles de Presupuesto de esta Lista?");
            if (r != System.Windows.Forms.DialogResult.Yes)
                return;

            bool Guardar = false;
            foreach (dsPresupuesto.generacion_automaticaRow item in dsPresupuesto1.generacion_automatica.Rows)
            {
                if (item.selected == true)
                {
                    try
                    {
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("sp_presupuesto_detalle_insert", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_presupuesto", idPresupuesto);
                        cmd.Parameters.AddWithValue("@id_departamento", item.id_departamento);
                        cmd.Parameters.AddWithValue("@user_id", UsuarioLogeado.Id);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        Guardar = true;
                    }
                    catch (Exception er)
                    {
                        Guardar = false;
                        CajaDialogo.Error(er.Message);
                    }
                }
                
            }

            if (Guardar)
            {
                CajaDialogo.Information("Se Generaron los Departamento para el Presupuesto!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

            
        }
    }
}