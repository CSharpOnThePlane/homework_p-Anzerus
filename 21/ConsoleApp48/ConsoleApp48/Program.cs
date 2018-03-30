using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48
{
    class Program
    {
        static void Main(string[] args)
        {
            int kolisestvo = 0;
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("введите рост");
                int rost = int.Parse(Console.ReadLine());
                if (rost>160)
                {
                    kolisestvo = kolisestvo + 1;
                    
                }
               
            }
            Console.WriteLine(kolisestvo);
        }
    }
}
