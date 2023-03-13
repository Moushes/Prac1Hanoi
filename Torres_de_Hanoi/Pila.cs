using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        public int Size { get; set; }
        public int Top { get; set; }
        public List<Disco> Elementos { get; set; }

        
        /* TODO: Implementar métodos */
        public Pila()  // pila vacía
        {
            Size = 0;
            Top = 0;
            Elementos = new List<Disco>();
        }

        public Pila(int n){  //pila que dependiendo de del numero q pongas va a crear pilas de discos hasta n
            
            Size = n;
            Elementos = new List<Disco>(); 

            for(int i=n; i > 0; i--){

                Disco disco = new Disco(); //crear disco vacío
                disco.Valor = i;      // Dar valor al disco
                Elementos.Add(disco);   //Anyadir disco a la pila
            }
            Top = Elementos.Last().Valor;
        }

        public void push(Disco d){

                Elementos.Add(d);  //anyade el disco 
                Size = Elementos.Count(); // Cuenta todos los eleementos 
                Top = Elementos.Last().Valor; //selecciona el último elemento de la lista

        }

        public Disco Pop(){
            if(isEmpty()){
                Console.Write("No se puede hacer PoP a una Pila vacía ");
                return null;
            }
            else{
                Disco aux = new Disco();
                aux = Elementos.Last();

                Elementos.RemoveAt(Elementos.Count() - 1);  // Quita el último elemento de la lista
                Size = Elementos.Count();
                if(!isEmpty()){
                    Top = Elementos.Last().Valor;
                }
                else{
                    Disco nuevo = new Disco();
                    nuevo.Valor = 0;
                    Top = nuevo.Valor;
                }
                return aux;
            }
        }                

        public bool isEmpty(){
            if(Elementos.Count() == 0){
                return true;
            }
            else{
                return false;
            }
        }
    }
}