using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8WorkingWithText
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some numbers split by hyphens");
            string input = Console.ReadLine();

            var stringArray = input.Split('-');
            int[] numArray = Array.ConvertAll(stringArray, int.Parse);

            foreach (int n in numArray)
            {
                int i = Array.IndexOf(numArray, n);
                while (i <= numArray.Count()-1)
                {
                    if (numArray[i] + 1 == numArray[i + 1] || numArray[i] - 1 == numArray[i + 1])
                    {
                        i++;
                        Console.WriteLine(i);
                    }
                    Console.WriteLine("Consecutive");

                }
            }


        }
    }
}
