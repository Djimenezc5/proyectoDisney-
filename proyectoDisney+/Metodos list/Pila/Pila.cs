using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoDisney_.Metodos_list.Pila
{
    class Pila
    {

        NodoPila cima;

        //Constructor de la pila vacia
        public Pila()
        {
            cima = null;
        }
        //Verificacion del estado de la pila
        public Boolean pilaVacia()
        {
            return cima == null;
        }
        //Insertar a la pila
        public void insertar(object elemento)
        {
            NodoPila nuevo;
            nuevo = new NodoPila(elemento);
            nuevo.siguiente = cima;
            cima = nuevo;
        }
        //Limpiar pila
        public void limpiarPila()
        {
            NodoPila t;

            while (!pilaVacia())
            {
                t = cima;
                cima = cima.siguiente;
                t.siguiente = null;
            }
        }

        //Quitar un elemento
        public object quitalPila()
        {
            object aux;
            try
            {
                if (!pilaVacia())
                {
                    aux = cima.elemento;
                    cima = cima.siguiente;
                }
                else
                {
                    throw new Exception("No se puede eliminar de una pila vacia");
                }
            }
            catch (Exception)
            {

                aux = null;
            }
            return aux;
        }

        //Cima de la pila
        public object cimaPila()
        {
            if (pilaVacia())
            {
                throw new Exception("Pila vacia, no se puede leer ningun elemento");
            }

            return cima.elemento;
        }



    }
}
