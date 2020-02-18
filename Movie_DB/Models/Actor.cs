using System.Collections.Generic;

namespace Movie_DB.Models
{
    public class Actor
    {
        public int ActorId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Gender { get; set; }


        public List<MovieCast> MovieCasts { get; set; }
    }
}
