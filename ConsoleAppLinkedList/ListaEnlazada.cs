using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLinkedList
{
    public class ListaEnlazada
    {

        public bool EsCircular { get; set; } = false;
        public Nodo Inicio, Fin, Actual = null;

        public ListaEnlazada(bool esCircular)
        { 
            EsCircular = esCircular;
        }

        public void InsertarFinal(string valor)
        {
            // crear la instancia del nuevo nodo
            var añadir = new Nodo();
            añadir.Valor = valor;
            añadir.Siguiente = null;

            // es una lista vacìa ?
            if (Inicio == null)
            {
                if (EsCircular)
                {
                    añadir.Siguiente = añadir;
                    añadir.Anterior = añadir;
                }
                else
                    añadir.Anterior = null;

                Inicio = añadir;
                Fin = añadir;
            }
            else
            {
                // recorrer la lista hasta llegar al final ...
                var actual = Inicio;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                // ... para agregar el valor al final
                actual.Siguiente = añadir;
                añadir.Anterior = actual;

                Fin = añadir;
                if (EsCircular)
                {
                    Fin.Siguiente = Inicio;
                    Inicio.Anterior = añadir;
                }
            }
        }

        public void InsertarInicio(string valor)
        {
            // crear la instancia del nuevo nodo
            var añadir = new Nodo();
            añadir.Valor = valor;
            añadir.Anterior = null;
            añadir.Siguiente = Inicio;

            // es una lista vacía ?
            if (Inicio == null)
            {
                if (EsCircular)
                {
                    añadir.Anterior = añadir;
                    añadir.Siguiente = añadir;
                }
                Fin = añadir;
            }
            else
            {
                if (EsCircular)
                {
                    añadir.Anterior = Fin;
                    Fin.Siguiente = añadir;
                }
                Inicio.Anterior = añadir;
            }
            Inicio = añadir;
        }

        public void InsertarEn(string valor_en, string valor)
        {
            var actual = Inicio;
            var siguiente = Inicio;

            while (actual != null)
            {
                if (actual.Valor.ToLower() == valor_en.ToLower())
                {
                    siguiente = actual.Siguiente;

                    // crear la instancia del nuevo nodo
                    var añadir = new Nodo();
                    añadir.Valor = valor;
                    añadir.Siguiente = siguiente;
                    añadir.Anterior = actual;

                    actual.Siguiente = añadir;

                    // es al final de la lista ?
                    if (actual == Fin)
                    {
                        Fin = añadir;
                        if (EsCircular)
                        {
                            Fin.Siguiente = Inicio;
                            Inicio.Anterior = añadir;
                        }
                    }
                    else
                    {
                        siguiente.Anterior = añadir;
                    }
                    break;
                }
                actual = actual.Siguiente;
            }
        }

        public Nodo MoverPrinero()
        {
            Actual = Inicio;
            return Actual;
        }

        public Nodo MoverFin()
        {
            Actual = Fin;
            return Actual;
        }

        public Nodo MoverSiguiente()
        {
            Actual = Actual.Siguiente;
            return Actual;
        }

        public Nodo MoverAnterir()
        {
            Actual = Actual.Anterior;
            return Actual;
        }

        public void Eliminar(string valor)
        {
            Nodo anterior, actual = Inicio;

            // eliminar el 1ro
            if (Inicio.Valor.ToLower() == valor.ToLower())
            {
                Inicio = Inicio.Siguiente;
                Inicio.Anterior = null;
                anterior = null;
            }
            else // es un elemento intermedio o el final de la lista
            {
                anterior = null;
                actual = Inicio;
                while (actual != null)
                {
                    if (actual.Valor.ToLower() == valor.ToLower())
                    {
                        // eliminar
                        anterior.Siguiente = actual.Siguiente;
                        actual = null;
                        break;
                    }
                    anterior = actual;
                    actual = actual.Siguiente;
                }
            }
        }

        public void Imprimir()
        {
            var actual = Inicio;
            while (actual != null)
            {
                Console.WriteLine(actual.Valor);
                actual = actual.Siguiente;
                if (actual.Siguiente == Inicio)
                    break;
            }
        }

        public void ImprimirReverso()
        {
            var actual = Fin;
            while (actual != null)
            {
                Console.WriteLine(actual.Valor);
                actual = actual.Anterior;
                if (actual.Anterior == Fin)
                    break;
            }
        }
    }
}