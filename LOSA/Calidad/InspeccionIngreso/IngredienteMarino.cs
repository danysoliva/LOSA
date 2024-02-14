using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.Calidad.InspeccionIngreso
{
    public class IngredienteMarino
    {
        public int? Origen { get; set; }
        public int? Tipo { get; set; }
        public decimal? PorcentajeTipo { get; set; }
        public int? ZonaPesca { get; set; }
        public string Planta { get; set; }
        public decimal? PorcentajeSustentable { get; set; }
        public int? PaisOrigen { get; set; }
        public string FishSurse { get; set; }
        public string IUCN { get; set; }
        
    }
}
