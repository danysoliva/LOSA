using System;

namespace LOSA.Mantenimientos.Modelos
{
    public class EstadoProgramacionRequisicion
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public bool Enable { get; set; }
        public DateTime Fecha { get; set; }

        public EstadoProgramacionRequisicion()
        {
            Id = 0;
            Enable = true;
            Fecha = DateTime.Now;
        }
    }

}
