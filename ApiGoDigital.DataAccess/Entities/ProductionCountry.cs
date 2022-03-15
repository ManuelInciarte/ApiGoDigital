using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiGoDigital.DataAccess.Entities
{
    public class ProductionCountry
    {
        public string Iso3166_1 { get; set; }
        public string EnglishName { get; set; }
        public string NativeName { get; set; }
    }
}
