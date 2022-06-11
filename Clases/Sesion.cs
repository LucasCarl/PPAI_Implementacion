using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Implementacion.Clases
{
    class Sesion
    {
        private DateTime fechaHoraDesde;
        private DateTime fechaHoraHasta;
        private Usuario usuario;

        public Sesion(Usuario usu)
        {
            fechaHoraDesde = DateTime.Now;
            usuario = usu;
        }

        public PersonalCientifico ObtenerCientificoLogueado()
        {
            return usuario.ObtenerCientifico();
        }
    }
}
