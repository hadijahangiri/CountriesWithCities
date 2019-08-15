using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesWithCities.Models.Tools.Country
{
    public class CountryOptions<T> where T: CountryOptions<T>
    {
        public long Id { get; protected set; }
        public string Name { get; protected set; }

        public T WithId(long id)
        {
            this.Id = id;
            return this as T;
        }

        public T WithName(string name)
        {
            this.Name = name;
            return this as T;
        }
    }
}
