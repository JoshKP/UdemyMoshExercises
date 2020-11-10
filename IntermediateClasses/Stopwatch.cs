using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IntermediateClasses
{
    public static class Stopwatch
    {
        public static DateTime StartTime { get; private set; }

        public static bool IsRunning = false;

        public static TimeSpan Duration
        {
            get
            {
                var timeSpan = DateTime.Now - StartTime;
                return timeSpan;
            }
        }

        public static void Start()
        {
            if (Stopwatch.IsRunning != true)
            {
                Stopwatch.IsRunning = true;
                Stopwatch.StartTime = DateTime.Now;
                Console.WriteLine("00:00");
            }
            else
                throw new InvalidOperationException("Timer already running.");
        }

        public static void Stop()
        {
            Stopwatch.IsRunning = false;
            Console.WriteLine(Duration);
        }

    }
}

