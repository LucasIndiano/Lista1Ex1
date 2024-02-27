using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("Digite o Primeiro Número: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Segundo Número: ");
            b = int.Parse(Console.ReadLine());

            int soma = a + b;

            if (soma < 10)
            {
                soma = soma - 7;
                Console.WriteLine(soma);
            }
            else {
                soma = soma + 5;
                Console.WriteLine(soma); }

            Console.ReadKey();
         }
    }
}
