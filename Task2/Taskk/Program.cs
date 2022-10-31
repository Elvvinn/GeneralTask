using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taskk
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num = 9;
            int count = 0;

            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }

                if (count > 2)
                {
                    Console.WriteLine("Eded murekkedbdir");

                }
                else
                {

                    Console.WriteLine("Eded Sadedir");

                }



            }





        }
    }
}
