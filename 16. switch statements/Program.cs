using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.switch_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 and 4");
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Console.WriteLine("you entered 1");
                    break;
                case 2:
                    Console.WriteLine("you entered 2");
                    break;
                case 3:
                    Console.WriteLine("you entered 3");
                    break;
                case 4:
                    Console.WriteLine("you entered 4");
                    break;
                default: Console.WriteLine("you broke the rules ");
                    break;
            }

            Console.ReadLine();
        }
    }
}
