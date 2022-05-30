using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.Calidad.Revision_Sanidad.Model
{
   public class InspeccionPresentacionConductor
    {
        public int ID_H { get; set; }
        public int InspeccionConductorTemplateID { get; set; }
        public string InspeccionConductorTemplateName { get; set; }
        public bool Result { get; set; }
    }
}
