using System;

namespace HolidayGroupProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Holiday ileya = new Holiday("ileya ya", 24,"January");
            Holiday iley = new Holiday("ileya ya", 24, "February");
            ileya.inSameMonth(iley);
            Holiday independenceDay = new Holiday("Independence Day", 1, "October");


        }
    }
}
