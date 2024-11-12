
using System;
using System.Globalization;

namespace Projeto{
    class Test{
        static void Main(string[] args){
            int n1 = int.Parse(Console.ReadLine());//. parse usado para converte po o readline retorna uma string
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            string[]array= Console.ReadLine().Split(" ");
            string nome = array[0];
            char sexo =  char.Parse(array[1]);
            int idade= int.Parse(array[2]);
            double altura = double.Parse(array[3], CultureInfo.InvariantCulture);

            Console.WriteLine("dados:");
            Console.WriteLine("-------------");
            Console.WriteLine($"nome {nome}");
            Console.WriteLine($"sexo {sexo}");
            Console.WriteLine($"idade {idade}");
            Console.WriteLine($"altura {altura}");


          
        }
    }
}