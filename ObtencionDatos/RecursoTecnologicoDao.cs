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
        private static RecursoTecnologicoDao instancia;
        private List<RecursoTecnologico> todosRecursos;
        public RecursoTecnologicoDao()
        {
            TipoRecursoTecnologicoDao daoTipos = TipoRecursoTecnologicoDao.Instancia();
            List<string> nombresTipos = daoTipos.ObtenerNombresTRT();
            List<TipoRecursoTecnologico> listaTipos = new List<TipoRecursoTecnologico>();
            foreach (string nombre in nombresTipos)
            {
                listaTipos.Add(daoTipos.ObtenerTipoRecurso(nombre));
            }

            todosRecursos = new List<RecursoTecnologico>();
            todosRecursos.Add(new RecursoTecnologico(1, listaTipos[2], new Modelo("Yamaha")));
            todosRecursos.Add(new RecursoTecnologico(2, listaTipos[1], new Modelo("Yamaha")));
            todosRecursos.Add(new RecursoTecnologico(3, listaTipos[2], new Modelo("Munich")));
            todosRecursos.Add(new RecursoTecnologico(4, listaTipos[3], new Modelo("Berlin")));
            todosRecursos.Add(new RecursoTecnologico(5, listaTipos[0], new Modelo("Yamaha")));
            todosRecursos.Add(new RecursoTecnologico(6, listaTipos[0], new Modelo("Munich")));
            todosRecursos.Add(new RecursoTecnologico(7, listaTipos[4], new Modelo("Boston")));
            todosRecursos.Add(new RecursoTecnologico(8, listaTipos[1], new Modelo("Nisuta")));
            todosRecursos.Add(new RecursoTecnologico(9, listaTipos[2], new Modelo("Berlin")));
            todosRecursos.Add(new RecursoTecnologico(10, listaTipos[0], new Modelo("Boston")));
            
        }

        public static RecursoTecnologicoDao Instancia()
        {
            if (instancia == null)
                instancia = new RecursoTecnologicoDao();

            return instancia;
        }

        public List<RecursoTecnologico> ObtenerRecursos()
        {
            return todosRecursos;
        }
    }
}
