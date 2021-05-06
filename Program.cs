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


            Movie casinoRoyale = new Movie("Casino Royale", "Eon Production", "PG13");

            Movie movieA = new Movie("a", "desert", "PG");
            Movie movieB = new Movie("b", "desert", "R");
            Movie movieC = new Movie("c", "desert", "PG13");
            Movie movieD = new Movie("d", "desert");
            Movie[] movieArray = { movieA, movieB, movieC, movieD };
            Movie.getPG(movieArray);




        }
    }
}
