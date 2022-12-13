using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.MigracionACS.Forecast.Models
{
   public class Proyeccion_Ventas
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Comentario { get; set; }
        public int Anio { get; set; }
    }
}
