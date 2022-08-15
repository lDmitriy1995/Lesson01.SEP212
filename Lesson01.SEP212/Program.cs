using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01.SEP212
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string fName = "Dmitriy";
            //string mName = "Dotsenko";


            //Console.WriteLine(fName);
            //Console.WriteLine(mName);
            //Console.ReadLine();


            Console.Write("Введите ФИО: ");
            string userName = Console.ReadLine();


            Console.Write("Введите возраст: ");
            string userAge = Console.ReadLine();


            int currentAge = 2022;
            int userAge_ = Convert.ToInt32(userAge);

            int avalAge = currentAge - userAge_;

            if (avalAge >= 18)
            {
                Console.WriteLine("Приветствую тебя " + userName + "!");

                    }

            else
            {
                Console.WriteLine("Слишком молод ");

            }


            Console.ReadLine();
            Console.WriteLine("Прииветствую  тебя " + userName + "!");


        }
    }
}
