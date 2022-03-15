using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiGoDigital.DataAccess.Entities
{
       public class Integration
        {
            public List<ServicesInt> Services { get; set; }
        }

        public class ServicesInt
        {
            public string Name { get; set; }
            public string URL { get; set; }
            public string ApiToken { get; set; }
            public List<Methods> Methods { get; set; }
        }        

        public class Methods
        {
            public string Method { get; set; }
            public string Value { get; set; }
        }

    
}
