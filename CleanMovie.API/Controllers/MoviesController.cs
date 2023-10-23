using CleanMovie.Application;
using CleanMovie.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanMovie.API.Controllers
{
    [Route ("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _service;

        public MoviesController (IMovieService service)
        {
            _service = service;
        }
        [HttpGet]

        public ActionResult <List<Movie>> Get()
        {
            var moviesFormService = _service.GetAllMovies();
            return Ok(moviesFormService);
        }
    }
}
