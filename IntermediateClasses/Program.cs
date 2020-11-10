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
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("Press 1 to begin timer or 5 to quit");
                var input = Convert.ToByte(Console.ReadLine());
                Stopwatch stopwatch = new Stopwatch();

                bool run = true;

                if (input == 1)
                    stopwatch.StartTime = DateTime.Now;
                else
                {
                    isRunning = false;
                    run = false;
                }

                while (run)
                {
                    Console.WriteLine("Press 2 to lap timer or 3 to end timer");
                    var otherInput = Convert.ToByte(Console.ReadLine());

                    if (otherInput == 2)
                    {
                        stopwatch.EndTime = DateTime.Now;
                        Console.WriteLine(stopwatch.Duration);
                    }
                    else if (otherInput == 3)
                        run = false;
                }

            }







        }
    }
}
