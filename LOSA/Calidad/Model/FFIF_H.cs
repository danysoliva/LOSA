using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.Calidad.Model
{
   public class FFIF_H
    {
        public int ID { get; set; }
        public DateTime FechaInicial { get; set; }
        public DateTime FechaFinal { get; set; }
        public string   Comentario { get; set; }
        public int Mes { get; set; }
        public int Anio { get; set; }
    }
}
