using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Implementacion.Clases
{
    class RecursoTecnologico
    {
        #region Variables
        public int NumeroRT { get; set; }
        public DateTime FechaAlta { get; set; }
        public string Imagenes { get; set; }
        public TimeSpan PeriodicidadMantenimientoPrev { get; set; }
        public TimeSpan DuracionMantenimientoPrev { get; set; }
        public string FraccionHorariosTurnos { get; set; }
        public List<CaracteristicaRecurso> CaracteristicasDelRecurso { get; set; }
        public TipoRecursoTecnologico TipoRecurso { get; set; }
        public Modelo ModeloDelRT { get; set; }
        public List<Mantenimiento> Mantenimientos { get; set; }
        public List<HorarioRT> Disponibilidad { get; set; }
        public List<CambioEstadoRT> CambioEstadoRT { get; set; }
        public List<Turno> Turnos { get; set; }
        #endregion
    }
}
