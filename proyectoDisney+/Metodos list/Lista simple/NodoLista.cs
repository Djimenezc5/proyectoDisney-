using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoDisney_.Metodos_list.Lista_simple
{
    class NodoLista
    {


        public object dato;
        public NodoLista enlace;

        public NodoLista()
        {

        }

        public NodoLista(object vDato)
        {
            dato = vDato;
            enlace = null;
        }



    }
}
