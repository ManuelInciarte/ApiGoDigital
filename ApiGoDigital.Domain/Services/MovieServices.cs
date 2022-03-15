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


        public async Task<Movie> GetLastMovie(string language)
        {
            var parameters = "";
            if (language is not null) parameters = parameters + "&language=" + language;
            var result = await _requestHttpDataAccess.CallGetMethod("moviedb", "lastMovie", parameters);
            return JsonConvert.DeserializeObject<Movie>(result);
        }
        public async Task<ListMovie> GetTopRated(string language, string page, string region)
        {
            var parameters = "";
            if (language is not null) parameters = parameters + "&language=" + language;
            if (page is not null) parameters = parameters + "&page=" + page;
            if (region is not null) parameters = parameters + "&region=" + region;
            var result = await _requestHttpDataAccess.CallGetMethod("moviedb", "topRated", parameters);
            return JsonConvert.DeserializeObject<ListMovie>(result);
        }
        public async Task<ListMovie> GetTopPopular(string language, string page, string region)
        {
            var parameters = "";
            if (language is not null) parameters = parameters + "&language=" + language;
            if (page is not null) parameters = parameters + "&page=" + page;
            if (region is not null) parameters = parameters + "&region=" + region;
            var result = await _requestHttpDataAccess.CallGetMethod("moviedb", "mostPopular", parameters);
            return JsonConvert.DeserializeObject<ListMovie>(result);
        }
        public async Task<ListMovie> SearchMovie(RequestSearchMovie request)
        {
            var parameters = "";
            if (request.language is not null) parameters = parameters + "&language=" + request.language;
            if (request.query is not null) parameters = parameters + "&query=" + request.query;
            if (request.page is not null) parameters = parameters + "&page=" + request.page;
            if (request.includeAdult) parameters = parameters + "&include_adult=" + request.includeAdult;    
            if (request.region is not null) parameters = parameters + "&region=" + request.region;
            if (request.year != 0) parameters = parameters + "&year=" + request.year;
            if (request.primaryReleaseYear != 0) parameters = parameters + "&primary_release_year=" + request.primaryReleaseYear;

            var result = await _requestHttpDataAccess.CallGetMethod("moviedb", "searchMovie", parameters);
            return JsonConvert.DeserializeObject<ListMovie>(result);
        }


    }
}
