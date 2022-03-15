using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiGoDigital.DataAccess.Entities
{
    public class Movie
    {
        public bool Adult { get; set; }
        public object BackdropPath { get; set; }
        public object BelongsToCollection { get; set; }
        public long Budget { get; set; }
        public List<object> Genres { get; set; }
        public string Homepage { get; set; }
        public long Id { get; set; }
        public object ImdbId { get; set; }
        public string OriginalLanguage { get; set; }
        public string OriginalTitle { get; set; }
        public string Overview { get; set; }
        public long Popularity { get; set; }
        public object PosterPath { get; set; }
        public List<ProductionCompany> ProductionCompanies { get; set; }
        public List<ProductionCountry> ProductionCountries { get; set; }
        public DateTimeOffset ReleaseDate { get; set; }
        public long Revenue { get; set; }
        public long Runtime { get; set; }
        public List<Languages> SpokenLanguages { get; set; }
        public string Status { get; set; }
        public string Tagline { get; set; }
        public string Title { get; set; }
        public bool Video { get; set; }
        public long VoteAverage { get; set; }
        public long VoteCount { get; set; }
    }
    
}
