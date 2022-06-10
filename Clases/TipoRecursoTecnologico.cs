using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Implementacion.Clases
{
    class TipoRecursoTecnologico
    {
        public string Nombre { get; set; }
        private string descripcion;
        //private List<Caracteristica> caracteristicas;

        public TipoRecursoTecnologico(string nom, string desc)
        {
            Nombre = nom;
            descripcion = desc;
            //caracteristicas = listaCaract;
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
