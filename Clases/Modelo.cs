using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Implementacion.Clases
{
    class Modelo
    {
        private string nombre;

        public Modelo(string nom)
        {
            nombre = nom;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public string MostrarModelo()
        {
            return GetNombre();
        }
    }
}
