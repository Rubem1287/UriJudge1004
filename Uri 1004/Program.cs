using System;

namespace Uri_1004
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, prod;

            Console.WriteLine();
            Console.Write("Digite o primeiro número : ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Digite o Segundo número : ");
            b = int.Parse(Console.ReadLine());

            prod = a * b;

            Console.WriteLine();
            Console.Write("PROD = "+prod);



        }



    }
}
