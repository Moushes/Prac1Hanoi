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
            /*if(a.Top > b.Top && b.Top == 0){  //si pila a es mayor que pila b y top de b es = 0

                Disco numMover = new Disco();  //creamos disco nuevo
                numMover = a.Pop();            //asignamos el elementos que hemos quitado de la primera pila
                b.push(numMover);              //metemos el nuevo elemento en la segunda pila
;
            }
            else if(a.Top > b.Top && b.Top != 0){ // si pila a es mayor que pila b y top de b es distinto de 0

                Disco numMover = new Disco();
                numMover = b.Pop();
                a.push(numMover);

            }
            else if(a.Top < b.Top && a.Top == 0){ // si pila a es menor que pila b y top de a es igual a 0
                Disco numMover = new Disco();
                numMover = b.Pop();
                a.push(numMover);

            }
            else if(a.Top < b.Top && a.Top != 0){
                Disco numMover = new Disco();
                numMover = a.Pop();
                b.push(numMover);
            }*/
           if(a.Top == 0 || b.Top == 0){ 
            if(a.Top < b.Top){
                    a.push(b.Pop());
            }
                else{
                    b.push(a.Pop());
                }
            
            }
            else
            {
                if (a.Top > b.Top)
                {
                    a.push(b.Pop());
                }
                else
                {
                    b.push(a.Pop());
                }

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
            if (n % 2 == 0) //si n es par
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
                while(fin.Size != n)  //si n es impar
                {
                    mover_disco(ini, fin);
                    m++;
                    imprimir(ini, aux, fin, m);

                    if (fin.Size == n){ //en este movimiento se termina el bucle con los impares, mira si la pila final está llena
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
        int mov = 0; // variable que se crea fuera pq al llamar recurivo de nuevo se resetea
        public int recursivo(int n, Pila ini, Pila aux, Pila fin){
            
            if(n == 1){
                mov = mov + 1;
                mover_disco(ini, fin);
                imprimir(ini, aux, fin, mov);
            }
            else{
                recursivo(n - 1, ini, aux, fin);
                mover_disco(ini, fin);
                mov = mov + 1;
                imprimir(ini, aux, fin, mov);
                recursivo(n - 1, aux, fin, ini);
            }
            return mov;
        }
    }
}
