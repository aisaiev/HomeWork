using System.Collections.Generic;

namespace Movie_DB.Models
{
    public class Director
    {
        public int DirectorId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }


        public List<MovieDirection> MovieDirections { get; set; }
    }
}
