using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Implementacion.Clases
{
    class Estado
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Ambito { get; set; }
        public bool EsReservable { get; set; }
        public bool EsCancelable { get; set; }

    }
}
