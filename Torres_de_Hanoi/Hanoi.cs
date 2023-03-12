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
            if(a.Top > b.Top){
                Disco numMover = new Disco();
                numMover = a.Pop();
                b.push(numMover);
                //b.push(a.Pop());
            }
            else{
                Disco numMover = new Disco();
                numMover = b.Pop();
                a.push(numMover);

                //a.push(b.Pop());
            }
        }

        public int iterativo(int n, Pila ini, Pila aux, Pila fin){
            int m = 0;
            if (n % 2 == 0) {
                while(fin.Size != 3){
                    mover_disco(ini, fin);
                    m = m + 1;
                    mover_disco(ini, aux);
                    m = m + 1;
                    mover_disco(aux, fin);
                    m = m + 1;
                }
                return m;
            }
            else {
                while (fin.Size != 3) {
                    mover_disco(ini, aux);
                    m = m + 1;
                    mover_disco(ini, fin);
                    m = m + 1;
                    mover_disco(aux, fin);
                    m = m + 1;
                }
                return m;
            }
        }
    }
}
