﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp47
{
    class Program
    {
        static void Main(string[] args)
        {
            Random gen = new Random();
            for (int i = 0; i < 50;i++)
            {
               int n= gen.Next(0, 50);
                Console.Write(n + " ");
            }
        }
    }
}
