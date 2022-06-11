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
        /*
        private TipoRecursoTecnologico tipoSeleccionado;
        private Turno turnoSeleccionado;
        */
        private string tipoSelect;
        private List<RecursoTecnologico> listaRecursos;
        private RecursoTecnologico recursoSeleccionado;

        private TipoRecursoTecnologicoDao tipoRecursoTecnologicoDao;
        private RecursoTecnologicoDao recursoTecnologicoDao;
        private TurnoDao turnoDao;

        public GestorTurnos(PantallaReserva pantalla)
        {
            pantallaReserva = pantalla;
            tipoRecursoTecnologicoDao = TipoRecursoTecnologicoDao.Instancia();
            recursoTecnologicoDao = RecursoTecnologicoDao.Instancia();
            turnoDao = TurnoDao.Instancia();
        }

        public void NuevaReservaTurno()
        {
            List<string> listaRecursos = ObtenerTipoRecurso();
            listaRecursos.Insert(0, "TODOS");
            pantallaReserva.PedirSeleccionTRT(listaRecursos);
        }

        public List<string> ObtenerTipoRecurso()
        {
            return tipoRecursoTecnologicoDao.ObtenerNombresTRT();
        }

        public void TomarSeleccionTRT(string seleccionado)
        {
            //tipoSeleccionado = tipoRecursoTecnologicoDao.ObtenerTipoRecurso(seleccionado);
            tipoSelect = seleccionado;
            BuscarRT();
        }

        public void BuscarRT()
        {
            //Obtener todos los recursos
            List<RecursoTecnologico> listaTodosRecursos = recursoTecnologicoDao.ObtenerRecursos();
            List<string[]> listaDatosRecursos = new List<string[]>();

            //Buscar los recursos del mismo tipo seleccionado
            listaRecursos = new List<RecursoTecnologico>();
            foreach (RecursoTecnologico recurso in listaTodosRecursos)
            {
                bool condicionTipo = (tipoSelect == "TODOS" || recurso.SosTipo(tipoRecursoTecnologicoDao.ObtenerTipoRecurso(tipoSelect)));
                bool condicionActivo = recurso.SosActivo();

                if(condicionTipo && condicionActivo)
                {
                    listaRecursos.Add(recurso);
                    listaDatosRecursos.Add(recurso.MostrarDatos());
                }
            }

            AgruparPorCI();
            pantallaReserva.PedirSeleccionRT(listaDatosRecursos);
        }

        public void AgruparPorCI()
        {
            //Algo
        }

        public void TomarSeleccionRT(int indexSeleccionado)
        {
            recursoSeleccionado = listaRecursos[indexSeleccionado];
            VerificarCIDeCLogueado();
            ObtenerTurnosReservables();
        }

        public void VerificarCIDeCLogueado()
        {

        }

        public void ObtenerTurnosReservables()
        {
            DateTime hoy = GetFechaActual();
            AgruparYOrdenarTurnos();
            DisponibilidadPorFecha(hoy);
            pantallaReserva.PedirSeleccionTurno();
        }

        public DateTime GetFechaActual()
        {
            return DateTime.Today;
        }

        public void AgruparYOrdenarTurnos()
        {

        }

        public void DisponibilidadPorFecha(DateTime fecha)
        {

        }

        public void TomarSeleccionTurno(int indexSeleccionado)
        {
            //turnoSeleccionado = seleccionado;
            pantallaReserva.PedirConfirmacionTurno();
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
