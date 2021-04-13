using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoDisney_.Metodos_list.Pila
{
    class NodoPila
    {

        public object elemento;
        public NodoPila siguiente;

        public NodoPila() 
        {
        }


        public NodoPila(object x)
        {
            elemento = x;
            siguiente = null;
        }


    }
}
