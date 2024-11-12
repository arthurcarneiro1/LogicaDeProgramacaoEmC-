using System;
using System.Globalization;
namespace Projeto{
    class Execicio{
        static void Main(string[]args){
            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem sua casa?");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto?");
            double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Entreccom seu ultimo nome, idade e altura:");
            string []array= Console.ReadLine().Split(" ");
            string sobrenome = array[0];
            int idade = int.Parse(array[1]);
            double altura = double.Parse(array[2], CultureInfo.InvariantCulture);

            Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
            Console.WriteLine(nome);
            Console.WriteLine(n1);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(sobrenome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
            

        }
    }
}