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
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Press 1 to begin timer");
            var input = Convert.ToByte(Console.ReadLine());

            if (input == 1)
                stopwatch.StartTime = DateTime.Now;

            bool run = true;

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
