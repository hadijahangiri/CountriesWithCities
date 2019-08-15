using CountriesWithCities.Models.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace CountriesWithCities.Models.Tests.Country
{
    public class ContryTests
    {
        [Fact]
        public void Constructor_should_assign_properties_correctly()
        {
            var builder = new CountryBuilder();

            var entity = builder.Build();
            entity.Id.Should().Be(builder.Id);
            entity.Name.Should().Be(builder.Name);
        }
    }
}
