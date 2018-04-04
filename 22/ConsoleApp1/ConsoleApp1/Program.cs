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
            
            int stoimost = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("введите стоимость");
                int cost = int.Parse(Console.ReadLine());
                if (cost > 1000)
                {
                    
                   stoimost=cost+ stoimost;
                }
            }
           
            Console.WriteLine(stoimost);
        }
        
    }
}
