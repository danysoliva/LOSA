using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  LOSA.MigracionACS.Tickets.Models
{
   public class CopiaCorreo
    {
        public int ID { get; set; }
        public string Correo { get; set; }
        public string User { get; set; }
        public string Nombre { get; set; }
        public bool CC { get; set; }
    }
}
