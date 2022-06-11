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

        public RecursoTecnologico(int nro, TipoRecursoTecnologico tipo, Modelo mod)
        {
            numeroRT = nro;
            tipoRecurso = tipo;
            modeloDelRT = mod;
        }

        public bool SosTipo(TipoRecursoTecnologico tipo)
        {
            return tipoRecurso.Equals(tipo);
        }

        public bool SosActivo()
        {
            return true;
        }

        public string[] MostrarDatos()
        {
            string[] datos = new string[5];
            datos[0] = numeroRT.ToString();
            datos[1] = "CentroInvest";
            datos[2] = modeloDelRT.GetNombre();
            datos[3] = "Marca";
            datos[4] = "Estado";

            return datos;
        }

        public void MostrarTurnosPosFA()
        {

        }
    }
}
