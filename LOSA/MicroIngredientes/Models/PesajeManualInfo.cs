using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.MicroIngredientes.Models
{
   public class PesajeManualInfo
    {
        public int MateriaPrimaID { get; set; }
        public decimal Total { get; set; }
        public int OrdenID { get; set; }
        public int CantBatch { get; set; }
        public int DetallePesajeManualPlanID { get; set; }
        public int BatchPlan { get; set; }
        public int AMI_ID { get; set; }
    }
}
