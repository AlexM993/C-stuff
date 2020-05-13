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
            int[] RandomNumber = { 4, 6, 8, 56, 23 };

            Console.WriteLine("Choose a number between 0 and 5");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 5)
            {
                Console.WriteLine("Don't cheat!");
            }
            else
                Console.WriteLine("Thank you for not cheating! \nYour random number picked is: " + RandomNumber[num] + "\n\nHave a great day!");


            Console.ReadLine();
        }
    }
}