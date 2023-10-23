using CleanMovie.Application;
using CleanMovie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Infrastructure
{
    public class MovieRepository : IMovieRepository
    {
        public static List<Movie> movies = new List<Movie>() {
            new Movie { Id = 1, Name = "God Father" , Cost = 550.0M },
            new Movie { Id = 1, Name = "Whisper of the Heart" , Cost = 550.0M },
            new Movie { Id = 1, Name = "12 Angry Men" , Cost = 550.0M },
        };
        public List<Movie> GetAllMovies()
        {
            return movies;
        }
    }
}
