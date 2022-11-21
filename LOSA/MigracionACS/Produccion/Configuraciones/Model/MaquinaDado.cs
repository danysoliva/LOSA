using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  LOSA.MigracionACS.Produccion.Configuraciones.Model
{
   public class MaquinaDado
    {
        public int ID { get; set; }
        public int Tipo { get; set; }
        public string Descripcion { get; set; }
        public int MaquinaID { get; set; }
    }
}
