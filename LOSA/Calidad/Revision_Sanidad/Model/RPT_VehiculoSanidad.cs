using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.Calidad.Revision_Sanidad.Model
{
    public class RPT_VehiculoSanidad
    {

        public List<InspeccionSeguridad_Results> InspeccionSeguridadResults { get; set; }


        //public Boolean RecuperaRegistro()
        //{
        //    try
        //    {
        //        DataOperations dp = new DataOperations();

        //        SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA);


        //        cnx.Open();

        //        SqlDataAdapter da = new SqlDataAdapter("dbo.sp_get_sanidad_inspeccion_seguridad", cnx);

        //        da.Fill(dsSanidad.);

        //        cnx.Close();

        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        CajaDialogo.Error(ex.Message);
        //        return false;
        //    }

        //}
    }
}
