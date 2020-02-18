using System.Collections.Generic;

namespace Movie_DB.Models
{
    public class Reviewer
    {
        public int ReviewerId { get; set; }

        public string Name { get; set; }


        public List<Rating> Ratings { get; set; }
    }
}
