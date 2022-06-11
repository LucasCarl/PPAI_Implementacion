using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI_Implementacion.Clases;

namespace PPAI_Implementacion.ObtencionDatos
{
    class TurnoDao
    {
        private static TurnoDao instancia;
        private List<Turno> listaTurnos;

        public TurnoDao()
        {
            listaTurnos = new List<Turno>();
        }

        public static TurnoDao Instancia()
        {
            if (instancia == null)
                instancia = new TurnoDao();

            return instancia;
        }

    }
}
