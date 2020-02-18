namespace Movie_DB.Models
{
    public class Rating
    {
        public int Stars { get; set; }

        public int NumberOfRatings { get; set; }


        public int MovieId { get; set; }

        public Movie Movie { get; set; }

        public int ReviewerId { get; set; }

        public Reviewer Reviewer { get; set; }
    }
}
