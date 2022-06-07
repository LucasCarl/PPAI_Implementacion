using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Implementacion.Clases
{
    class RecursoTecnologico
    {
        private int numeroRT;
        private DateTime fechaAlta;
        private string fraccionHorariosTurnos;
        private List<CaracteristicaRecurso> caracteristicasDelRecurso;
        private TipoRecursoTecnologico tipoRecurso;
        private Modelo modeloDelRT;
        private List<HorarioRT> disponibilidad;
        private List<CambioEstadoRT> cambioEstadoRT;
        private List<Turno> turnos;
    }
}
