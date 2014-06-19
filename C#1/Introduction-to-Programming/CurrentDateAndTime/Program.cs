using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrentDateAndTime
{
    class DataTimeNow
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine("The current date and time: {0:MM/dd/yyyy hh:mm:ss.ff}",now);
        }
    }
}
