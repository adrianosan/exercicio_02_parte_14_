using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_02_parte_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Digite o primeiro número.");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número.");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número.");
            c = int.Parse(Console.ReadLine());

            if (a > b && a > c && b > c)
            {
                Console.WriteLine(a + ", " + b + ", " + c);
              
            }

            else if (a > b && a > c && c > b)
            {
                Console.WriteLine(a + ", " + c + ", " + b);
            }

            else if (b > a && b > c && a > c)
            {
                Console.WriteLine(b + ", " + a + ", " + c);
            }

            else if (b > a && b > c && c > a)
            {
                Console.WriteLine(b + ", " + c + ", " + a);
            }

            else if (c > a && b > c && a > b)
            {
                Console.WriteLine(c + ", " + a + ", " + b);
            }

            else if (c > a && b > c && b > a)
            {
                Console.WriteLine(c + ", " + b + ", " + a);
            }
               
        }
    }
}

