using System;
using System.Reflection.Metadata;

namespace Projeto{
    class OperadorLogicos{
        static void Main(string[]args){
            // operadores logicos
            // && e  as duas condiçoes para dar true
            // || ou so uma precisa
            // ! nega

            bool n1 = 10 < 3 && 7 > 10; // false
            bool n2 = 3 < 10 && 7 < 10; // true
            bool n3 =  10 < 3 || 7 < 10; // true
            bool n4 = 10 < 3 || 7 > 10; // falso
            bool n5 = !(10 < 3) && !(7 > 10); // true
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
        }
    }
}