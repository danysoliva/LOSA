using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.Logistica.Models
{
   public class Producto_Terminado
    {
        public int TarimaID { get; set; }
        public string CodigoBarra { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int ID { get; set; }
    }
}
