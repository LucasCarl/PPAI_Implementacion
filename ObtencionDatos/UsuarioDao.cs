using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI_Implementacion.Clases;

namespace PPAI_Implementacion.ObtencionDatos
{
    class UsuarioDao
    {
        private static UsuarioDao instancia;
        private List<Usuario> listaUsuario;
        private Sesion actual;

        public UsuarioDao()
        {
            listaUsuario = new List<Usuario>();
            listaUsuario.Add(new Usuario());
            listaUsuario.Add(new Usuario());
            listaUsuario.Add(new Usuario());
        }

        public static UsuarioDao Instancia()
        {
            if (instancia == null)
                instancia = new UsuarioDao();

            return instancia;
        }

        public List<Usuario> GetUsuarios()
        {
            return listaUsuario;
        }

        public void SetSesionActual(Sesion sesActual)
        {
            actual = sesActual;
        }

        public Sesion GetSesionActual()
        {
            return actual;
        }
    }
}
