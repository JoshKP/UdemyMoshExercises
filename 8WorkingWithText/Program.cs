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
            // 1- Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".

            Console.WriteLine("Enter several numbers separated by hyphens");
            string input = Console.ReadLine();



            List<string> inputList = new List<string>();
            List<string> orderedList = new List<string>();
            List<string> reverseList = new List<string>();

            inputList = input.Split('-').ToList();
            foreach (string number in inputList)
            {
                inputList.Sort();
                orderedList.Add(number);
            }
            foreach (string number in orderedList)
            {
                orderedList.Reverse();
                reverseList.Add(number);
            }
            if (inputList == orderedList || inputList == reverseList)
            {
                Console.WriteLine("Consecutive");
            }
            else
                Console.WriteLine("Not Consecutive");



           
        }
    }
}
