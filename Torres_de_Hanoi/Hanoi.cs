using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        /*TODO: Implementar métodos*/
        public void mover_disco(Pila a, Pila b){
            if(a.Top > b.Top && b.Top == 0){

                Disco numMover = new Disco();
                numMover = a.Pop();
                b.push(numMover);
                Console.Write("C1"+ "\n");
            }
            else if(a.Top > b.Top && b.Top != 0){

                Disco numMover = new Disco();
                numMover = b.Pop();
                a.push(numMover);
                Console.Write("C2" + "\n");
            }
            else if(a.Top < b.Top && a.Top == 0)
            {
                Disco numMover = new Disco();
                numMover = b.Pop();
                a.push(numMover);
                Console.Write("C3" + "\n");

            }
            else{

                Disco numMover = new Disco();
                numMover = a.Pop();
                b.push(numMover);
                Console.Write("C3" + "\n");
            }
        }

        public int iterativo(int n, Pila ini, Pila aux, Pila fin)
        {
            int m = 0;
            if (n % 2 == 0)
            {
                while (fin.Size != n)
                {
                    mover_disco(ini, aux);
                    m++;
                    Console.Write("Movimiento " + m + "\n");
                    Console.Write("Estado de pila Inicial: " + ini.Size + " Disco en la cima: " + ini.Top + "\n");
                    Console.Write("Estado de pila auxiliar: " + aux.Size + " Disco en la cima: " + aux.Top + "\n");
                    Console.Write("Estado de pila Final: " + fin.Size + " Disco en la cima: " + fin.Top + "\n");
                    Console.Write("\n");

                    mover_disco(ini, fin);
                    m++;
                    Console.Write("Movimiento " + m + "\n");
                    Console.Write("Estado de pila Inicial: " + ini.Size + " Disco en la cima: " + ini.Top + "\n");
                    Console.Write("Estado de pila auxiliar: " + aux.Size + " Disco en la cima: " + aux.Top + "\n");
                    Console.Write("Estado de pila Final: " + fin.Size + " Disco en la cima: " + fin.Top + "\n");
                    Console.Write("\n");

                    mover_disco(aux, fin);
                    m++;
                    Console.Write("Movimiento " + m + "\n");
                    Console.Write("Estado de pila Inicial: " + ini.Size + " Disco en la cima: " + ini.Top + "\n");
                    Console.Write("Estado de pila auxiliar: " + aux.Size + " Disco en la cima: " + aux.Top + "\n");
                    Console.Write("Estado de pila Final: " + fin.Size + " Disco en la cima: " + fin.Top + "\n");
                    Console.Write("\n");
                }
                return m;
            }
            else
            {
                while(fin.Size != n)
                {
                    mover_disco(ini, fin);
                    m++;
                    Console.Write("Movimiento " + m + "\n");
                    Console.Write("Estado de pila Inicial: " + ini.Size + " Disco en la cima: " + ini.Top + "\n");
                    Console.Write("Estado de pila auxiliar: " + aux.Size + " Disco en la cima: " + aux.Top + "\n");
                    Console.Write("Estado de pila Final: " + fin.Size + " Disco en la cima: " + fin.Top + "\n");
                    Console.Write("\n");

                    mover_disco(ini, aux);
                    m++;
                    Console.Write("Movimiento " + m + "\n");
                    Console.Write("Estado de pila Inicial: " + ini.Size + " Disco en la cima: " + ini.Top + "\n");
                    Console.Write("Estado de pila auxiliar: " + aux.Size + " Disco en la cima: " + aux.Top + "\n");
                    Console.Write("Estado de pila Final: " + fin.Size + " Disco en la cima: " + fin.Top + "\n");
                    Console.Write("\n");

                    mover_disco(aux, fin);
                    m++;
                    Console.Write("Movimiento " + m + "\n");
                    Console.Write("Estado de pila Inicial: " + ini.Size + " Disco en la cima: " + ini.Top + "\n");
                    Console.Write("Estado de pila auxiliar: " + aux.Size + " Disco en la cima: " + aux.Top + "\n");
                    Console.Write("Estado de pila Final: " + fin.Size + " Disco en la cima: " + fin.Top + "\n");
                    Console.Write("\n");

                }
                return m;
            }
        }
    }
}
