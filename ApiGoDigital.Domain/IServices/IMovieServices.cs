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
        Task<Movie> GetLastMovie();
        Task<TopRated> GetTopRated(string page);
    }
}
