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
            Console.Write("Escribe el número de discos para la pila inicial: ");
            String userInput = Console.ReadLine();  //Leer lo que escribe el usuario
            int userInputNum = Int32.Parse(userInput);  //Transforma el string a int y lo guarda

            Pila pilaI = new Pila(userInputNum);
            Pila pilaM = new Pila();
            Pila pilaF = new Pila();

            int movimientos;

            Hanoi hanoi = new Hanoi();
            movimientos = hanoi.iterativo(userInputNum, pilaI, pilaM, pilaF);
            Console.Write(movimientos);

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
