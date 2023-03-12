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
            if(a.Top < b.Top){
                b.push(a.pop());
            }
            else{
                a.push(b.pop());
            }
        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux){
            int m = 0;
            if(n %2 == 0){
                while (fin.Valor != 3) { 
                    mover_disco(ini, fin);
                    m = m + 1;
                    mover_disco(ini, aux);
                    m = m + 1;
                    mover_disco(aux, fin);
                    m = m + 1;
                }
            }
            else{
                while (fin.Valor != 3){
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
