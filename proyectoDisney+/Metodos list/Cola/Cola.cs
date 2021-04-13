using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoDisney_.Metodos_list.Cola
{
    class Cola
    {

        NodoCola frente;
        NodoCola fin;

        //Constructor de la cola vacia
        public Cola()
        {
            frente = fin = null;
        }

        //Verificacion del estado de la cola
        public Boolean colaVacia()
        {
            return (frente == null);
        }

        //Insertar elementos a la cola por el final
        public void insertar(Object elemento)
        {
            NodoCola a;
            a = new NodoCola(elemento);
            if (colaVacia())
            {
                frente = a;
            }
            else
            {
                fin.siguiente = a;
            }
            fin = a;
        }

        //Extraer elementos
        public object quitar()
        {
            object aux;
            try
            {
                if (!colaVacia())
                {
                    aux = frente.elemento;
                    frente = frente.siguiente;
                }
                else
                {
                    throw new Exception("No se puede eliminar de una cola vacia");
                }
            }
            catch (Exception)
            {
                aux = null;
            }
            return aux;
        }

        //Obtener el primer elemento de la cola
        public object frenteCola()
        {
            if (colaVacia())
            {
                throw new Exception("Pila vacia, no se puede leer ningun elemento");
            }

            return frente.elemento;
        }

    }
}
