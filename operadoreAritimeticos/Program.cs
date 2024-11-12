// + - (* / %)
//       possuem prioridade ->

using System;

namespace Operadores{
    class Test{
        static void Main(string[]args){
            int n1 = 2 + 2 * 4;
            int n2 = (2+2) * 4; // colocar entre parenteses oque vc quer que execute primeiro
            double a= 1.0,b=-3.0,c=2.0;
            double delta= b*b - 4.0 *a*c;
            double x1= (-b+ Math.Sqrt(delta)) / (2 * a);
            double x2= (-b- Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);

        }
    }
}
