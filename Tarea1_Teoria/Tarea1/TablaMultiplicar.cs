using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea1_Teoria.Tarea1
{
    class TablaMultiplicar
    {
        private int num;
        public TablaMultiplicar() { }
        public void mostrarTabla()
        {
            Console.Write("Digite el numero: ");
            num = int.Parse(Console.ReadLine());

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(num + " x " + i + " = " + num * i);
            }
        }
    }
}

