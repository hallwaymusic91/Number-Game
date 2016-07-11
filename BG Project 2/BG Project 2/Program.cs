using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BG_Project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number from high to low!");
            int guess = -1;
            int goal;
            Random r = new Random();
            goal = r.Next(1, 101);
            while (guess!=goal)
            {
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess < goal)
                {
                    Console.WriteLine("Your guess is too low! Try again.");
                }
                else if (guess > goal)
                {
                    Console.WriteLine("Your guess is too high! Try again.");
                }
                else if (guess == goal)
                {
                    Console.WriteLine("Your answer is correct! Way to go!");
                }
            }           
        }
    }
}
