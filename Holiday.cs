using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HolidayGroupProject
{
    class Holiday
    {
        public string _nameOfHoliday { get; private set; }
        public int _dayOfHoliday { get; private set; }
        public string _monthOfHoliday { get; private set; }
        Holiday[] _holidayArray;

        public Holiday(string nameOfHoliday,int dayOfHoliday,string monthOfHoliday)
        {
            _nameOfHoliday = nameOfHoliday; 
            _dayOfHoliday = dayOfHoliday;
            _monthOfHoliday = monthOfHoliday;
        }

        public void inSameMonth(Holiday secondHoliday )
        {
            if (this._monthOfHoliday.ToLower() == secondHoliday._monthOfHoliday.ToLower())
            {
                Console.WriteLine("true");
            }

            else { Console.WriteLine("false"); }
        }

        public void avgDate(params Holiday[] holidayArray)
        {
            _holidayArray = holidayArray;
            int sumOfHolidayDay = 0;
            double avg = 0.00d;
            int n = _holidayArray.Length;
            foreach (var i in holidayArray)
            {
                sumOfHolidayDay += i._dayOfHoliday;
            }

            avg = (Convert.ToDouble(sumOfHolidayDay)) / n;
            Console.WriteLine($"This is the average of the Days there are Holidays : {avg}");
           
        }


    }
}
