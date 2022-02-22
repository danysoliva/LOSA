using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.Calidad.Model
{
   public class Lote_Ingreso_Conf_Calidad
    {
        public int ID { get; set; }
        public int NumeroIngreso { get; set; }
        public string ItemCode { get; set; }
        public int ID_MP { get; set; }
        public string Lote { get; set; }
    }
}
