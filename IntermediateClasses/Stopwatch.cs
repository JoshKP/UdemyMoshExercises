using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IntermediateClasses
{
    public class Stopwatch
    {
        public Stopwatch() { }
        
        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public TimeSpan Duration
        {
            get
            {
                var timeSpan = DateTime.Now - StartTime;
                return timeSpan;
            }
        }

    }

    //public Person(DateTime birtdate)
    //{
    //    Birthdate = Birthdate;
    //}
    //public DateTime Birthdate { get; set; }

    //public int Age
    //{
    //    get
    //    {
    //        var timeSpan = DateTime.Today - Birthdate;
    //        var years = timeSpan.Days/365;

    //        return years;
    //    }
    //}



}

