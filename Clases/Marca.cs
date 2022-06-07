﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Implementacion.Clases
{
    class Marca
    {
        private string nombre;
        private List<Modelo> modelos;

        public Marca(string nom, List<Modelo> listaModelos)
        {
            nombre = nom;
            modelos = listaModelos;
        }

        public void SetNombre(string nom)
        {
            nombre = nom;
        }

        public string GetNombre()
        {
            return nombre;
        }

        //mostrarmodelos
    }
}
