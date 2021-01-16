using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea1_Teoria.Tarea1
{
    class ParOImpar
    {
        private int num;
        public ParOImpar() { }
        public void esParOImpar()
        {
            Console.Write("Digite el numero: ");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
                Console.WriteLine("Es par");
            else
                Console.WriteLine("Es impar");
        }

    }
}

