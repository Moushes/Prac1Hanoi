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
;
            }
            else if(a.Top > b.Top && b.Top != 0){

                Disco numMover = new Disco();
                numMover = b.Pop();
                a.push(numMover);

            }
            else if(a.Top < b.Top && a.Top == 0){
                Disco numMover = new Disco();
                numMover = b.Pop();
                a.push(numMover);

            }
            else{

                Disco numMover = new Disco();
                numMover = a.Pop();
                b.push(numMover);
            }
        }
        public void imprimir(Pila ini, Pila aux, Pila fin,int m){
            
            Console.Write("Movimiento " + m + "\n");
            Console.Write("Pila Inicial:  " + ini.Size + " Disco en la cima: " + ini.Top + " Estado: "); imprimirPila(ini);
            Console.Write("\n");
            Console.Write("Pila auxiliar: " + aux.Size + " Disco en la cima: " + aux.Top + " Estado: "); imprimirPila(aux);
            Console.Write("\n");
            Console.Write("Pila Final:    " + fin.Size + " Disco en la cima: " + fin.Top + " Estado: "); imprimirPila(fin);
            Console.Write("\n");
            Console.Write("\n");
        }
        public void imprimirPila(Pila p){
            foreach (Disco disco in p.Elementos)
            {
                Console.Write(disco.Valor + " ");
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
                    imprimir(ini, aux, fin, m);

                    mover_disco(ini, fin);
                    m++;
                    imprimir(ini, aux, fin, m);

                    mover_disco(aux, fin);
                    m++;
                    imprimir(ini, aux, fin, m);

                }
                return m;
            }
            else
            {
                while(fin.Size != n)
                {
                    mover_disco(ini, fin);
                    m++;
                    imprimir(ini, aux, fin, m);

                    if (fin.Size == n){
                        return m;
                    }

                    mover_disco(ini, aux);
                    m++;
                    imprimir(ini, aux, fin, m);

                    mover_disco(aux, fin);
                    m++;
                    imprimir(ini, aux, fin, m);
                }
                return m;
            }
        }
    }
}
