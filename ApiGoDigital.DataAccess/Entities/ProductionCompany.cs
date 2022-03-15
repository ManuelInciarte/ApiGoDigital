using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiGoDigital.DataAccess.Entities
{
    public class ProductionCompany
    {
        public long Id { get; set; }
        public object LogoPath { get; set; }
        public string Name { get; set; }
        public string OriginCountry { get; set; }
    }
}
