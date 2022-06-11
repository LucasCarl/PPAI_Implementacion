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
            if (tipo == null)
                return true;
            else
                return tipo.MostrarTipoRT() == tipoRecurso.MostrarTipoRT();
        }

        public bool EsActivo()
        {
            CambioEstadoRT ultimo = null;
            foreach (CambioEstadoRT cambio in cambioEstadoRT)
            {
                if (cambio.EsActual())
                {
                    ultimo = cambio;
                    break;
                }
            }

            return ultimo.EsReservable();
        }

        public string[] MostrarDatosRT()
        {
            string[] datos = new string[5];     //0: NroInventario, 1: CentroInvest, 2: Modelo, 3: Marca, 4: Estado
            datos[0] = GetNumeroRT().ToString();
            datos[4] = cambioEstadoRT[cambioEstadoRT.Count-1].MostrarEstado();
            datos[1] = ObtenerCI();
            string[] marcaModelo = MostrarMarcaYModelo();   //0: Modelo, 1: Marca
            datos[2] = marcaModelo[0];
            datos[3] = marcaModelo[1];

            return datos;
        }

        public int GetNumeroRT()
        {
            return numeroRT;
        }

        public string ObtenerCI()
        {
            return "Centro";
        }

        public string[] MostrarMarcaYModelo()
        {
            return modeloDelRT.MostrarModelo();
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
