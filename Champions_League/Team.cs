using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Champions_League
{
    public class Team
    {
        public string _teamName { get; set; }
        public string _teamCountry { get; set; }
        public Team(string name, string country)
        {
            _teamName = name;
            _teamCountry = country;
        }
        public override string ToString()
        {
            return _teamName + "-" + _teamCountry;
        }

    }
}
