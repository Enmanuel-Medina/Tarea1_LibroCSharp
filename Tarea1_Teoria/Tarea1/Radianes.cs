using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea1_Teoria.Tarea1
{
    class Radianes
    {
        private float grados, radianes;
        public Radianes() { }
        public void convertir()
        {
            Console.Write("Digite la cantidad de grados: ");
            grados = float.Parse(Console.ReadLine());
            radianes = grados / 180;
            Console.WriteLine(grados + "° = " + radianes + " radianes");
        }
    }
}
