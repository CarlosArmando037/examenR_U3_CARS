using RecuperacionU3_CARS.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperacionU3_CARS.Clases
{
    public class ListaSimple
    {
        public Nodo primero;
        public Nodo ultimo;

        public ListaSimple()
        {
            primero = ultimo = null;
        }

        //metodos
        public bool EsVacio()
        {
            if (primero == null)
            {
                return true;
            }
            return false;
        }

        public void InsertarInicio(Carros carro)
        {
            if (EsVacio())
            {
                primero = ultimo = new Nodo(carro);
            }
            else
            {
                primero.siguiente = new Nodo(carro,primero);
            }
        }

        public void ordenamiento()
        {
            if (EsVacio())
            {
                Console.WriteLine("la lista esta vacia");
            }
            else
            {
                Nodo actual = primero;
                while(actual != null)
                {
                    Nodo Siguiente = primero.siguiente;
                    while (Siguiente != null)
                    {
                        if (actual.carros.AñoLanzamiento < Siguiente.carros.AñoLanzamiento)
                        {
                            Nodo temp = actual;
                            actual = Siguiente;
                            Siguiente = temp;
                        }
                        else
                        Siguiente = Siguiente.siguiente;
                    }
                    actual = actual.siguiente;
                }
            }
        }

        public void busqueda(string objetivo)
        {
            if (EsVacio())
            {
                Console.WriteLine("la lista esta vacia");
            }
            else
            {
                Nodo actual = primero;
                while (actual != null)
                {
                    if (objetivo == actual.carros.Marca)
                    {
                        Console.WriteLine($"{actual._Carros.Marca},{actual._Carros.Modelo} y año {actual._Carros.Modelo}");
                    }
                    else
                    {
                        actual = actual.siguiente;
                    }
                }
            }
        }

        public void imprimir()
        {
            if (EsVacio())
            {
                Console.WriteLine("la lista esta vacia");
            }
            else
            {
                Nodo actual = primero;
                while(actual != null)
                {
                    Console.WriteLine($"el modelo del carro es: {actual._Carros.Modelo}, la marca es: {actual._Carros.Marca} y la fecha de lanzamieto es:{actual._Carros.AñoLanzamiento}");
                    actual = actual.siguiente;
                }
                //me da infinito :C
            }
        }
        public int Longitud()
        {
            int contador = 0;
            if (EsVacio()) 
            {
                return contador = 0;
            }
            else
            {
                Nodo actual = primero; 
                while(actual.siguiente != null)
                {
                    actual= actual.siguiente;
                    contador++;
                }
            }
            return contador;
        }

    }
}
