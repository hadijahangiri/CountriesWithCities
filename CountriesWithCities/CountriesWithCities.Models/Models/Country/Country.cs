using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesWithCities.Models.Models.Country
{
    public class Country
    {
        public long Id { get; private set; }
        public string Name { get; private set; }

        public Country(long id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
