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
        public async Task<Movie> GetLastMovie(string language)
        {
            return await _movieServices.GetLastMovie(language);
        }

        [HttpGet("GetTopRated")]
        public async Task<ListMovie> GetTopRated(string language, string page, string region)
        {
            return await _movieServices.GetTopRated(language, page, region);
        }
        [HttpGet("GetMostPopular")]
        public async Task<ListMovie> GetTopPopular(string language, string page, string region)
        {
            return await _movieServices.GetTopPopular(language, page, region);
        }

        [HttpPost("SearchMovie")]
        public async Task<ListMovie> SearchMovie(RequestSearchMovie request)
        {
            return await _movieServices.SearchMovie(request);
        }

        [HttpGet("GetMovieDetail/{movie_id}")]
        public async Task<Movie> GetMovieDetail(string language, string append_to_response, string movie_id)
        {
            return await _movieServices.GetMovieDetail(language, append_to_response, movie_id);
        }

    }
}
