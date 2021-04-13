using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoDisney_.Metodos_list.Cola
{
    class NodoCola
    {
        public Object elemento;
        public NodoCola siguiente;

        public NodoCola() { 
        
        }
        public NodoCola(Object x)
        {
            elemento = x;
            siguiente = null;
        }

    }
}
