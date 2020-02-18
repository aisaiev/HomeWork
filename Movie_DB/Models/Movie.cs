using System;
using System.Collections.Generic;

namespace Movie_DB.Models
{
    public class Movie
    {
        public int MovieId { get; set; }

        public string Title { get; set; }

        public int Year { get; set; }

        public int Time { get; set; }

        public string Language { get; set; }

        public DateTime DateOfRelease { get; set; }

        public string RelCountry { get; set; }


        public List<MovieCast> MovieCasts { get; set; }

        public List<MovieDirection> MovieDirections { get; set; }

        public List<MovieGenre> MovieGenres { get; set; }

        public List<Rating> Ratings { get; set; }
    }
}
