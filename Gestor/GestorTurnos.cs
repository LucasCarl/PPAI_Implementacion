using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI_Implementacion.ObtencionDatos;
using PPAI_Implementacion.Clases;
using PPAI_Implementacion.Interfaz;

namespace PPAI_Implementacion.Gestor
{
    class GestorTurnos
    {
        private PantallaReserva pantallaReserva;
        private TipoRecursoTecnologico tipoSeleccionado;
        private RecursoTecnologico recursoSeleccionado;
        private Turno turnoSeleccionado;

        public GestorTurnos(PantallaReserva pantalla)
        {
            pantallaReserva = pantalla;
        }

        public void NuevaReservaTurno()
        {
            IList<TipoRecursoTecnologico> listaRecursos = ObtenerTipoRecurso();
            pantallaReserva.PedirSeleccionTRT(listaRecursos);
        }

        public IList<TipoRecursoTecnologico> ObtenerTipoRecurso()
        {
            TipoRecursoTecnologicoDao tipoRecursoTecnologicoDao = new TipoRecursoTecnologicoDao();
            return tipoRecursoTecnologicoDao.ObtenerTiposRecursos();
        }

        public void TomarSeleccionTRT(TipoRecursoTecnologico seleccionado)
        {
            tipoSeleccionado = seleccionado;
        }

        public RecursoTecnologico[] BuscarRT()
        {
            return new RecursoTecnologico[2];
        }

        public void AgruparPorCI()
        {

        }

        public void TomarSeleccionRT(RecursoTecnologico seleccionado)
        {
            recursoSeleccionado = seleccionado;
        }

        public void VerificarCIDeCLogueado()
        {

        }

        public void ObtenerTurnosReservables()
        {

        }

        public void GetFechaActual()
        {

        }

        public void AgruparYOrdenarTurnos()
        {

        }

        public void DisponibilidadPorFecha()
        {

        }

        public void TomarSeleccionTurno(Turno seleccionado)
        {
            turnoSeleccionado = seleccionado;
        }

        public void ReservarTurnoRT()
        {

        }

        public void GenerarReservaTurno()
        {

        }

        public void ObtenerEstadoReservado()
        {

        }

        public void ObtenerMailCientifico()
        {

        }
    }
}
