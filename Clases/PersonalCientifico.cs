using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Implementacion.Clases
{
    class PersonalCientifico
    {
        private int legajo;
        private string nombre;
        private string apellido;
        private int numeroDocumento;
        private string correoElectronicoInstitucional;
        private string correoElectronicoPersonal;
        private string telefonoCelular;
        private Usuario usuario;

        public string ObtenerMail()
        {
            return correoElectronicoInstitucional;
        }

        public string ObtenerTelefono()
        {
            return telefonoCelular;
        }
    }
}
