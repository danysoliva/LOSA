using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.MicroIngredientes.Models
{
   public class PesajeIndividualNew
    {
        public int ID { get; set; }
        public string Codigo { get; set; }
        public string Material { get; set; }
        public decimal PesoPorBatch { get; set; }
        public decimal PesoTotal { get; set; }
        public decimal BatchPlan { get; set; }
        public int OrdenID { get; set; }
        public decimal PesoReal { get; set; }
        public int MP_ID { get; set; }
        public int BatchCompletados { get; set; }
        public int BatchAPesar { get; set; }
    }
}
