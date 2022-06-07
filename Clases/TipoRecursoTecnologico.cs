using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Implementacion.Clases
{
    class TipoRecursoTecnologico
    {
        private string nombre;
        private string descripcion;
        private List<Caracteristica> caracteristicas;

        public TipoRecursoTecnologico(string nom, string desc, List<Caracteristica> listaCaract)
        {
            nombre = nom;
            descripcion = desc;
            caracteristicas = listaCaract;
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
