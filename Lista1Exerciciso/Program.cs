using System;
using System.Globalization;
namespace Projeto{
    class Execicio{
        static void Main(string[]args){
            //1
            // int n1 =int.Parse(Console.ReadLine());
            // int n2 =int.Parse(Console.ReadLine());

            // Console.WriteLine($"SOMA = {n1+n2}");

            //2
            // double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            // double pi = 3.14159;
            // double conta = pi * (raio*raio);

            // Console.WriteLine("A=" + conta.ToString("F4", CultureInfo.InvariantCulture));

            //3
            // string []array = Console.ReadLine().Split(" ");
            // int A = int.Parse(array[0]);
            // int B = int.Parse(array[1]);
            // int C = int.Parse(array[2]);
            // int D = int.Parse(array[3]);
            // int resultado = A * B - C *D;
            // Console.WriteLine($"DIFERENÇA = {resultado}");

            //4
            // int n = int.Parse(Console.ReadLine());
            // double horas = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            // double hr = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            // double salario = horas * hr;

            // Console.WriteLine($"NUMBER = {n}");
            // Console.WriteLine("SALARY = "+ salario.ToString("F2", CultureInfo.InvariantCulture));

            //5
            // string []array = Console.ReadLine().Split(" ");
            // int cod =int.Parse(array[0]);
            // int quantidade =int.Parse(array[1]);
            // double preco =double.Parse(array[2],CultureInfo.InvariantCulture);
            
            // string []array2 = Console.ReadLine().Split(" ");
            // int cod2 =int.Parse(array2[0]);
            // int quantidade2 =int.Parse(array2[1]);
            // double preco2 =double.Parse(array2[2],CultureInfo.InvariantCulture);

            // double result = quantidade*preco + quantidade2*preco2;
            // Console.WriteLine("VALOR TOTAL A SE PAGAR: R$ " + result.ToString("F2",CultureInfo.InvariantCulture));

            //6
            string []array= Console.ReadLine().Split(" ");
            double A = double.Parse(array[0],CultureInfo.InvariantCulture);
            double B = double.Parse(array[1],CultureInfo.InvariantCulture);
            double C = double.Parse(array[2],CultureInfo.InvariantCulture);
            double areaTriangulo = (A*C)/2;
            double areaCirculo= 3.14159 * (C*C);
            double areaTrapezio= ((A+B)*C) / 2;
            double areaQuadrado= Math.Pow(B,2);
            double areaRetangulo= A*B;
            Console.WriteLine("------------");
            Console.WriteLine("TRIANGULO: "+ areaTriangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("cIRCULO: "+ areaCirculo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZEIO: "+ areaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}