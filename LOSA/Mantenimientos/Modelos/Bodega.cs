using System;

namespace LOSA.Mantenimientos.Modelos
{
    public class Bodega
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string DescripcionCorta { get; set; }
        public bool Enable { get; set; }
        public DateTime Fecha { get; set; }

        public Bodega()
        {
            Enable = true;
            Fecha = DateTime.Now;
        }
    }
}