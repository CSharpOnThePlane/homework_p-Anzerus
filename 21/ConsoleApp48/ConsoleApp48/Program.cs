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
            int svetyear = 0;
            for (int i = 0; i < 10; i++)
            {
             
                Console.WriteLine("введите расстояние до города");
                int km = int.Parse(Console.ReadLine());
                
                if (svetyear < km)
                {
                    svetyear = km;
                }

                Console.WriteLine("расстояние до мамого удаленного города =" + svetyear);
            }
          
        }
    }
}
