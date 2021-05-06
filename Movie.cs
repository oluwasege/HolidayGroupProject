using System;
using System.Collections.Generic;
using System.Text;

namespace HolidayGroupProject
{
    class Movie
    {
        public string _movieTitle { get; private set; }
        public string _moviestudio { get; private set; }
        public string _ratingOfMovie { get; private set; }
       

        public Movie(string movieTitle,string movieStudio,string ratingOfMovie)
        {
            _movieTitle = movieTitle;
            _moviestudio = movieStudio;
            _ratingOfMovie = ratingOfMovie;
        }

        

        public Movie(string movieTitle, string movieStudio)
        {
            _movieTitle = movieTitle;
            _moviestudio = movieStudio;
            _ratingOfMovie = "PG";
        }

        public static void getPG(Movie[] movies)
        {
            int count = 0;
            Movie[] moviesWithPG = new Movie[movies.Length];
            foreach (var i in movies)
            {
                if(i._ratingOfMovie.ToLower()=="pg")
                {
                    moviesWithPG[count] = i;
                    count++;
                }
                
            }
            Console.WriteLine("Here are the Movies Rated PG\n");

            for (int i = 0; i <moviesWithPG.Length ; i++)
            {
                if(moviesWithPG[i]!=null)
                {
                    Console.WriteLine($"Movie Title : {moviesWithPG[i]._movieTitle} \tProduction Studio : {moviesWithPG[i]._moviestudio} \tMovie Rating : {moviesWithPG[i]._ratingOfMovie}");
                }
            }
        }
    }
}
