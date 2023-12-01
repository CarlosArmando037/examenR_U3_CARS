using RecuperacionU3_CARS.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperacionU3_CARS.Clases
{
    public class Nodo
    {
        public Carros _Carros;
        public Nodo _Siguiente;

        public Nodo(Carros carros)
        {
            _Carros = carros;
            _Siguiente = null;
        }
        public Nodo(Carros carros, Nodo siguiente)
        {
            _Carros = carros;
            _Siguiente = siguiente;
        }

        public Carros carros { get { return _Carros; } set{ _Carros = value; } }
        public Nodo siguiente { get { return _Siguiente; } set { _Siguiente = value; } }

    }
}
