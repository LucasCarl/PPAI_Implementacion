using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Implementacion.Clases
{
    class Turno
    {
        public DateTime FechaGeneracion { get; set; }
        public string DiaSemana { get; set; }
        public DateTime FechaHoraInicio { get; set; }
        public DateTime FechaHoraFin { get; set; }
        public List<CambioEstadoTurno> CambioEstadoTurno { get; set; }
    }
}
