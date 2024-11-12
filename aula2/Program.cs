using System;
using System.Globalization;
// precisa importa pra  usar o cultureinfos
namespace Curso
{
    class Aula2
    {
        static void Main(string[] args)
        {
            double saldo = 12.44444;
            // para limitar o numero de casa apos a virgula
            Console.WriteLine(saldo.ToString("F2"));
            // para fazer aparecer um ponto
            Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture));
            // saida de dados
            // interpolação
            int idade = 13;
            string nome = "Arthur";
            double saldoBancario = 200.43232;

            Console.WriteLine($"{nome} tem {idade} anos e possue um saldo de {saldoBancario:F2}");


        }


    }
}
