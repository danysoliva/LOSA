using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.Calidad.Revision_Sanidad.Model
{
   public class InspeccionSeguridad_Results
    {
        public int ID_H { get; set; }
        public int InspeccionSeguridadPlantillaID { get; set; }
        public string InspeccionSeguridadPlantillaName { get; set; }
        public int InspeccionSeguridadRespuestaID { get; set; }
    }
}
