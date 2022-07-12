using ACS.Classes;
using Core.Clases.Herramientas;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using LOSA.Calidad.Model;
using LOSA.Clases;
using LOSA.RecepcionMP;
using System;
using System.Collections;
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
    public partial class frmcalidad : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado;

       
        
        public frmcalidad(UserLogin Puser)
        {
            InitializeComponent();
            UsuarioLogeado = Puser;
            Load_Info();   
        }
      
        public void Load_Info()
        {
            string query = @"ps_load_ingresos_from_tarimas_v2";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsRecepcionMPx.IngresosMP.Clear();
                da.Fill(dsRecepcionMPx.IngresosMP);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error("Error al cargar la informacion: " + ex.Message);
            }
        }
        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        SqlTransaction transaccion;
        private void btnver_Click(object sender, EventArgs e)
        {
            try
            {

                var gridview = (GridView)grd_ingreso.FocusedView;
                var row = (dsRecepcionMPx.IngresosMPRow)gridview.GetFocusedDataRow();

                DataOperations dp = new DataOperations();
                Lote_Ingreso_Conf_Calidad item_conf = new Lote_Ingreso_Conf_Calidad();
                
                string sp = "dbo.sp_get_conf_calidad";
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA);

                SqlCommand cmd = new SqlCommand(sp,cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id_ingreso", SqlDbType.Int).Value=row.Ningreso;
                cmd.Parameters.Add("@itemcode", SqlDbType.VarChar).Value=row.itemcode;
                cmd.Parameters.Add("@lote", SqlDbType.VarChar).Value=row.lote;

                cnx.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                item_conf = null;
                while (dr.Read())
                {
                    
                    item_conf = new Lote_Ingreso_Conf_Calidad{
                                                                    ID = dr.GetInt32(0),
                                                                    NumeroIngreso = dr.GetInt32(1),
                                                                    ItemCode = dr.GetString(2),
                                                                    ID_MP = dr.GetInt32(3),
                                                                    Lote = dr.GetString(4),

                                                                };
                }

                cnx.Close();


                if (item_conf != null)
                {
                   if (item_conf.Lote!=row.lote)
                    {
                        xfrmWizardConfCalidad frm2 = new xfrmWizardConfCalidad(item_conf.ID,UsuarioLogeado);

                        if (frm2.ShowDialog()== DialogResult.OK)
                        {
                                cnx.Open();
                                transaccion = cnx.BeginTransaction();

                            SqlCommand cmd2 = new SqlCommand("dbo.sp_copiar_configuracion_lote_mp_calidad", transaccion.Connection);
                            cmd2.CommandType = CommandType.StoredProcedure;
                            cmd2.Transaction = transaccion;

                            cmd2.Parameters.Add("@id_ingreso_conf", SqlDbType.Int).Value = item_conf.ID;
                            cmd2.Parameters.Add("@id_ingreso_nuevo", SqlDbType.Int).Value = row.id;
                            cmd2.Parameters.Add("@id_user", SqlDbType.Int).Value = UsuarioLogeado.Id;
                            cmd2.Parameters.Add("@fecha", SqlDbType.DateTime).Value = DateTime.Now;

                            cmd2.ExecuteNonQuery();

                            transaccion.Commit();
                            cnx.Close();
                        }
                        else
                        {
                            rdEstadoTransporte frm = new rdEstadoTransporte(row.id, UsuarioLogeado);
                            if (this.MdiParent != null)
                                frm.MdiParent = this.MdiParent;
                            frm.Show();
                        }
                    }
                    else
                    {
                        rdEstadoTransporte frm = new rdEstadoTransporte(row.id, UsuarioLogeado);
                        if (this.MdiParent != null)
                            frm.MdiParent = this.MdiParent;
                        frm.Show();
                    }

                }
                else
                {
                    rdEstadoTransporte frm = new rdEstadoTransporte(row.id, UsuarioLogeado);
                    if (this.MdiParent != null)
                        frm.MdiParent = this.MdiParent;
                    frm.Show();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                transaccion.Rollback();
            }
        }
    }
}