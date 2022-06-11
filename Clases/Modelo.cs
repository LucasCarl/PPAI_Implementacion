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

        public string[] MostrarModelo()
        {
            string[] nombres = new string[2];
            nombres[0] = GetNombre();
            nombres[1] = "Marca";

            return nombres;
        }
    }
}
