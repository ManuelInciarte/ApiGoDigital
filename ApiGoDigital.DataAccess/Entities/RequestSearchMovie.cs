using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiGoDigital.DataAccess.Entities
{
    public class RequestSearchMovie
    {
        public string language { get; set; }
        public string page { get; set; }
        public string region { get; set; }
        public string query { get; set; }
        public bool includeAdult { get; set; }
        public int year { get; set; }
        public int primaryReleaseYear { get; set; }

    }
}
