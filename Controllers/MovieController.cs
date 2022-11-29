using Microsoft.AspNetCore.Mvc;
using MovieAPI.Models;

namespace MovieAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        private static List<Movie> movies = new List<Movie>();
        private static int id = 1;

        [HttpPost]
        public IActionResult AddMovie([FromBody] Movie movie)
        {
            movie.Id = id++;
            movies.Add(movie);
            return CreatedAtAction(nameof(GetOneMovie), new { Id = movie.Id }, movie);
        }

        [HttpGet]
        public IActionResult GetMovie()
        {
            return Ok(movies);
        }

        [HttpGet("{id}")]
        public IActionResult GetOneMovie(int id)
        {
            Movie movie = movies.FirstOrDefault(filme => filme.Id == id);
            if (movie != null)
            {
                return Ok(movie);
            }
            return NotFound();

        }
    }
}


