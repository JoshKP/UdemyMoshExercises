using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 
            bool isNaming = true;
            List<string> nameList = new List<string>();

            while (isNaming)
            {
                Console.WriteLine("Enter a name");
                string name = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(name))
                {
                    nameList.Add(name);
                }
                else
                {
                    if (nameList.Count == 0)
                        isNaming = false;
                    else if (nameList.Count == 2)
                        Console.WriteLine(nameList[0] + " and " + nameList[1] + " like your post.");
                    else if (nameList.Count > 2)
                        Console.WriteLine(nameList[0] + ", " + nameList[1] + " and " + (nameList.Count - 2) + " others like your post.");
                }
            }


            // 2 
            Console.WriteLine("Enter your name");
            var nameArray = Console.ReadLine().ToArray();
            var reverseName = nameArray.Reverse();

            foreach (char c in reverseName)
            {
                Console.WriteLine(c);
            }


            // 3 
            int counter = 0;
            List<int> numberList = new List<int>();
            while (counter < 5)
            {
                Console.WriteLine("Enter a number");
                int userNumber = Convert.ToInt32(Console.ReadLine());
                if (!numberList.Contains(userNumber))
                {
                    numberList.Add(userNumber);
                    counter++;
                }
            }
            numberList.Sort();
            foreach (int n in numberList)
            {
                Console.WriteLine(n);
            }


            // 4
            List<int> newNumberList = new List<int>();

            while (true)
            {
                Console.WriteLine("Enter numbers or type \"Quit\" to exit");
                var userInput = Console.ReadLine();

                if (userInput.ToLower() == "quit")
                {
                    foreach (int n in newNumberList)
                    {
                        Console.WriteLine(n);
                    }
                    break;
                }
                else
                {
                    int number = Convert.ToInt32(userInput);
                    if (!newNumberList.Contains(number))
                    {
                        newNumberList.Add(number);
                    }
                }




                

            }
            

        }








    }
}

