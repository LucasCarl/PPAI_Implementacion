using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI_Implementacion.Clases;

namespace PPAI_Implementacion.ObtencionDatos
{
    class RecursoTecnologicoDao
    {
        private RecursoTecnologico[] todosRecursos;
        public RecursoTecnologicoDao()
        {
            IList<TipoRecursoTecnologico> listaTipos = new TipoRecursoTecnologicoDao().ObtenerTiposRecursos();
            todosRecursos = new RecursoTecnologico[10];
            todosRecursos[0] = new RecursoTecnologico(1, listaTipos[2], new Modelo("Yamaha"));
            todosRecursos[1] = new RecursoTecnologico(2, listaTipos[1], new Modelo("Yamaha"));
            todosRecursos[2] = new RecursoTecnologico(3, listaTipos[2], new Modelo("Munich"));
            todosRecursos[3] = new RecursoTecnologico(4, listaTipos[3], new Modelo("Berlin"));
            todosRecursos[4] = new RecursoTecnologico(5, listaTipos[5], new Modelo("Yamaha"));
            todosRecursos[5] = new RecursoTecnologico(6, listaTipos[5], new Modelo("Munich"));
            todosRecursos[6] = new RecursoTecnologico(7, listaTipos[4], new Modelo("Boston"));
            todosRecursos[7] = new RecursoTecnologico(8, listaTipos[1], new Modelo("Nisuta"));
            todosRecursos[8] = new RecursoTecnologico(9, listaTipos[2], new Modelo("Berlin"));
            todosRecursos[9] = new RecursoTecnologico(10, listaTipos[5], new Modelo("Boston"));
        }
    }
}
