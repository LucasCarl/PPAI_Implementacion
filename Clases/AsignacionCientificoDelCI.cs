using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Implementacion.Clases
{
    class AsignacionCientificoDelCI
    {
        private DateTime fechaDesde;
        private DateTime fechaHasta;
        private PersonalCientifico personalCientifico;
        private List<Turno> turnos;

        public AsignacionCientificoDelCI(DateTime desde, PersonalCientifico cientifico)
        {
            fechaDesde = desde;
            personalCientifico = cientifico;
        }

        public bool EsCientificoActivo()
        {
            return true;
        }

        public void AgregarNuevoTurno(Turno turnoNuevo)
        {
            turnos.Add(turnoNuevo);
        }
    }
}
