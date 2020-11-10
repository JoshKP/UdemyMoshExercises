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
            // 1 Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). Depending on the number of names provided, display a message based on the above pattern.
            string input;
            List<string> names = new List<string>();
            while (true)
            {
                Console.WriteLine("Please enter names or press enter");
                input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    names.Add(input);
                    continue;
                }
                break;
            }

            if (names.Count == 1)
            {
                Console.WriteLine(names[0] + " likes your post.");
            }
            else if (names.Count == 2)
            {
                Console.WriteLine(names[0] + " " + names[1] + " likes your post.");
            }
            else if (names.Count > 2)
            {
                Console.WriteLine($"{names[0]} and {names[1]} and {names.Count - 2} others like your post");
            }


            // 2- Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. Display the reversed name on the console.

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            char[] reverse = name.ToCharArray();
            Array.Reverse(reverse);
            string eman = string.Concat(reverse);
            Console.WriteLine(eman);



            List<int> numbers = new List<int>();
            while (true)
            {
                Console.WriteLine("Enter a number");
                int userNumber = Int32.Parse(Console.ReadLine());
                if (!numbers.Contains(userNumber))
                {
                    numbers.Add(userNumber);
                    if (numbers.Count == 5)
                        break;
                    continue;
                }
                Console.WriteLine("Wrong");
            }
            numbers.Sort();
            string nickTry = string.Join(", ", numbers);
            Console.WriteLine(nickTry);
            Console.ReadLine();


            List<int> allNumbers = new List<int>();

            while (true)
            {
                Console.WriteLine("Enter numbers or type \"Quit\"");
                string moreNumberInput = Console.ReadLine();
                if (moreNumberInput != "Quit")
                {
                    int newNumber = Int32.Parse(moreNumberInput);
                    allNumbers.Add(newNumber);
                    continue;
                }
                break;
            }
            List<int> uniqueNumbers = new List<int>();
            for (int i = 0; i < allNumbers.Count; i++)
            {
                if (!uniqueNumbers.Contains(allNumbers[i]))
                {
                    uniqueNumbers.Add(allNumbers[i]);
                }
            }

            string anotherNewList = string.Join(", ", uniqueNumbers);
            Console.WriteLine(anotherNewList);

            while (true)
            {
                Console.WriteLine("Enter a list of comma separated numbers");
                string userList = Console.ReadLine();
                if (userList != null)
                {

                    var newUserList = userList.Split(',').ToList();
                    if (newUserList.Count >= 5)
                    {
                        newUserList.Sort();
                        Console.WriteLine($"{newUserList[0]}, {newUserList[1]}, {newUserList[2]}");
                        break;
                    }
                }
                Console.WriteLine("Invalid List");
            }

            Console.ReadLine();







            Console.ReadLine();

















        }
    }
}
