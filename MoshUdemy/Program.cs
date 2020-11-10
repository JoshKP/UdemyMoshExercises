using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshUdemy
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 1; i <= 100; i++)
                if (i % 3 == 0)
                    count++;
            Console.WriteLine(count);


            int sum = 0;
            while (true)
            {
                Console.WriteLine("Enter a number or type \'ok\' to exit");
                var input = Console.ReadLine();

                if (input == "ok")
                    break;
                else
                {
                    var parsedInput = Int32.Parse(input);
                    sum += parsedInput;
                    Console.WriteLine(sum);
                }
            }

            Console.WriteLine("Enter a number");
            var anotherInput = Int32.Parse(Console.ReadLine());


            int total = 1;
            for (int i = 1; i <= anotherInput; i++)
            {
                total *= i;
                Console.WriteLine(i + " " + total);
            }
            Console.WriteLine(anotherInput + "! = " + total);

            Random random = new Random();

            var chosenNumber = random.Next(1, 10);
            var guesses = 4;

            while (guesses > 0)
            {
                Console.WriteLine($"Guess number {guesses} tries left");
                var input = Int32.Parse(Console.ReadLine());

                if (input == chosenNumber)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Try again");
                    guesses--;
                }
            }
            if (guesses == 0)
                Console.WriteLine("You lost");

            else
                Console.WriteLine("You won");


            Console.WriteLine("Enter a series of numbers by commas");
            string numbers = Console.ReadLine();
            var numbersList = numbers.Split(',');
            List<int> finalList = new List<int>();
            foreach (var item in numbersList)
            {
                int number = Int32.Parse(item);
                finalList.Add(number);
            }

            int max = finalList.Max();

            Console.WriteLine(max);

                

        }
    }
}
