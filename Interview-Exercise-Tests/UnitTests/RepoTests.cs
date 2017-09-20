using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Exercise
{
    using NUnit.Framework;

    [TestFixture]
    public class RepoTest
    {
        [Test]
        public void AddCountry()
        {
            Country country = new Country();
            country.Name = "United States of America";
            country.Code = "USA";

            CountryCodeRepository repo = new CountryCodeRepository();
            repo.Add(country);

            Country checkCountry = repo.Get(country.Code);

            Assert.NotNull(checkCountry);
            Assert.AreEqual(checkCountry.Code, country.Code);
            Assert.AreEqual(checkCountry.Name, country.Name);
        }
    }
}