using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 7;
            int factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;

            }
            Console.WriteLine(factorial);

        }
    }
}
