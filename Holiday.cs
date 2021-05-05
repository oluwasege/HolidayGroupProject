using System;
using System.Collections.Generic;
using System.Text;

namespace HolidayGroupProject
{
    class Holiday
    {
        public string _nameOfHoliday { get; private set; }
        public int _dayOfHoliday { get; private set; }
        public string _monthOfHoliday { get; private set; }

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

        public void avgDate(Holiday[] Holiday)
        {

        }


    }
}
