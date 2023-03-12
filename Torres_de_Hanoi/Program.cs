using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {

            Pila pilaI(3);
            Pila pilaM();
            Pila pilaF();
            int movimientos;
            Hanoi hanoi = new Hanoi();
            movimientos = hanoi(3, pilaI, pilaM, pilaF);
            Console.Write(movimientos);

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
