using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI_Implementacion.Clases;

namespace PPAI_Implementacion.ObtencionDatos
{
    class TipoRecursoTecnologicoDao
    {
        public IList<TipoRecursoTecnologico> ObtenerTiposRecursos()
        {
            IList<TipoRecursoTecnologico> listaTipos = new List<TipoRecursoTecnologico>();
            listaTipos.Add(new TipoRecursoTecnologico("Microscopio", "Ver moleculas"));
            listaTipos.Add(new TipoRecursoTecnologico("Balanza", "Medir peso"));
            listaTipos.Add(new TipoRecursoTecnologico("Telescopio", "Ver espacio exterior"));
            listaTipos.Add(new TipoRecursoTecnologico("Mechero Bunsen", "Calentar"));
            listaTipos.Add(new TipoRecursoTecnologico("Pipetas", "Almacenar liquidos"));

            listaTipos.Insert(0, new TipoRecursoTecnologico("TODOS", "todos los tipos"));

            return listaTipos;
        }

    }
}
