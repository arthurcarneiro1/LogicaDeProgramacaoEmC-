using System;
using System.Globalization;

namespace Curso{
    class Programa{
        static void Main(string[] args){
            string produto1 = "computador";
            string produto2 = "Mesa de escritorio";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1=2100.0;
            double preco2= 650.50;
            double medida = 53.234567;
            
            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo o peço é {preco1}");
            Console.WriteLine($"{produto2}, cujo o preço é {preco2}");
            Console.WriteLine($"Registro: {idade} anos de idade, codigo {codigo} e genro {genero}");
           Console.WriteLine($"Medida de 8 casas decimais {medida:F8}");
           Console.WriteLine($"Medida de 8 casas decimais {medida:F3}");
           Console.WriteLine("Separador decimal invarant colture:"+ medida.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}