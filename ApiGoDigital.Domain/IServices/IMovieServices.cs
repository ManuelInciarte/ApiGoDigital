using ApiGoDigital.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiGoDigital.Domain.IServices
{
    public interface IMovieServices
    {
        Task<Movie> GetLastMovie(string language);
        Task<ListMovie> GetTopRated(string language, string page, string region);
        Task<ListMovie> GetTopPopular(string language, string page, string region);
        Task<ListMovie> SearchMovie(RequestSearchMovie request);
    }
}
