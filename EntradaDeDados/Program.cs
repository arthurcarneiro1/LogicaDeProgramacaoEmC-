using System;

namespace Projeto{
    class Test{
        static void Main(string[]args){
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
            string s = Console.ReadLine();
            string[]array=s.Split(" ");
            string a=array[0];
            string b=array[1];
            string c=array[2];
            Console.WriteLine("vc digitou:");
            Console.WriteLine("-------------");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
