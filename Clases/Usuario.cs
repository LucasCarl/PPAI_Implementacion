using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Implementacion.Clases
{
    class Usuario
    {
        private string clave;
        private string nombreUsuario;
        private bool habilitado;

        public PersonalCientifico ObtenerCientifico()
        {
            return new PersonalCientifico("a@utn.frc.edu.ar", "351836452", new Usuario());
        }
    }
}
