using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Implementacion.Clases
{
    class Turno
    {
        private DateTime fechaGeneracion;
        private string diaSemana;
        private DateTime fechaHoraInicio;
        private DateTime fechaHoraFin;
        private List<CambioEstadoTurno> cambioEstadoTurno;

        public Turno(DateTime desde, DateTime hasta)
        {
            fechaHoraInicio = desde;
            fechaHoraFin = hasta;
        }

        public bool EsPosteriorAFechaActual()
        {
            return fechaHoraInicio > DateTime.Now;
        }

        public void MostrarTurno()
        {

        }

        public void ReservarTurno()
        {

        }
    }
}
