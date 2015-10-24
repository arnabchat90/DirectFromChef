using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectFromChef.Utils
{
    public class DayOfWeek
    {
        
        public static Dictionary<int,string> GetWeekDictionary() {
            Dictionary<int, string> daysOfWeek = new Dictionary<int, string>(7);
            daysOfWeek.Add(1, "Monday");
            daysOfWeek.Add(2, "Tuesday");
            daysOfWeek.Add(3, "Wednesday");
            daysOfWeek.Add(4, "Thrusday");
            daysOfWeek.Add(5, "Friday");
            daysOfWeek.Add(6, "Saturday");
            daysOfWeek.Add(7, "Sunday");

            return daysOfWeek;

        }
    }
}
