namespace Movie_DB.Models
{
    public class MovieCast
    {
        public string Role { get; set; }


        public int ActorId { get; set; }

        public Actor Actor { get; set; }

        public int MovieId { get; set; }

        public Movie Movie { get; set; }
    }
}
