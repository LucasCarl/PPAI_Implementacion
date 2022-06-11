using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Implementacion.Clases
{
    class CentroDeInvestigacion
    {
        public string nombre;
        /*
        public string sigla;
        public string direccion;
        public string edificio;
        public int piso;
        public string coordenadas;
        public string telefonosContacto;
        public string correoElectronico;
        */
        public DateTime fechaAlta;
        public int tiempoAntelacionReserva;
        public DateTime fechaBaja;
        public List<AsignacionCientificoDelCI> cientificos;
        public List<RecursoTecnologico> recursosTecnologicos;

        public string MostrarNombre()
        {
            return nombre;
        }

        public bool EsCientificoActivo(PersonalCientifico cientifico)
        {
            return true;
        }
    }
}
