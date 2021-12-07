using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.MicroIngredientes.Models
{
   public class PesajeIndividualInfo
    {
        public decimal Batch_Plan { get; set; }

        public int CantBatchMaximo { get; set; }

        public int id_orden_pesaje_header { get; set; }

        public int MateriaPrimaID { get; set; }
        public decimal Total { get; set; }
        public decimal PesoPorBatch { get; set; }
        public int AMI_ID { get; set; }
        public int BasculaID { get; set; }
        public decimal PesoXBatch { get; set; }
        public string MateriaPrima { get; set; }

    }
}
