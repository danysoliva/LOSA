using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.MicroIngredientes.Models
{
    class PesajeIndividualCompletados
    {
        public int OrdenPesaje_H { get; set; }
        public DateTime Fecha { get; set; }
        public decimal PesoReal { get; set; }
        public string lote { get; set; }
        public decimal cant_sacos_seleccionados { get; set; }
        public int cant_batch_seleccionados { get; set; }
        public int id_mp { get; set; }
       public int order_id { get; set; }

    }
}
