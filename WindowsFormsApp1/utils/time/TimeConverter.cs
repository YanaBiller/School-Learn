using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.utils.time
{
   
    public class TimeConverter
    {
        public static int convertSecondsIntoHrs(int sec)
        {
            return (sec / 3600);
        }

        public static int convertSecondsIntoMins(int sec)
        {
            return (sec / 60);
        }
    }
}
