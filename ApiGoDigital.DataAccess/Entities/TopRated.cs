using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiGoDigital.DataAccess.Entities
{
    public class TopRated
    {
        public long Page { get; set; }
        public List<Movie> Results { get; set; }
        public long TotalPages { get; set; }
        public long TotalResults { get; set; }
    }
}
