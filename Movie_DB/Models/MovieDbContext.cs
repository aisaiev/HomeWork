using Microsoft.EntityFrameworkCore;

namespace Movie_DB.Models
{
    class MovieDbContext : DbContext
    {
        public DbSet<Actor> Actors { get; set; }

        public DbSet<Director> Directors { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<MovieCast> MovieCasts { get; set; }

        public DbSet<MovieDirection> MovieDirections { get; set; }

        public DbSet<MovieGenre> MovieGenres { get; set; }

        public DbSet<Rating> Ratings { get; set; }

        public DbSet<Reviewer> Reviewers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Database=MovieDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor>()
                .Property(actor => actor.FirstName)
                .HasMaxLength(20);
            modelBuilder.Entity<Actor>()
                .Property(actor => actor.LastName)
                .HasMaxLength(20);
            modelBuilder.Entity<Actor>()
                .Property(actor => actor.Gender)
                .HasMaxLength(1);
            modelBuilder.Entity<Actor>()
                .HasMany<MovieCast>(actor => actor.MovieCasts)
                .WithOne(movieCast => movieCast.Actor);

            modelBuilder.Entity<Director>()
                .Property(director => director.FirstName)
                .HasMaxLength(20);
            modelBuilder.Entity<Director>()
                .Property(director => director.LastName)
                .HasMaxLength(20);
            modelBuilder.Entity<Director>()
                .HasMany<MovieDirection>(director => director.MovieDirections)
                .WithOne(movieDirection => movieDirection.Director);

            modelBuilder.Entity<Genre>()
                .Property(genre => genre.Title)
                .HasMaxLength(20);
            modelBuilder.Entity<Genre>()
                .HasMany<MovieGenre>(genre => genre.MovieGenres)
                .WithOne(movieGenre => movieGenre.Genre);

            modelBuilder.Entity<Reviewer>()
                .Property(reviewer => reviewer.Name)
                .HasMaxLength(30);
            modelBuilder.Entity<Reviewer>()
                .HasMany<Rating>(reviewer => reviewer.Ratings)
                .WithOne(rating => rating.Reviewer);

            modelBuilder.Entity<Movie>()
                .Property(movie => movie.Title)
                .HasMaxLength(50);
            modelBuilder.Entity<Movie>()
                .Property(movie => movie.Language)
                .HasMaxLength(50);
            modelBuilder.Entity<Movie>()
                .Property(movie => movie.RelCountry)
                .HasMaxLength(5);
            modelBuilder.Entity<Movie>()
                .HasMany<MovieCast>(movie => movie.MovieCasts)
                .WithOne(movieCast => movieCast.Movie);
            modelBuilder.Entity<Movie>()
                .HasMany<MovieDirection>(movie => movie.MovieDirections)
                .WithOne(movieDirection => movieDirection.Movie);
            modelBuilder.Entity<Movie>()
                .HasMany<MovieGenre>(movie => movie.MovieGenres)
                .WithOne(movieGenre => movieGenre.Movie);
            modelBuilder.Entity<Movie>()
                .HasMany<Rating>(movie => movie.Ratings)
                .WithOne(rating => rating.Movie);

            modelBuilder.Entity<MovieCast>()
                .HasKey(movieCast => new { movieCast.MovieId, movieCast.ActorId });

            modelBuilder.Entity<MovieGenre>()
                .HasKey(movieGenre => new { movieGenre.MovieId, movieGenre.GenreId });

            modelBuilder.Entity<MovieDirection>()
                .HasKey(movieDirection => new { movieDirection.MovieId, movieDirection.DirectorId });

            modelBuilder.Entity<Rating>()
                .HasKey(rating => new { rating.MovieId, rating.ReviewerId });
        }
    }
}
