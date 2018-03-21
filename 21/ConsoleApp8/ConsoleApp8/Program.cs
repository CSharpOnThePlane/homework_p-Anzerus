using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            LoginFrorm();

        }
        static void LoginFrorm()
        {
            string login = "Packman";
            string password = "omnomnom";
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Введи логин");
                string loginanswer = Console.ReadLine();
                Console.WriteLine("ПАРОЛЬ БЫРО");
                string passwordanswer = Console.ReadLine();
                if (password == passwordanswer && login == loginanswer)
                {
                    Welcome();
                    break;
                }
                else
                {
                    Console.WriteLine("у тебя ещё пару попыток или за тобой придут" + (3 - i) + "- не так уж и много");

                }
            }

        }
        static void Welcome()
        {
            Console.WriteLine("Добро пожаловать");
        }
         



    }





}
