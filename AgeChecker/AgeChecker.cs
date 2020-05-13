using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class AgeChecker
    {
        static void Main(string[] args)
        {

            Console.Write("Welcome! \n Input your full name: ");

            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

            Console.Write("Your age is: ");
           
            int num = Convert.ToInt32(Console.ReadLine());

            if (num < 18)
            {
                Console.WriteLine("You are too young to enter this site!");
            }
            else  
                Console.WriteLine("Welcome! Enjoy your stay!");

            Console.ReadLine();
        }
        
    }
}