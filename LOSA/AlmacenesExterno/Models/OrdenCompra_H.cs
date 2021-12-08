using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.AlmacenesExterno.Models
{
    public class OrdenCompra_H
    {
        public int ID { get; set; }
        public int DocNum { get; set; }
        public string CodProv { get; set; }
        public string Proveedor { get; set; }
        public DateTime FechaDocumento { get; set; }
        public string Comentario { get; set; }
        public decimal Peso { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int UserID { get; set; }
        public int DocEntrySAP { get; set; }
        public decimal Unidades { get; set; }
        public string Factura { get; set; }
    }


}
