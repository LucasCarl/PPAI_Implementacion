using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Implementacion.Clases
{
    class Caracteristica
    {
        private string nombre;
        private string descripcion;

        public Caracteristica(string nom, string desc)
        {
            nombre = nom;
            descripcion = desc;
        }

        public void SetNombre(string nom)
        {
            nombre = nom;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public void SetDescripcion(string desc)
        {
            descripcion = desc;
        }

        public string GetDescripcion()
        {
            return descripcion;
        }
    }
}
