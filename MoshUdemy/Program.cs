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
            // 1 
            Console.WriteLine("Enter number 1-10");
            int input = Convert.ToByte(Console.ReadLine());

            if (input > 0 && input < 11)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");

            // 2
            Console.WriteLine("Enter 2 numbers separated with a space");
            string twoNumbers = Console.ReadLine();
            var twoNumArray = twoNumbers.Split(' ');

            if (Convert.ToInt32(twoNumArray[0]) > Convert.ToInt32(twoNumArray[1]))
                Console.WriteLine(twoNumArray[0]);
            else
                Console.WriteLine(twoNumArray[1]);

            // 3
            Console.WriteLine("Enter the width and height of an image separated with a space");
            string whinput = Console.ReadLine();
            var wharray = whinput.Split(' ');

            if (Convert.ToInt32(wharray[0]) > Convert.ToInt32(wharray[1]))
                Console.WriteLine("Landscape");
            else Console.WriteLine("Portrait");

            // 4
            Console.WriteLine("Enter speed limit");
            int speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter speed of the car");
            int carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed > speedLimit)
            {
                int speedOver = carSpeed - speedLimit;
                int demeritPoints = speedOver / 5;
                if (demeritPoints <= 12)
                    Console.WriteLine(demeritPoints);
                else Console.WriteLine("License suspended");
            }
            else Console.WriteLine("Ok");
 

        }
    }
}
