using System;

namespace LOSA.Mantenimientos.Modelos
{
    public class EstadoRequisicion
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public bool Enable { get; set; }
        public DateTime Fecha { get; set; }

        public EstadoRequisicion()
        {
            Enable = true;
            Fecha = DateTime.Now;
        }
    }
}
