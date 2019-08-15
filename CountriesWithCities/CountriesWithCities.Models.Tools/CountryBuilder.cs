using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CountriesWithCities.Models.Tools.Country;

namespace CountriesWithCities.Models.Tools
{
    public class CountryBuilder : CountryOptions<CountryBuilder>
    {
        public CountryBuilder()
        {
            this.Id = 1;
            this.Name = "Iran";
        }

        public Models.Country.Country Build()
        {
            return new Models.Country.Country(this.Id, this.Name);
        }
    }
}
