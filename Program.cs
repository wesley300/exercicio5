using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;

            for (a = 1; a <= 100; a++)
            {
                if (a % 2 == 0)
                {
                    Console.WriteLine(a);
                }
            }

            Console.ReadKey();
        }
    }
}
