using RecuperacionU3_CARS.Clases;
using RecuperacionU3_CARS.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperacionU3_CARS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carros carro = new Carros();    
            ListaSimple lista = new ListaSimple();

            Console.WriteLine("seleccione una opcion");
            Console.WriteLine("1._Salir");
            Console.WriteLine("2._insertar");
            Console.WriteLine("3._Ordenar");
            Console.WriteLine("4._Buscar");
            Console.WriteLine("5._Mostrar");

            int opcion = Convert.ToInt32(Console.ReadLine());


            while (opcion != 1)
            {
                switch (opcion)
                {
                    case 2:
                        Console.WriteLine("inserte la marca del carro");
                        carro.Marca= Console.ReadLine();
                        Console.WriteLine("inserte el modelo del carro");
                        carro.Modelo = Console.ReadLine();
                        Console.WriteLine("inserte el año de lanzamiento del carro");
                        carro.AñoLanzamiento = Convert.ToInt32(Console.ReadLine());
                        lista.InsertarInicio(carro);
                        break;
                    case 3:
                        Console.WriteLine("ordenar por año de lanzamiento");
                        lista.ordenamiento();
                        break;
                    case 4:
                        Console.WriteLine("inserte su busqueda por MARCA");
                        carro.Marca = Console.ReadLine();
                        lista.busqueda(carro.Marca);
                        break;

                    case 5:
                        Console.WriteLine("los datos son:");
                        lista.imprimir();
                        break;

                }
                Console.WriteLine("seleccione otra opcion:");
                opcion = Convert.ToInt32(Console.ReadLine());
            }

        }
    }
}
