using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI_Implementacion.ObtencionDatos;

namespace PPAI_Implementacion.Clases
{
    class Usuario
    {
        private string clave;
        private string nombreUsuario;
        private bool habilitado;

        public PersonalCientifico ObtenerCientifico()
        {
            return PersonalCientificoDao.Instancia().ObtenerCientifico(this);
        }
    }
}
