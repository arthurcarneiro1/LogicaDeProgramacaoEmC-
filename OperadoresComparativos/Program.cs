using System;

namespace Projeto{
    class Operadores{
        static void Main(string[]args){
            // comparação
            // > maior
            // < menor
            // >= maior ou igual
            // <= menor ou igual
            // == igual
            // != diferente 

            int n1 = 10;
            bool c1= n1 >10;//false
            bool c2= n1 <10;//false
            bool c3= n1 >=10;//true
            bool c4= n1 <=10;//true
            bool c5= n1 ==10;//true
            bool c6= n1 !=10;//false

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);
            Console.WriteLine(c5);
            Console.WriteLine(c6);
        }
    }
}