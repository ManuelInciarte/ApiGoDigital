using ApiGoDigital.DataAccess.Entities;
using ApiGoDigital.Domain.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ApiGoDigital.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        private readonly IMovieServices _movieServices;
        public MovieController(IMovieServices movieServices)
        {
            _movieServices = movieServices;
        }


        [HttpGet("GetLastMovie")]
        public async Task<Movie> GetLastMovie()
        {
            return await _movieServices.GetLastMovie();
        }

        [HttpGet("GetTopRated/{page}")]
        public async Task<TopRated> GetTopRated(string page)
        {
            return await _movieServices.GetTopRated(page);
        }
    }
}
