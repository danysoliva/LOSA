using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.Calidad.Revision_Sanidad.Model
{
   public class RevisionSanidadResumen
    {
        public int ID { get; set; }
        public int RevisionSanidadTemplate_ID { get; set; }
        public string    RevisionSanidadTemplate_Name { get; set; }
        public bool Result { get; set; }
    }
}
