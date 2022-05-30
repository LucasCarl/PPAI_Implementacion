using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Implementacion.Clases
{
    class CentroDeInvestigacion
    {
        #region Variables
        public string Nombre { get; set; }
        public string Sigla { get; set; }
        public string Direccion { get; set; }
        public string Edificio { get; set; }
        public int Piso { get; set; }
        public string Coordenadas { get; set; }
        public string TelefonosContacto { get; set; }
        public string CorreoElectronico { get; set; }
        public int numeroResolucionCreacion { get; set; }
        public DateTime fechaResolucionCreacion { get; set; }
        public string Reglamento { get; set; }
        public string CaracteristicasGenerales { get; set; }
        public DateTime FechaAlta { get; set; }
        public int TiempoAntelacionReserva { get; set; }
        public DateTime FechaBaja { get; set; }
        public string MotivoBaja { get; set; }
        public List<AsignacionDirectorCI> directorCI { get; set; }
        public List<AsignacionCientificoDelCI> cientificos { get; set; }
        public List<RecursoTecnologico> recursosTecnologicos { get; set; }
        #endregion


    }
}
