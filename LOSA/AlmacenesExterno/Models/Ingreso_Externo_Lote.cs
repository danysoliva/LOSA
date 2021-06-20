using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.AlmacenesExterno.Models
{
    public class Ingreso_Externo_Lote
    {
        public int ID { get; set; }
        public string Lote { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Unidades { get; set; }
        public int NumLine { get; set; }
        public int Row_ { get; set; }
    }
}
