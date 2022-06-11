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
        private string tipoSelect;
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
            List<string> listaRecursos = BuuscarTiposRT();
            listaRecursos.Insert(0, "TODOS");
            pantallaReserva.SolicitarSeleccionTipoRT(listaRecursos);
        }

        public List<string> BuuscarTiposRT()
        {
            return tipoRecursoTecnologicoDao.ObtenerNombresTRT();
        }

        public void TomarSeleccionTipoRT(string seleccionado)
        {
            tipoSelect = seleccionado;
            ObtenerRTActivoYDelTipo();
        }

        public void ObtenerRTActivoYDelTipo()
        {
            //Obtener todos los recursos
            List<RecursoTecnologico> listaTodosRecursos = recursoTecnologicoDao.ObtenerRecursos();
            List<string[]> listaDatosRecursos = new List<string[]>();

            //Buscar los recursos del mismo tipo seleccionado
            listaRecursos = new List<RecursoTecnologico>();
            foreach (RecursoTecnologico recurso in listaTodosRecursos)
            {
                bool condicionTipo = (tipoSelect == "TODOS" || recurso.EsDeTipoRTSeleccionado(tipoRecursoTecnologicoDao.ObtenerTipoRecurso(tipoSelect)));
                bool condicionActivo = recurso.EsActivo();

                if(condicionTipo && condicionActivo)
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
            pantallaReserva.SolicitarConfirmacionReservaRT(recursoSeleccionado.MostrarDatosRT(), tipoSelect, recursoSeleccionado.MostrarDatosRT());
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
