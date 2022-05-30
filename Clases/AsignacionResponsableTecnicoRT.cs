using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Implementacion.Clases
{
    class AsignacionResponsableTecnicoRT
    {
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public PersonalCientifico PersonalCientifico { get; set; }
        public List<RecursoTecnologico> recursos { get; set; }

    }
}
