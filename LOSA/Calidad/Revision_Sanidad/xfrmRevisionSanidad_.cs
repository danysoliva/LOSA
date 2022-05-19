using ACS.Classes;
using DevExpress.XtraEditors;
using LOSA.Calidad.Revision_Sanidad.Model;
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

namespace LOSA.Calidad.Revision_Sanidad
{
    public partial class xfrmRevisionSanidad_ : DevExpress.XtraEditors.XtraUserControl
    {
        List<RevisionSanidadResumen> revisionSanidad_Results = new List<RevisionSanidadResumen>();
        List<InspeccionPresentacionConductor> inspeccionPresentacionConductor_results = new List<InspeccionPresentacionConductor>();

        public xfrmStepRevisionSanidad mainNavigate = new xfrmStepRevisionSanidad();


        public VehiculoInfo vehiculo = new VehiculoInfo();
        public List<InspeccionSeguridad_Results> result_inspeccionSeguridad = new List<InspeccionSeguridad_Results>();


        public int id_h;

        private static xfrmRevisionSanidad_ _instance = null;
        public static xfrmRevisionSanidad_ Instance
        {

            get
            {
                if (_instance == null)
                    _instance = new xfrmRevisionSanidad_();

                return _instance;
            }
        }




        public xfrmRevisionSanidad_(VehiculoInfo vehiculo_p, List<InspeccionSeguridad_Results> inspeccionSeguridad)
        {
            InitializeComponent();
            LoadTemplate();
            LoadInspeccionConductorTemplate();
            vehiculo = vehiculo_p;
            result_inspeccionSeguridad = inspeccionSeguridad;
        }


        public xfrmRevisionSanidad_()
        {
            InitializeComponent();
            LoadTemplate();
            LoadInspeccionConductorTemplate();
        }

        private void LoadTemplate()
        {
            try
            {
                DataOperations dp = new DataOperations();
                revisionSanidad_Results = new List<RevisionSanidadResumen>();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA))
                {
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("[dbo].[sp_load_calidad_revision_sanidad_template]", cnx);
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        revisionSanidad_Results.Add(new RevisionSanidadResumen
                        {
                           RevisionSanidadTemplate_ID = dr.GetInt32(0),
                            RevisionSanidadTemplate_Name = dr.GetString(1),
                        });
                    }

                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void ts1_Toggled(object sender, EventArgs e)
        {
            try
            {
                revisionSanidad_Results.Where(S => S.RevisionSanidadTemplate_ID == Convert.ToInt32(ts1.Properties.Tag))
                             .Select(S => { S.Result = (bool)ts1.EditValue; return S; }).ToList();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            try
            {
                revisionSanidad_Results.Where(S => S.RevisionSanidadTemplate_ID == Convert.ToInt32(ts2.Properties.Tag))
                             .Select(S => { S.Result = (bool)ts2.EditValue; return S; }).ToList();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void ts3_Toggled(object sender, EventArgs e)
        {
            try
            {
                revisionSanidad_Results.Where(S => S.RevisionSanidadTemplate_ID == Convert.ToInt32(ts3.Properties.Tag))
                             .Select(S => { S.Result = (bool)ts3.EditValue; return S; }).ToList();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void LoadInspeccionConductorTemplate()
        {
            try
            {
                DataOperations dp = new DataOperations();
                inspeccionPresentacionConductor_results = new List<InspeccionPresentacionConductor>();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA))
                {
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("dbo.sp_load_template_inspeccion_conductor", cnx);
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        inspeccionPresentacionConductor_results.Add(new InspeccionPresentacionConductor
                        {
                           InspeccionConductorTemplateID = dr.GetInt32(0),
                            InspeccionConductorTemplateName = dr.GetString(1),
                        });
                    }

                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void ts5_Toggled(object sender, EventArgs e)
        {
            try
            {
                revisionSanidad_Results.Where(S => S.RevisionSanidadTemplate_ID == Convert.ToInt32(ts5.Properties.Tag))
                             .Select(S => { S.Result = (bool)ts5.EditValue; return S; }).ToList();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void ts6_Toggled(object sender, EventArgs e)
        {
            try
            {
                revisionSanidad_Results.Where(S => S.RevisionSanidadTemplate_ID == Convert.ToInt32(ts6.Properties.Tag))
                             .Select(S => { S.Result = (bool)ts6.EditValue; return S; }).ToList();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void ts4_Toggled(object sender, EventArgs e)
        {
            try
            {
                revisionSanidad_Results.Where(S => S.RevisionSanidadTemplate_ID == Convert.ToInt32(ts4.Properties.Tag))
                             .Select(S => { S.Result = (bool)ts4.EditValue; return S; }).ToList();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void ts7_Toggled(object sender, EventArgs e)
        {
            try
            {
                revisionSanidad_Results.Where(S => S.RevisionSanidadTemplate_ID == Convert.ToInt32(ts7.Properties.Tag))
                             .Select(S => { S.Result = (bool)ts7.EditValue; return S; }).ToList();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void ts8_Toggled(object sender, EventArgs e)
        {
            try
            {
                revisionSanidad_Results.Where(S => S.RevisionSanidadTemplate_ID == Convert.ToInt32(ts8.Properties.Tag))
                             .Select(S => { S.Result = (bool)ts8.EditValue; return S; }).ToList();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void ts9_Toggled(object sender, EventArgs e)
        {
            try
            {
                revisionSanidad_Results.Where(S => S.RevisionSanidadTemplate_ID == Convert.ToInt32(ts9.Properties.Tag))
                             .Select(S => { S.Result = (bool)ts9.EditValue; return S; }).ToList();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void ts10_Toggled(object sender, EventArgs e)
        {
            try
            {
                revisionSanidad_Results.Where(S => S.RevisionSanidadTemplate_ID == Convert.ToInt32(ts10.Properties.Tag))
                             .Select(S => { S.Result = (bool)ts10.EditValue; return S; }).ToList();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void tsConductor1_Toggled(object sender, EventArgs e)
        {
            try
            {
                inspeccionPresentacionConductor_results.Where(S => S.InspeccionConductorTemplateID == Convert.ToInt32(tsConductor1.Properties.Tag))
                             .Select(S => { S.Result = (bool)tsConductor1.EditValue; return S; }).ToList();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void tsConductor2_Toggled(object sender, EventArgs e)
        {
            try
            {
                inspeccionPresentacionConductor_results.Where(S => S.InspeccionConductorTemplateID == Convert.ToInt32(tsConductor2.Properties.Tag))
                             .Select(S => { S.Result = (bool)tsConductor2.EditValue; return S; }).ToList();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void tsConductor3_Toggled(object sender, EventArgs e)
        {
            try
            {
                inspeccionPresentacionConductor_results.Where(S => S.InspeccionConductorTemplateID == Convert.ToInt32(tsConductor3.Properties.Tag))
                             .Select(S => { S.Result = (bool)tsConductor3.EditValue; return S; }).ToList();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void tsConductor4_Toggled(object sender, EventArgs e)
        {
            try
            {
                inspeccionPresentacionConductor_results.Where(S => S.InspeccionConductorTemplateID == Convert.ToInt32(tsConductor4.Properties.Tag))
                             .Select(S => { S.Result = (bool)tsConductor4.EditValue; return S; }).ToList();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        SqlTransaction transaction;
        private void btnGuadar_Click(object sender, EventArgs e)
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA);

                DialogBoxRevision frm = new DialogBoxRevision();

                if (frm.ShowDialog()== DialogResult.OK)
                {
                    switch (id_h)
                    {
                        case 0:

                            cnx.Open();
                            transaction = cnx.BeginTransaction("SampleTransaction");

                            SqlCommand cmd = new SqlCommand("dbo.sp_insert_LOSA_calidad_revision_sanidad_vehiculo", transaction.Connection);
                            cmd.Transaction = transaction;
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("@fecha_creacion", SqlDbType.DateTime).Value = DateTime.Now;
                            cmd.Parameters.Add("@placa", SqlDbType.VarChar).Value = vehiculo.Placa;
                            cmd.Parameters.Add("@contenedor", SqlDbType.VarChar).Value = vehiculo.Contenedor;
                            cmd.Parameters.Add("@carcode", SqlDbType.VarChar).Value = vehiculo.CarCode;
                            cmd.Parameters.Add("@fecha_ingreso", SqlDbType.Date).Value = vehiculo.Fecha;
                            cmd.Parameters.Add("@conductor", SqlDbType.VarChar).Value = vehiculo.Conductor;
                            cmd.Parameters.Add("@hora", SqlDbType.Time).Value = vehiculo.Hora;
                            cmd.Parameters.Add("@tamanio_contenedor", SqlDbType.Decimal).Value = vehiculo.TemperaturaContenedor;
                            cmd.Parameters.Add("@cliente", SqlDbType.VarChar).Value = vehiculo.Cliente;
                            cmd.Parameters.Add("@proveedor_transporte", SqlDbType.VarChar).Value = vehiculo.ProveedorTransporte;
                            cmd.Parameters.Add("@sector_cliente_destino", SqlDbType.VarChar).Value = vehiculo.SectorCliente_Destino;
                            cmd.Parameters.Add("@pais_destino", SqlDbType.VarChar).Value = vehiculo.PaisDestino;
                            cmd.Parameters.Add("@id_estado", SqlDbType.Int).Value = frm.id_estado;

                            int id_inserted = Convert.ToInt32(cmd.ExecuteScalar());

                            foreach (var item in result_inspeccionSeguridad)
                            {

                                SqlCommand cmd2 = new SqlCommand("dbo.sp_insert_inspeccion_seguridad", transaction.Connection);
                                cmd2.CommandType = CommandType.StoredProcedure;
                                cmd2.Transaction = transaction;
                                cmd2.Parameters.Add("@id_h", SqlDbType.Int).Value = id_inserted;
                                cmd2.Parameters.Add("@id_inspeccion_seguridad_plantilla", SqlDbType.Int).Value = item.InspeccionSeguridadPlantillaID;
                                cmd2.Parameters.Add("@id_inspeccion_seguridad_respuesta", SqlDbType.Int).Value = item.InspeccionSeguridadRespuestaID;

                                cmd2.ExecuteNonQuery();
                            }



                            foreach (var item in inspeccionPresentacionConductor_results)
                            {

                                SqlCommand cmd3 = new SqlCommand("dbo.sp_insert_revision_sanidad_inspeccion_conductor", transaction.Connection);
                                cmd3.CommandType = CommandType.StoredProcedure;
                                cmd3.Transaction = transaction;
                                cmd3.Parameters.Add("@id_h", SqlDbType.Int).Value = id_inserted;
                                cmd3.Parameters.Add("@inspeccion_conductor_template_id", SqlDbType.Int).Value = item.InspeccionConductorTemplateID;
                                cmd3.Parameters.Add("@result", SqlDbType.Int).Value = item.Result;

                                cmd3.ExecuteNonQuery();
                            }


                            foreach (var item in revisionSanidad_Results)
                            {

                                SqlCommand cmd4 = new SqlCommand("dbo.sp_insert_calidad_revision_sanidad", transaction.Connection);
                                cmd4.CommandType = CommandType.StoredProcedure;
                                cmd4.Transaction = transaction;
                                cmd4.Parameters.Add("@id_h", SqlDbType.Int).Value = id_inserted;
                                cmd4.Parameters.Add("@id_revision_sanidad_plantilla", SqlDbType.Int).Value = item.RevisionSanidadTemplate_ID;
                                cmd4.Parameters.Add("@result", SqlDbType.Int).Value = item.Result;

                                cmd4.ExecuteNonQuery();
                            }

                            transaction.Commit();

                            cnx.Close();

                            pictureEdit1.Image = LOSA.Properties.Resources.step4;
                            CajaDialogo.Information("Datos Guardados");
                            break;

                        default:
                            cnx.Open();
                            transaction = cnx.BeginTransaction("SampleTransaction");

                            foreach (var item in revisionSanidad_Results)
                            {

                                SqlCommand cmd5 = new SqlCommand("dbo.sp_insert_calidad_revision_sanidad_posteriores", transaction.Connection);
                                cmd5.CommandType = CommandType.StoredProcedure;
                                cmd5.Transaction = transaction;
                                cmd5.Parameters.Add("@id_h", SqlDbType.Int).Value = id_h;
                                cmd5.Parameters.Add("@id_revision_sanidad_plantilla", SqlDbType.Int).Value = item.RevisionSanidadTemplate_ID;
                                cmd5.Parameters.Add("@result", SqlDbType.Int).Value = item.Result;

                                cmd5.ExecuteNonQuery();
                            }

                            SqlCommand cmd2_ = new SqlCommand("dbo.sp_update_LOSA_calidad_revision_sanidad_vehiculo", transaction.Connection);
                            cmd2_.Transaction = transaction;
                            cmd2_.CommandType = CommandType.StoredProcedure;

                            cmd2_.Parameters.Add("@fecha_creacion", SqlDbType.DateTime).Value = DateTime.Now;
                            cmd2_.Parameters.Add("@placa", SqlDbType.VarChar).Value = vehiculo.Placa;
                            cmd2_.Parameters.Add("@contenedor", SqlDbType.VarChar).Value = vehiculo.Contenedor;
                            cmd2_.Parameters.Add("@carcode", SqlDbType.VarChar).Value = vehiculo.CarCode;
                            cmd2_.Parameters.Add("@fecha_ingreso", SqlDbType.Date).Value = vehiculo.Fecha;
                            cmd2_.Parameters.Add("@conductor", SqlDbType.VarChar).Value = vehiculo.Conductor;
                            cmd2_.Parameters.Add("@hora", SqlDbType.Time).Value = vehiculo.Hora;
                            cmd2_.Parameters.Add("@tamanio_contenedor", SqlDbType.Decimal).Value = vehiculo.TemperaturaContenedor;
                            cmd2_.Parameters.Add("@cliente", SqlDbType.VarChar).Value = vehiculo.Cliente;
                            cmd2_.Parameters.Add("@proveedor_transporte", SqlDbType.VarChar).Value = vehiculo.ProveedorTransporte;
                            cmd2_.Parameters.Add("@sector_cliente_destino", SqlDbType.VarChar).Value = vehiculo.SectorCliente_Destino;
                            cmd2_.Parameters.Add("@pais_destino", SqlDbType.VarChar).Value = vehiculo.PaisDestino;
                            cmd2_.Parameters.Add("@id_estado", SqlDbType.Int).Value = frm.id_estado;
                            cmd2_.Parameters.Add("@id_h", SqlDbType.Int).Value = id_h;


                            cmd2_.ExecuteNonQuery();

                            foreach (var item in result_inspeccionSeguridad)
                            {

                                SqlCommand cmd3 = new SqlCommand("dbo.sp_update_revision_sanidad_inspeccion_seguridad", transaction.Connection);
                                cmd3.CommandType = CommandType.StoredProcedure;
                                cmd3.Transaction = transaction;
                                cmd3.Parameters.Add("@id_h", SqlDbType.Int).Value = id_h;
                                cmd3.Parameters.Add("@id_inspeccionSeguridad_Template", SqlDbType.Int).Value = item.InspeccionSeguridadPlantillaID;
                                cmd3.Parameters.Add("@id_inspeccionSeguridad_respuesta", SqlDbType.Int).Value = item.InspeccionSeguridadRespuestaID;
                                   
                                cmd3.ExecuteNonQuery();
                            }



                            foreach (var item in inspeccionPresentacionConductor_results)
                            {

                                SqlCommand cmd4 = new SqlCommand("dbo.sp_update_revision_sanidad_inspeccion_conductor", transaction.Connection);
                                cmd4.CommandType = CommandType.StoredProcedure;
                                cmd4.Transaction = transaction;
                                cmd4.Parameters.Add("@id_h", SqlDbType.Int).Value = id_h;
                                cmd4.Parameters.Add("@inspeccion_conductor_template_id", SqlDbType.Int).Value = item.InspeccionConductorTemplateID;
                                cmd4.Parameters.Add("@result", SqlDbType.Int).Value = item.Result;

                                cmd4.ExecuteNonQuery();
                            }



                            transaction.Commit();

                            cnx.Close();

                            pictureEdit1.Image = LOSA.Properties.Resources.step4;


                           
                            CajaDialogo.Information("Datos Guardados");
                            break;
                    }

                    //_instance = null;
                    //this.Controls.Remove(xfrmRevisionSanidad_InspeccionSeguridad.Instance);
                            //this.Controls.Clear();
                    ((Form)this.TopLevelControl).DialogResult= DialogResult.OK;
                    ((Form)this.TopLevelControl).Controls.Clear();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                transaction.Rollback();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _instance = null;
            this.Hide();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).DialogResult = DialogResult.Cancel;

        }
    }
}