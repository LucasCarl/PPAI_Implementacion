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
        private TipoRecursoTecnologico tipoRecurso;
        private Modelo modeloDelRT;
        private List<HorarioRT> disponibilidad;
        private List<CambioEstadoRT> cambioEstadoRT;
        private List<Turno> turnos;

        public RecursoTecnologico(int nro, TipoRecursoTecnologico tipo, Modelo mod, List<CambioEstadoRT> estados)
        {
            numeroRT = nro;
            tipoRecurso = tipo;
            modeloDelRT = mod;
            cambioEstadoRT = estados;
        }

        public bool EsDeTipoRTSeleccionado(TipoRecursoTecnologico tipo)
        {
            return tipoRecurso.Equals(tipo);
        }

        public bool EsActivo()
        {
            return true;
        }

        public string[] MostrarDatosRT()
        {
            string[] datos = new string[5];
            datos[0] = numeroRT.ToString();
            datos[1] = "CentroInvest";
            datos[2] = modeloDelRT.GetNombre();
            datos[3] = "Marca";
            datos[4] = cambioEstadoRT[cambioEstadoRT.Count-1].GetEstado();

            return datos;
        }

        public int GetNumeroRT()
        {
            return numeroRT;
        }

        public void ObtenerCI()
        {

        }

        public string[] MostrarMarcaYModelo()
        {
            return null;
        }

        public bool EsCientificoDelCI()
        {
            return true;
        }

        public void MostrarTurnos()
        {

        }

        public void RegistrarReservaTurno()
        {

        }
    }
}
