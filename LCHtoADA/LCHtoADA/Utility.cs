using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LCHtoADA
{
    using System.IO;

    public static class Utility
    {
        public static string TestFilesDirectoryName()
        {
            string path = Directory.GetCurrentDirectory();
            DirectoryInfo directoryInfo = Directory.GetParent(path);
            DirectoryInfo x = Directory.GetParent(directoryInfo.FullName);
            x = Directory.GetParent(x.FullName);
            string y = string.Format("{0}\\TestFiles\\", x.FullName);

            return y;
        }

        public static DateTime AddWorkingDays(this DateTime date, int workingDays)
        {
            // http://stackoverflow.com/questions/4604461/c-sharp-datetime-to-add-subtract-working-days
            if (workingDays == 0 && date.IsHoliday())
                return date.AddWorkingDays(1);

            if (workingDays == 0 && !date.IsHoliday())
                return date;
            
            int direction = workingDays < 0 ? -1 : 1;
            DateTime newDate = date;
            while (workingDays != 0)
            {
                newDate = newDate.AddDays(direction);
                if (!newDate.IsHoliday())
                {
                    workingDays -= direction;
                }
            }

            return newDate;
        }

        public static bool IsHoliday(this DateTime date)
        {
            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                return true;

            // You'd load/cache from a DB or file somewhere rather than hardcode
            DateTime[] holidays = new DateTime[]
            { 
                new DateTime(2010,12,27),
                new DateTime(2010,12,28),
                new DateTime(2011,01,03),
                new DateTime(2011,01,12),
                new DateTime(2011,01,13)
            };

            return holidays.Contains(date.Date);
        }
    }
}
