using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.Liquidos.Models
{
   public class CamionIN
    {
        public int ID { get; set; }
        public string Comentarios { get; set; }
        public string EmpresaTransporte { get; set; }
        public DateTime FechaEntra { get; set; }
        public DateTime FechaFin { get; set; }
        public string ShipID { get; set; }
        public string Barco { get; set; }
        public string NumeroFactura { get; set; }
        public string Operador { get; set; }
        public decimal PesoBruto { get; set; }
        public decimal PesoNetoIN { get; set; }
        public decimal PesoProd { get; set; }
        public decimal PesoSalida { get; set; }
        public decimal PesoFactura { get; set; }
        public string   ConductorIN{ get; set; }
        public string Vehiculo { get; set; }
        public string Furgon { get; set; }
        public string TipoBoleta { get; set; }
        public int TipoBoletaID { get; set; }
        public int Nboleta { get; set; }
        public string  SNegocio { get; set; }
        public string  Producto { get; set; }
        public string  ItemCode { get; set; }
        public string CardCode { get; set; }
        public string CardName { get; set; }
    }
}
