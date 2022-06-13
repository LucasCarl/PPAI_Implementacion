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
        private CambioEstadoTurno ultimoCambio;

        public Turno(DateTime desde, DateTime hasta, List<CambioEstadoTurno> cambiosEstado)
        {
            fechaHoraInicio = desde;
            fechaHoraFin = hasta;
            cambioEstadoTurno = cambiosEstado;
        }

        public bool EsPosteriorAFechaActual()
        {
            return fechaHoraInicio > DateTime.Now;
        }

        public string[] MostrarTurno()
        {
            ultimoCambio = cambioEstadoTurno[cambioEstadoTurno.Count - 1];
            string[] datos = new string[3];
            datos[0] = fechaHoraInicio.ToString();
            datos[1] = fechaHoraFin.ToString();
            datos[2] = ultimoCambio.MostrarEstado();

            return datos;
        }

        public void ReservarTurno(Estado estado)
        {
            ultimoCambio.SetFechaHoraHasta(DateTime.Now);
            CambioEstadoTurno nuevoCambio = new CambioEstadoTurno(DateTime.Now, estado);
            ultimoCambio = nuevoCambio;
        }

        public DateTime GetFechaInicio()
        {
            return fechaHoraInicio;
        }
    }
}
