using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.Calidad.Revision_Sanidad.Model
{
    public class InspeccionSeguridad
    {
        public int InspeccionSeguridadPlantillaID { get; set; }
        public int InspeccionSeguridadRespuestaID { get; set; }

        public bool RecuperarRegistro()
        {
            try
            {

            return true;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            return false;
            }
        }

    }


}
