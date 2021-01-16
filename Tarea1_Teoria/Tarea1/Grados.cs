using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea1_Teoria.Tarea1
{
    class Grados
    {
        private double celsius, fahrenheit;
        public Grados() { }
        public void convertir()
        {
            Console.Write("Digite la cantidad de grados celsius: ");
            celsius = float.Parse(Console.ReadLine());
            fahrenheit = (celsius * 1.8) + 32;
            Console.Write(celsius + "° Celsius = " + fahrenheit + "° Fahrenheit");
        }
    }
}

