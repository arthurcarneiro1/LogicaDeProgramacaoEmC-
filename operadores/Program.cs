using System;

namespace Operadores{
    class Basico{
        static void Main(string[] args){
            int n = 10;
            n+=10; //atribuiu mais 10
            Console.WriteLine(n);
            n-=1;
                 Console.WriteLine(n);
            n*=2;
        
            Console.WriteLine(n);

            int contador = 0;
            ++contador;
                 Console.WriteLine(contador);
            --contador;
                 Console.WriteLine(contador);
        }
    }
}
