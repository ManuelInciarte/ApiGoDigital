using ApiGoDigital.DataAccess.Entities;
using ApiGoDigital.DataAccess.IRepository;
using ApiGoDigital.Domain.IServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiGoDigital.Domain.Services
{
    public  class MovieServices : IMovieServices
    {
        private readonly IRequestHttpDataAccess _requestHttpDataAccess;
        public MovieServices(IRequestHttpDataAccess requestHttpDataAccess)
        {
            _requestHttpDataAccess = requestHttpDataAccess;
        }


        public async Task<Movie> GetLastMovie()
        {

            var result = await _requestHttpDataAccess.CallGetMethod("moviedb", "lastMovie", "");
            return JsonConvert.DeserializeObject<Movie>(result);
        }
        public async Task<TopRated> GetTopRated(string page)
        {

            var result = await _requestHttpDataAccess.CallGetMethod("moviedb", "topRated", "&page=" + page);
            return JsonConvert.DeserializeObject<TopRated>(result);
        }


    }
}
