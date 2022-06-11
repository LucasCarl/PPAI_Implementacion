using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Implementacion.Clases
{
    class CambioEstadoTurno
    {
        private DateTime fechaHoraDesde;
        private DateTime fechaHoraHasta;
        private Estado estado;

        public CambioEstadoTurno(DateTime desde, Estado est)
        {
            fechaHoraDesde = desde;
            estado = est;
        }

        public bool EsActual()
        {
            return true;
        }

        public void MostrarEstado()
        {

        }

        public void SetFechaHoraHasta(DateTime hora)
        {
            fechaHoraHasta = hora;
        }
    }
}
