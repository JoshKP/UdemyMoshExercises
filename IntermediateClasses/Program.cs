using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 to begin timer\n" +
                "Press 2 to stop/lap timer\n" +
                "Press 3 to exit");

            bool timerStart = true;
            while (timerStart)
            {
                int input = Convert.ToByte(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Stopwatch.Start();
                        break;
                    case 2:
                        Stopwatch.Stop();
                        break;
                    case 3:
                        timerStart = false;
                        break;
                    default:
                        break;

                }
            }
        }
    }
}
