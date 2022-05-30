using ACS.Classes;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;

namespace LOSA.Calidad.Revision_Sanidad.RPT
{
    public partial class xrSanidad : DevExpress.XtraReports.UI.XtraReport
    {
        public xrSanidad(int id_h)
        {
            InitializeComponent();

            //bool valor = false;

            //if (valor)
            //{
            //    xrInspeccionSeguridad_1_1.Text = "( X )";
            //}
            //else
            //{
            //    xrInspeccionSeguridad_1_2.Text = "( X )";

            //}
            InspeccionSeguridad(id_h);
            RevisionSanidad(id_h,1);
            RevisionSanidad2(id_h,2);
            RevisionSanidad3(id_h,3);
            InspeccionConductor(id_h);
            InfoVehiculo_H(id_h);
        }


        public void InspeccionSeguridad(int id_h)
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA);


                cnx.Open();

                SqlDataAdapter da = new SqlDataAdapter("dbo.sp_get_sanidad_inspeccion_seguridad", cnx);
                da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@id_h", System.Data.SqlDbType.Int).Value = id_h;
                dsSanidad1.InspeccionSeguridad.Clear();
                da.Fill(dsSanidad1.InspeccionSeguridad);

                foreach (var item in dsSanidad1.InspeccionSeguridad)
                {
                    if (item.id_inspeccion_seguridad_plantilla==1)
                    {
                        if (item.id_inspeccion_seguridad_respuesta==3)
                        {
                            xrInspeccionSeguridad_1_1.Text = "( X )";
                        }
                        else
                         if (item.id_inspeccion_seguridad_respuesta == 4)
                        {
                            xrInspeccionSeguridad_1_2.Text = "( X )";
                        }
                    }

                    if (item.id_inspeccion_seguridad_plantilla == 2)
                    {
                        if (item.id_inspeccion_seguridad_respuesta == 3)
                        {
                            xrInspeccionSeguridad_2_1.Text = "( X )";
                        }
                        else
                         if (item.id_inspeccion_seguridad_respuesta == 4)
                        {
                            xrInspeccionSeguridad_2_2.Text = "( X )";
                        }
                    }

                    if (item.id_inspeccion_seguridad_plantilla == 3)
                    {
                        if (item.id_inspeccion_seguridad_respuesta == 3)
                        {
                            xrInspeccionSeguridad_3_1.Text = "( X )";
                        }
                        else
                         if (item.id_inspeccion_seguridad_respuesta == 4)
                        {
                            xrInspeccionSeguridad_3_2.Text = "( X )";
                        }
                    }

                    if (item.id_inspeccion_seguridad_plantilla == 4)
                    {
                        if (item.id_inspeccion_seguridad_respuesta == 3)
                        {
                            xrInspeccionSeguridad_4_1.Text = "( X )";
                        }
                        else
                         if (item.id_inspeccion_seguridad_respuesta == 4)
                        {
                            xrInspeccionSeguridad_4_2.Text = "( X )";
                        }
                    }

                    if (item.id_inspeccion_seguridad_plantilla == 5)
                    {
                        if (item.id_inspeccion_seguridad_respuesta == 3)
                        {
                            xrInspeccionSeguridad_5_1.Text = "( X )";
                        }
                        else
                         if (item.id_inspeccion_seguridad_respuesta == 4)
                        {
                            xrInspeccionSeguridad_5_2.Text = "( X )";
                        }
                    }

                    if (item.id_inspeccion_seguridad_plantilla == 6)
                    {
                        if (item.id_inspeccion_seguridad_respuesta == 3)
                        {
                            xrInspeccionSeguridad_6_1.Text = "( X )";
                        }
                        else
                         if (item.id_inspeccion_seguridad_respuesta == 4)
                        {
                            xrInspeccionSeguridad_6_2.Text = "( X )";
                        }
                    }

                    if (item.id_inspeccion_seguridad_plantilla == 7)
                    {
                        if (item.id_inspeccion_seguridad_respuesta == 3)
                        {
                            xrInspeccionSeguridad_7_1.Text = "( X )";
                        }
                        else
                         if (item.id_inspeccion_seguridad_respuesta == 4)
                        {
                            xrInspeccionSeguridad_7_2.Text = "( X )";
                        }
                    }

                    if (item.id_inspeccion_seguridad_plantilla == 8)
                    {
                        if (item.id_inspeccion_seguridad_respuesta == 5)
                        {
                            xrInspeccionSeguridad_8_1.Text = "( X )";
                        }
                        else
                         if (item.id_inspeccion_seguridad_respuesta == 6)
                        {
                            xrInspeccionSeguridad_8_2.Text = "( X )";
                        }
                        else
                         if (item.id_inspeccion_seguridad_respuesta == 7)
                        {
                            xrInspeccionSeguridad_8_3.Text = "( X )";
                        }
                    }

                    if (item.id_inspeccion_seguridad_plantilla == 9)
                    {
                        if (item.id_inspeccion_seguridad_respuesta == 1)
                        {
                            xrInspeccionSeguridad_9_1.Text = "( X )";
                        }
                        else
                         if (item.id_inspeccion_seguridad_respuesta == 2)
                        {
                            xrInspeccionSeguridad_9_2.Text = "( X )";
                        }
                    }

                    if (item.id_inspeccion_seguridad_plantilla == 10)
                    {
                        if (item.id_inspeccion_seguridad_respuesta == 1)
                        {
                            xrInspeccionSeguridad_10_1.Text = "( X )";
                        }
                        else
                         if (item.id_inspeccion_seguridad_respuesta == 2)
                        {
                            xrInspeccionSeguridad_10_2.Text = "( X )";
                        }
                    }

                    if (item.id_inspeccion_seguridad_plantilla == 11)
                    {
                        if (item.id_inspeccion_seguridad_respuesta == 1)
                        {
                            xrInspeccionSeguridad_11_1.Text = "( X )";
                        }
                        else
                         if (item.id_inspeccion_seguridad_respuesta == 2)
                        {
                            xrInspeccionSeguridad_11_2.Text = "( X )";
                        }
                    }

                    if (item.id_inspeccion_seguridad_plantilla == 12)
                    {
                        if (item.id_inspeccion_seguridad_respuesta == 1)
                        {
                            xrInspeccionSeguridad_12_1.Text = "( X )";
                        }
                        else
                         if (item.id_inspeccion_seguridad_respuesta == 2)
                        {
                            xrInspeccionSeguridad_12_2.Text = "( X )";
                        }
                    }

                    if (item.id_inspeccion_seguridad_plantilla == 13)
                    {
                        if (item.id_inspeccion_seguridad_respuesta == 1)
                        {
                            xrInspeccionSeguridad_13_1.Text = "( X )";
                        }
                        else
                         if (item.id_inspeccion_seguridad_respuesta == 2)
                        {
                            xrInspeccionSeguridad_13_2.Text = "( X )";
                        }
                    }

                    if (item.id_inspeccion_seguridad_plantilla == 14)
                    {
                        if (item.id_inspeccion_seguridad_respuesta == 1)
                        {
                            xrInspeccionSeguridad_14_1.Text = "( X )";
                        }
                        else
                         if (item.id_inspeccion_seguridad_respuesta == 2)
                        {
                            xrInspeccionSeguridad_14_2.Text = "( X )";
                        }
                    }

                    if (item.id_inspeccion_seguridad_plantilla == 15)
                    {
                        if (item.id_inspeccion_seguridad_respuesta == 1)
                        {
                            xrInspeccionSeguridad_15_1.Text = "( X )";
                        }
                        else
                         if (item.id_inspeccion_seguridad_respuesta == 2)
                        {
                            xrInspeccionSeguridad_15_2.Text = "( X )";
                        }
                    }

                    if (item.id_inspeccion_seguridad_plantilla == 16)
                    {
                        if (item.id_inspeccion_seguridad_respuesta == 1)
                        {
                            xrInspeccionSeguridad_16_1.Text = "( X )";
                        }
                        else
                         if (item.id_inspeccion_seguridad_respuesta == 2)
                        {
                            xrInspeccionSeguridad_16_2.Text = "( X )";
                        }
                    }

                    if (item.id_inspeccion_seguridad_plantilla == 17)
                    {
                        if (item.id_inspeccion_seguridad_respuesta == 1)
                        {
                            xrInspeccionSeguridad_17_1.Text = "( X )";
                        }
                        else
                         if (item.id_inspeccion_seguridad_respuesta == 2)
                        {
                            xrInspeccionSeguridad_17_2.Text = "( X )";
                        }
                    }

                    if (item.id_inspeccion_seguridad_plantilla == 18)
                    {
                        if (item.id_inspeccion_seguridad_respuesta == 1)
                        {
                            xrInspeccionSeguridad_18_1.Text = "( X )";
                        }
                        else
                         if (item.id_inspeccion_seguridad_respuesta == 2)
                        {
                            xrInspeccionSeguridad_18_2.Text = "( X )";
                        }
                    }

                    if (item.id_inspeccion_seguridad_plantilla == 19)
                    {
                        if (item.id_inspeccion_seguridad_respuesta == 1)
                        {
                            xrInspeccionSeguridad_19_1.Text = "( X )";
                        }
                        else
                         if (item.id_inspeccion_seguridad_respuesta == 2)
                        {
                            xrInspeccionSeguridad_19_2.Text = "( X )";
                        }
                    }

                    if (item.id_inspeccion_seguridad_plantilla == 20)
                    {
                        if (item.id_inspeccion_seguridad_respuesta == 1)
                        {
                            xrInspeccionSeguridad_20_1.Text = "( X )";
                        }
                        else
                         if (item.id_inspeccion_seguridad_respuesta == 2)
                        {
                            xrInspeccionSeguridad_20_2.Text = "( X )";
                        }
                    }


                }

                cnx.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

        }

        public void RevisionSanidad(int id_h, int numero_revision)
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA);

                SqlDataAdapter da = new SqlDataAdapter("dbo.sp_get_revision_sanidad_vehiculo", cnx);
                da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@id_h",System.Data.SqlDbType.Int).Value=id_h;
                da.SelectCommand.Parameters.Add("@numero_revision", System.Data.SqlDbType.Int).Value= numero_revision;

                dsSanidad1.RevisionSanidad.Clear();
                da.Fill(dsSanidad1.RevisionSanidad);


                foreach (var item in dsSanidad1.RevisionSanidad)
                {
                    if (item.id_revision_sanidad_plantilla==1)
                    {
                        if (item.result)
                        {
                            xrSanidad_1_1_1.Text = "( X )";
                        }
                        else
                        {
                            xrSanidad_1_1_2.Text = "( X )";
                        }

                    }

                    if (item.id_revision_sanidad_plantilla == 2)
                    {
                        if (item.result)
                        {
                            xrSanidad_1_2_1.Text = "( X )";
                        }
                        else
                        {
                            xrSanidad_1_2_2.Text = "( X )";
                        }

                    }

                    if (item.id_revision_sanidad_plantilla == 3)
                    {
                        if (item.result)
                        {
                            xrSanidad_1_3_1.Text = "( X )";
                        }
                        else
                        {
                            xrSanidad_1_3_2.Text = "( X )";
                        }

                    }

                    if (item.id_revision_sanidad_plantilla == 4)
                    {
                        if (item.result)
                        {
                            xrSanidad_1_4_1.Text = "( X )";
                        }
                        else
                        {
                            xrSanidad_1_4_2.Text = "( X )";
                        }

                    }

                    if (item.id_revision_sanidad_plantilla == 5)
                    {
                        if (item.result)
                        {
                            xrSanidad_1_5_1.Text = "( X )";
                        }
                        else
                        {
                            xrSanidad_1_5_2.Text = "( X )";
                        }

                    }

                    if (item.id_revision_sanidad_plantilla == 6)
                    {
                        if (item.result)
                        {
                            xrSanidad_1_6_1.Text = "( X )";
                        }
                        else
                        {
                            xrSanidad_1_6_2.Text = "( X )";
                        }

                    }

                    if (item.id_revision_sanidad_plantilla == 7)
                    {
                        if (item.result)
                        {
                            xrSanidad_1_7_1.Text = "( X )";
                        }
                        else
                        {
                            xrSanidad_1_7_2.Text = "( X )";
                        }

                    }

                    if (item.id_revision_sanidad_plantilla == 8)
                    {
                        if (item.result)
                        {
                            xrSanidad_1_8_1.Text = "( X )";
                        }
                        else
                        {
                            xrSanidad_1_8_2.Text = "( X )";
                        }

                    }

                    if (item.id_revision_sanidad_plantilla == 9)
                    {
                        if (item.result)
                        {
                            xrSanidad_1_9_1.Text = "( X )";
                        }
                        else
                        {
                            xrSanidad_1_9_2.Text = "( X )";
                        }

                    }

                    if (item.id_revision_sanidad_plantilla == 10)
                    {
                        if (item.result)
                        {
                            xrSanidad_1_10_1.Text = "( X )";
                        }
                        else
                        {
                            xrSanidad_1_10_2.Text = "( X )";
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void RevisionSanidad3(int id_h, int numero_revision)
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA);

                SqlDataAdapter da = new SqlDataAdapter("dbo.sp_get_revision_sanidad_vehiculo", cnx);
                da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@id_h", System.Data.SqlDbType.Int).Value = id_h;
                da.SelectCommand.Parameters.Add("@numero_revision", System.Data.SqlDbType.Int).Value = numero_revision;

                dsSanidad1.RevisionSanidad.Clear();
                da.Fill(dsSanidad1.RevisionSanidad);


                foreach (var item in dsSanidad1.RevisionSanidad)
                {
                    if (item.id_revision_sanidad_plantilla == 1)
                    {
                        if (item.result)
                        {
                            xrSanidad_3_1_1.Text = "( X )";
                        }
                        else
                        {
                            xrSanidad_3_1_2.Text = "( X )";
                        }

                    }

                    if (item.id_revision_sanidad_plantilla == 2)
                    {
                        if (item.result)
                        {
                            xrSanidad_3_2_1.Text = "( X )";
                        }
                        else
                        {
                            xrSanidad_3_2_2.Text = "( X )";
                        }

                    }

                    if (item.id_revision_sanidad_plantilla == 3)
                    {
                        if (item.result)
                        {
                            xrSanidad_3_3_1.Text = "( X )";
                        }
                        else
                        {
                            xrSanidad_3_3_2.Text = "( X )";
                        }

                    }

                    if (item.id_revision_sanidad_plantilla == 4)
                    {
                        if (item.result)
                        {
                            xrSanidad_3_4_1.Text = "( X )";
                        }
                        else
                        {
                            xrSanidad_3_4_2.Text = "( X )";
                        }

                    }

                    if (item.id_revision_sanidad_plantilla == 5)
                    {
                        if (item.result)
                        {
                            xrSanidad_3_5_1.Text = "( X )";
                        }
                        else
                        {
                            xrSanidad_3_5_2.Text = "( X )";
                        }

                    }

                    if (item.id_revision_sanidad_plantilla == 6)
                    {
                        if (item.result)
                        {
                            xrSanidad_3_6_1.Text = "( X )";
                        }
                        else
                        {
                            xrSanidad_3_6_2.Text = "( X )";
                        }

                    }

                    if (item.id_revision_sanidad_plantilla == 7)
                    {
                        if (item.result)
                        {
                            xrSanidad_3_7_1.Text = "( X )";
                        }
                        else
                        {
                            xrSanidad_3_7_2.Text = "( X )";
                        }

                    }

                    if (item.id_revision_sanidad_plantilla == 8)
                    {
                        if (item.result)
                        {
                            xrSanidad_3_8_1.Text = "( X )";
                        }
                        else
                        {
                            xrSanidad_3_8_2.Text = "( X )";
                        }

                    }

                    if (item.id_revision_sanidad_plantilla == 9)
                    {
                        if (item.result)
                        {
                            xrSanidad_3_9_1.Text = "( X )";
                        }
                        else
                        {
                            xrSanidad_3_9_2.Text = "( X )";
                        }

                    }

                    if (item.id_revision_sanidad_plantilla == 10)
                    {
                        if (item.result)
                        {
                            xrSanidad_3_10_1.Text = "( X )";
                        }
                        else
                        {
                            xrSanidad_3_10_2.Text = "( X )";
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void RevisionSanidad2(int id_h, int numero_revision)
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA);

                SqlDataAdapter da = new SqlDataAdapter("dbo.sp_get_revision_sanidad_vehiculo", cnx);
                da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@id_h", System.Data.SqlDbType.Int).Value = id_h;
                da.SelectCommand.Parameters.Add("@numero_revision", System.Data.SqlDbType.Int).Value = numero_revision;

                dsSanidad1.RevisionSanidad.Clear();
                da.Fill(dsSanidad1.RevisionSanidad);


                foreach (var item in dsSanidad1.RevisionSanidad)
                {
                    if (item.id_revision_sanidad_plantilla == 1)
                    {
                        if (item.result)
                        {
                            xrSanidad_2_1_1.Text = "( X )";
                        }
                        else
                        {
                            xrSanidad_2_1_2.Text = "( X )";
                        }

                    }

                    if (item.id_revision_sanidad_plantilla == 2)
                    {
                        if (item.result)
                        {
                            xrSanidad_2_2_1.Text = "( X )";
                        }
                        else
                        {
                            xrSanidad_2_2_2.Text = "( X )";
                        }

                    }

                    if (item.id_revision_sanidad_plantilla == 3)
                    {
                        if (item.result)
                        {
                            xrSanidad_2_3_1.Text = "( X )";
                        }
                        else
                        {
                            xrSanidad_2_3_2.Text = "( X )";
                        }

                    }

                    if (item.id_revision_sanidad_plantilla == 4)
                    {
                        if (item.result)
                        {
                            xrSanidad_2_4_1.Text = "( X )";
                        }
                        else
                        {
                            xrSanidad_2_4_2.Text = "( X )";
                        }

                    }

                    if (item.id_revision_sanidad_plantilla == 5)
                    {
                        if (item.result)
                        {
                            xrSanidad_2_5_1.Text = "( X )";
                        }
                        else
                        {
                            xrSanidad_2_5_2.Text = "( X )";
                        }

                    }

                    if (item.id_revision_sanidad_plantilla == 6)
                    {
                        if (item.result)
                        {
                            xrSanidad_2_6_1.Text = "( X )";
                        }
                        else
                        {
                            xrSanidad_2_6_2.Text = "( X )";
                        }

                    }

                    if (item.id_revision_sanidad_plantilla == 7)
                    {
                        if (item.result)
                        {
                            xrSanidad_2_7_1.Text = "( X )";
                        }
                        else
                        {
                            xrSanidad_2_7_2.Text = "( X )";
                        }

                    }

                    if (item.id_revision_sanidad_plantilla == 8)
                    {
                        if (item.result)
                        {
                            xrSanidad_2_8_1.Text = "( X )";
                        }
                        else
                        {
                            xrSanidad_2_8_2.Text = "( X )";
                        }

                    }

                    if (item.id_revision_sanidad_plantilla == 9)
                    {
                        if (item.result)
                        {
                            xrSanidad_2_9_1.Text = "( X )";
                        }
                        else
                        {
                            xrSanidad_2_9_2.Text = "( X )";
                        }

                    }

                    if (item.id_revision_sanidad_plantilla == 10)
                    {
                        if (item.result)
                        {
                            xrSanidad_2_10_1.Text = "( X )";
                        }
                        else
                        {
                            xrSanidad_2_10_2.Text = "( X )";
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }


        public void InspeccionConductor(int id_h)
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA);

                SqlDataAdapter da = new SqlDataAdapter("dbo.sp_get_sanidad_inspeccion_conductor", cnx);
                da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@id_h", System.Data.SqlDbType.Int).Value = id_h;

                dsSanidad1.InspeccionConductor.Clear();
                da.Fill(dsSanidad1.InspeccionConductor);


                foreach (var item in dsSanidad1.InspeccionConductor)
                {
                    if (item.inspeccion_conductor_template_id==1)
                    {
                        if (item.result)
                        {
                            xrConductor_1_1.Text = "( X )";
                        }
                        else
                        {
                            xrConductor_1_2.Text = "( X )";

                        }
                    }

                    if (item.inspeccion_conductor_template_id == 2)
                    {
                        if (item.result)
                        {
                            xrConductor_2_1.Text = "( X )";
                        }
                        else
                        {
                            xrConductor_2_2.Text = "( X )";

                        }
                    }

                    if (item.inspeccion_conductor_template_id == 3)
                    {
                        if (item.result)
                        {
                            xrConductor_3_1.Text = "( X )";
                        }
                        else
                        {
                            xrConductor_3_2.Text = "( X )";

                        }
                    }

                    if (item.inspeccion_conductor_template_id == 4)
                    {
                        if (item.result)
                        {
                            xrConductor_4_1.Text = "( X )";
                        }
                        else
                        {
                            xrConductor_4_2.Text = "( X )";

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void InfoVehiculo_H(int id_h)
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA);

                SqlDataAdapter da = new SqlDataAdapter("dbo.rpt_get_sanidad_vehiculo_by_id",cnx);
                da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@id",System.Data.SqlDbType.Int).Value=id_h;

                dsSanidad1.info_vehiculo.Clear();

                da.Fill(dsSanidad1.info_vehiculo);

                foreach (var item in dsSanidad1.info_vehiculo)
                {
                    xrConductor.Text = item.conductor;
                    xrFecha.Text = item.fecha.ToString();
                    xrHora.Text = item.hora.ToString();
                    xrPlaca.Text = item.placa;
                    xrContenedorT.Text = item.tamanio_contenedor.ToString();
                    xrCliente.Text = item.cliente;
                    xrSectorCliente.Text = item.sector_cliente_destino;
                    xrNContenedor.Text = item.contenedor;
                    xrCorrelativo.Text = item.id.ToString().PadLeft(6,'0');
                    xrFechaCreacion.Text = item.fecha_creacion.ToString();
                    xrProveedorTransporte.Text = item.proveedor_transporte;


                    //Revision 1
                    if (item.revision_1==1)
                    {
                        xrRevision1_1.Text = "( X )";
                        xrHora1.Text = item.fecha_revision_1.ToShortTimeString();
                    }
                    else
                    if (item.revision_1== 0)
                    {
                         xrRevision1_2.Text = "( X )";
                        xrHora1.Text = item.fecha_revision_1.ToShortTimeString();


                    }
                    else
                    {
                         xrRevision1_1.Text = "(   )";
                         xrRevision1_2.Text = "(   )";

                    }


                    //Revision 2
                    if (item.revision_2 == 1)
                    {
                        xrRevision2_1.Text = "( X )";
                        xrHora2.Text = item.fecha_revision_2.ToShortTimeString();

                    }
                    else
                  if (item.revision_2 == 0)
                    {
                        xrRevision2_2.Text = "( X )";
                        xrHora2.Text = item.fecha_revision_2.ToShortTimeString();

                    }
                    else
                    {
                        xrRevision2_1.Text = "(   )";
                        xrRevision2_2.Text = "(   )";

                    }


                    //Revision 3
                    if (item.revision_3 == 1)
                    {
                        xrRevision3_1.Text = "( X )";
                        xrHora3.Text = item.fecha_revision_3.ToShortTimeString();
                    }
                    else
                  if (item.revision_3 == 0)
                    {
                        xrRevision3_2.Text = "( X )";
                        xrHora3.Text = item.fecha_revision_3.ToShortTimeString();

                    }
                    else
                    {
                        xrRevision3_1.Text = "(   )";
                        xrRevision3_2.Text = "(   )";

                    }


                }


            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

    }
}
