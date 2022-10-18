using DevExpress.Xpo;
using System;

namespace LOSA.MicroIngredientes.Models
{
    public class PesajeBasculaInfo 
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
        public int CantBatch { get; set; }
        public int BasculaId { get; set; }
    }

}