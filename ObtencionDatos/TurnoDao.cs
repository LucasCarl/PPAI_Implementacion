using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Implementacion.ObtencionDatos
{
    class TurnoDao
    {
        private static TurnoDao instancia;

        public static TurnoDao Instancia()
        {
            if (instancia == null)
                instancia = new TurnoDao();

            return instancia;
        }

    }
}
