using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Sequeência Fibonnaci");

            int qtd = 15;

            int a, b, c;
            a = 1;
            b = 1;

            Console.WriteLine(a);
            Console.WriteLine(b);
            for (int i = 3; i <= qtd; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(c);
            }

        }
    }
}
