using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoDisney_.Metodos_list.Lista_simple
{
    class Lista
    {

        public NodoLista primero;

        public Boolean listaVacia()
        {
            return primero == null;
        }
        //Insertar a la lista
        public Lista insertar(object vDato)
        {
            NodoLista nuevo;
            nuevo = new NodoLista(vDato);
            nuevo.enlace = primero;
            primero = nuevo;
            return this;
        }
        //Buscar los elementos de la lista
        public NodoLista buscarLista()
        {
            NodoLista indice;
            for (indice = primero; indice != null; indice = indice.enlace)
            {

                return indice;

            }

            return indice;
        }


        public object cimaLista()
        {
            if (listaVacia())
            {
                throw new Exception("Pila vacia, no se puede leer ningun elemento");
            }

            return primero.dato;
        }


        //Eliminar de la lista

        public object eliminar()
        {
            object aux;
            try
            {
                if (!listaVacia())
                {
                    aux = primero.dato;
                    primero = primero.enlace;
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
        public void eliminar(object entrada)
        {
            NodoLista actual, anterior;
            Boolean encontrado;
            //inicializa los apuntadores
            actual = primero;
            anterior = null;
            encontrado = false;
            // búsqueda del nodo y del anterior
            while ((actual != null) && (!encontrado))
            {
                encontrado = (actual.dato == entrada);
                //con objetos: actual.dato.equals(entrada)
                if (!encontrado)
                {
                    anterior = actual;
                    actual = actual.enlace;
                }
            }
            // Enlace del nodo anterior con el siguiente
            if (actual != null)
            {
                // Distingue entre que el nodo sea el cabecera,
                // o del resto de la lista
                if (actual == primero)
                {
                    primero = actual.enlace;
                }
                else
                {
                    anterior.enlace = actual.enlace;
                }
                actual = null; // no es necesario al ser una variable local
            }
        }
    }
}
