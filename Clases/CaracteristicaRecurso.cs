using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Implementacion.Clases
{
    class CaracteristicaRecurso
    {
        private Caracteristica caracteristica;
        private float valor;

        public CaracteristicaRecurso(Caracteristica caract, float val)
        {
            caracteristica = caract;
            valor = val;
        }

        public void SetValor(float val)
        {
            valor = val;
        }

        public float GetValor()
        {
            return valor;
        }
    }
}
