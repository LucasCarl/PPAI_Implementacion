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
    class GestorRegistrarReservaTurnoRT
    {
        private PantallaRegistrarReservaTurnoRT pantallaReserva;
        private TipoRecursoTecnologico tipoSelect;
        private List<RecursoTecnologico> listaRecursos;
        private RecursoTecnologico recursoSeleccionado;

        private TipoRecursoTecnologicoDao tipoRecursoTecnologicoDao;
        private RecursoTecnologicoDao recursoTecnologicoDao;
        private TurnoDao turnoDao;
        private EstadosDao estadosDao;

        public GestorRegistrarReservaTurnoRT(PantallaRegistrarReservaTurnoRT pantalla)
        {
            pantallaReserva = pantalla;
            tipoRecursoTecnologicoDao = TipoRecursoTecnologicoDao.Instancia();
            recursoTecnologicoDao = RecursoTecnologicoDao.Instancia();
            turnoDao = TurnoDao.Instancia();
            estadosDao = EstadosDao.Instancia();
        }

        public void RegistrarReservaTurnoRT()
        {
            List<string> listaRecursos = BuscarTiposRT();
            listaRecursos.Insert(0, "TODOS");
            pantallaReserva.SolicitarSeleccionTipoRT(listaRecursos);
        }

        public List<string> BuscarTiposRT()
        {
            List<TipoRecursoTecnologico> listaTipos = tipoRecursoTecnologicoDao.ObtenerTiposRT();
            List<string> listaNombres = new List<string>();
            foreach (TipoRecursoTecnologico tipo in listaTipos)
            {
                listaNombres.Add(tipo.MostrarTipoRT());
            }

            return listaNombres;
        }

        public void TomarSeleccionTipoRT(string seleccionado)
        {
            tipoSelect = TipoRecursoTecnologicoDao.Instancia().ObtenerTipoRecurso(seleccionado);
            ObtenerRTActivoYDelTipo();
        }

        public void ObtenerRTActivoYDelTipo()
        {
            //Obtener todos los recursos
            List<RecursoTecnologico> listaTodosRecursos = recursoTecnologicoDao.ObtenerRecursos();
            listaRecursos = new List<RecursoTecnologico>();
            List<string[]> listaDatosRecursos = new List<string[]>();

            foreach (RecursoTecnologico recurso in listaTodosRecursos)
            {
                if(recurso.EsDeTipoRTSeleccionado(tipoSelect) && recurso.EsActivo())
                {
                    listaRecursos.Add(recurso);
                    listaDatosRecursos.Add(recurso.MostrarDatosRT());
                }
            }

            OrdenarYAgruparRTPorCI();
            pantallaReserva.SolicitarSeleccionRT(listaDatosRecursos);
        }

        public void OrdenarYAgruparRTPorCI()
        {
            //Algo
        }

        public void TomarSeleccionRT(int indexSeleccionado)
        {
            recursoSeleccionado = listaRecursos[indexSeleccionado];
            ObtenerCientificoLogueado();
            ObtenerTurnosReservablesRTSeleccionado();
        }

        public void ObtenerCientificoLogueado()
        {

        }

        public void ObtenerTurnosReservablesRTSeleccionado()
        {
            DateTime hoy = ObtenerFechaHoraActual();
            AgruparYOrdenarTurnos();
            DeterminarDisponibilidadPorFecha(hoy);
            pantallaReserva.SolicitarSeleccionTurno();
        }

        public DateTime ObtenerFechaHoraActual()
        {
            return DateTime.Today;
        }

        public void ValidarPertenenciaCI()
        {

        }

        public void AgruparYOrdenarTurnos()
        {

        }

        public void DeterminarDisponibilidadPorFecha(DateTime fecha)
        {

        }

        public void TomarSeleccionTurno(int indexSeleccionado)
        {
            //turnoSeleccionado = seleccionado;
            //pantallaReserva.SolicitarConfirmacionReservaRT(recursoSeleccionado.MostrarDatosRT(), tipoSelect, recursoSeleccionado.MostrarDatosRT());
        }

        public void TomarConfirmacionReservaRT()
        {

        }

        public void GenerarReservaRTSeleccionado()
        {

        }

        public void GenerarMail()
        {

        }

        public void ObtenerEstadoReservado()
        {

        }

        public void ObtenerMailCientifico()
        {

        }

        public void FinCU()
        {

        }
    }
}
