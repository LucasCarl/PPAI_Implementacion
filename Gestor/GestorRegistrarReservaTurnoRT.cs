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
        private List<Turno> listaTurnos;
        private List<Turno> listaTurnosFecha;
        private Turno turnoSeleccionado;
        private PersonalCientifico cientificoLogueado;

        private TipoRecursoTecnologicoDao tipoRecursoTecnologicoDao;
        private RecursoTecnologicoDao recursoTecnologicoDao;
        private EstadoDao estadoDao;

        public GestorRegistrarReservaTurnoRT(PantallaRegistrarReservaTurnoRT pantalla)
        {
            pantallaReserva = pantalla;
            tipoRecursoTecnologicoDao = TipoRecursoTecnologicoDao.Instancia();
            recursoTecnologicoDao = RecursoTecnologicoDao.Instancia();
            estadoDao = EstadoDao.Instancia();
        }

        public void RegistrarReservaTurnoRT()
        {
            //Obtiene Lista con los tipos de recurso
            List<string> listaRecursos = BuscarTiposRT();
            //Añade la opcion de TODOS al inicio
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

            //Filtrar todos los recursos para obtener los activos y del tipo seleccionado
            foreach (RecursoTecnologico recurso in listaTodosRecursos)
            {
                if(recurso.EsDeTipoRTSeleccionado(tipoSelect) && recurso.EsActivo())
                {
                    listaRecursos.Add(recurso);
                    listaDatosRecursos.Add(recurso.MostrarDatosRT());
                }
            }

            OrdenarYAgruparRTPorCI(listaDatosRecursos);
            pantallaReserva.SolicitarSeleccionRT(listaDatosRecursos);
        }

        public void OrdenarYAgruparRTPorCI(List<string[]> listaDatos)
        {
            listaDatos.Sort((x, y) => x[1].CompareTo(y[1]));
            listaRecursos.Sort((x, y) => x.ObtenerCI().GetNombre().CompareTo(y.ObtenerCI().GetNombre()));
        }

        public void TomarSeleccionRT(int indexSeleccionado)
        {
            recursoSeleccionado = listaRecursos[indexSeleccionado];
            ObtenerTurnosReservablesRTSeleccionado();
        }

        public PersonalCientifico ObtenerCientificoLogueado()
        {
            return UsuarioDao.Instancia().GetSesionActual().ObtenerCientificoLogueado();
        }

        public void ObtenerTurnosReservablesRTSeleccionado()
        {
            listaTurnos = recursoSeleccionado.GetTurnos();
            cientificoLogueado = ObtenerCientificoLogueado();
            bool mismoCientro = ValidarPertenenciaCI(cientificoLogueado);  //Cambio EN secuencia, estos 2 metodos dsp de obtenerTurnosReservables
            DateTime hoy = ObtenerFechaHoraActual();
            AgruparYOrdenarTurnos();

            List<string[]> turnosFecha = DeterminarDisponibilidadPorFecha(hoy);
            pantallaReserva.SolicitarSeleccionTurno(turnosFecha);
        }

        public DateTime ObtenerFechaHoraActual()
        {
            return DateTime.Today;
        }

        public bool ValidarPertenenciaCI(PersonalCientifico cientifico)
        {
            return recursoSeleccionado.EsCientificoDelCI(cientifico);
        }

        public void AgruparYOrdenarTurnos()
        {
            listaTurnos.Sort((x,y) => x.GetFechaInicio().CompareTo(y.GetFechaInicio()));
        }

        public List<string[]> DeterminarDisponibilidadPorFecha(DateTime fecha)
        {
            listaTurnosFecha = listaTurnos.FindAll(turno => turno.GetFechaInicio().Date == fecha.Date);
            List<string[]> datosTurnos = new List<string[]>();
            foreach (Turno turno in listaTurnosFecha)
            {
                datosTurnos.Add(turno.MostrarTurno());
            }

            return datosTurnos;
        }

        public void TomarSeleccionTurno(int indexSeleccionado)
        {
            turnoSeleccionado = listaTurnosFecha[indexSeleccionado];
            pantallaReserva.SolicitarConfirmacionReservaRT(recursoSeleccionado.MostrarDatosRT(), recursoSeleccionado.GetTipo().GetNombre(), turnoSeleccionado.MostrarTurno());
        }

        public void TomarConfirmacionReservaRT(bool mail, bool wsp)
        {
            GenerarReservaRTSeleccionado(mail, wsp);
        }

        public void GenerarReservaRTSeleccionado(bool mail, bool wsp)
        {
            //Poner turno en reservado
            Estado estadoReservado = ObtenerEstadoReservado();
            //recursoSeleccionado.RegistrarReservaTurno();  Al pedo ir al recurso si ya tengo el turno
            turnoSeleccionado.ReservarTurno(estadoReservado);
            recursoSeleccionado.ObtenerCI().AsignarTurno(cientificoLogueado, turnoSeleccionado);


            //Notificar a cientifico
            string emailCientifico = ObtenerMailCientifico();
            if(mail)
                GenerarMail(cientificoLogueado.ObtenerMail());

            if (wsp)
                GenerarWhatsapp(cientificoLogueado.ObtenerTelefono());

            FinCU();
        }

        public void GenerarMail(string email)
        {
            new InterfazMailReserva().EnviarNotificacionMail(email);
        }

        public void GenerarWhatsapp(string telefono)
        {
            new InterfazWhatsappReserva().EnviarNotificacionWhatsapp(telefono);
        }

        public Estado ObtenerEstadoReservado()
        {
            List<Estado> estados = estadoDao.GetEstados();
            List<Estado> estadosAmbitoTurno = new List<Estado>();
            Estado reservado = null;
            foreach (Estado estado in estados)
            {
                if (estado.EsAmbitoTurno())
                    estadosAmbitoTurno.Add(estado);
            }

            foreach (Estado estado in estadosAmbitoTurno)
            {
                if(estado.EsReservado())
                {
                    reservado = estado;
                    break;
                }
            }
            return reservado;
        }

        public string ObtenerMailCientifico()
        {
            return cientificoLogueado.ObtenerMail();
        }

        public void FinCU()
        {
            pantallaReserva.MensajeCUFin();
        }
    }
}
