using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 9; i++)
            {

                double g = (double)i / 10;
                Console.WriteLine("Корень из" + g+":" + Math.Sqrt(g));


            }

          
           
        }
    }
}
