using FluentAssertions;
using Library.Assetoids.Builders.Location;
using Library.Assetoids.Builders.People;
using Library.Assetoids.Location;
using Library.Assetoids.People;
using NUnit.Framework;

namespace Library.AssetoidsTests.Builders.Location
{
    [TestFixture]
    internal sealed class LocationBuilderTests
    {
        [TestCase]
        public void LocationBuilderCreatesGbpAddressInstance()
        {
            var location = new LocationBuilder();

            location.CreateGbpAddress().Should().BeOfType<GbpAddress>();
        }

        [TestCase]
        public void LocationBuilderCreatesNldAddressInstance()
        {
            var location = new LocationBuilder();

            location.CreateNldAddress().Should().BeOfType<NldAddress>();
        }

        [TestCase("10", "Downing Street", "LondonAdd2", "London", "London City", "LND1")]
        [TestCase("22", "Random Street", "NorthAdd2", "Up North", "Scunthorpe", "SCN1")]
        public void LocationCreatedByBuilderHasHouseNumberGiveToBuilder(string houseNameNumber, string address1, string address2, string county, string city, string postcode)
        {
            var location = new LocationBuilder()
                .WithHouseNameNumber(houseNameNumber)
                .WithAddressLine1(address1)
                .WithAddressLine2(address2)
                .WithCounty(county)
                .WithCity(city)
                .WithPostcode(postcode);

            location.CreateGbpAddress().HouseNameNumber.Should().Be(houseNameNumber);
            location.CreateNldAddress().Huisnummer.Should().Be(houseNameNumber);
        }

        [TestCase("10", "Downing Street", "LondonAdd2", "London", "London City", "LND1")]
        [TestCase("22", "Random Street", "NorthAdd2", "Up North", "Scunthorpe", "SCN1")]
        public void LocationCreatedByBuilderHasAddressLine1GiveToBuilder(string houseNameNumber, string address1, string address2, string county, string city, string postcode)
        {
            var location = new LocationBuilder()
                .WithHouseNameNumber(houseNameNumber)
                .WithAddressLine1(address1)
                .WithAddressLine2(address2)
                .WithCounty(county)
                .WithCity(city)
                .WithPostcode(postcode);

            location.CreateGbpAddress().Street.Should().Be(address1);
            location.CreateNldAddress().Straat.Should().Be(address1);
        }

        [TestCase("10", "Downing Street", "LondonAdd2", "London", "London City", "LND1")]
        [TestCase("22", "Random Street", "NorthAdd2", "Up North", "Scunthorpe", "SCN1")]
        public void LocationCreatedByBuilderHasAddressLine2GiveToBuilder(string houseNameNumber, string address1, string address2, string county, string city, string postcode)
        {
            var location = new LocationBuilder()
                .WithHouseNameNumber(houseNameNumber)
                .WithAddressLine1(address1)
                .WithAddressLine2(address2)
                .WithCounty(county)
                .WithCity(city)
                .WithPostcode(postcode);

            location.CreateGbpAddress().District.Should().Be(address2);
        }

        [TestCase("10", "Downing Street", "LondonAdd2", "London", "London City", "LND1")]
        [TestCase("22", "Random Street", "NorthAdd2", "Up North", "Scunthorpe", "SCN1")]
        public void LocationCreatedByBuilderHasCityGiveToBuilder(string houseNameNumber, string address1, string address2, string county, string city, string postcode)
        {
            var location = new LocationBuilder()
                .WithHouseNameNumber(houseNameNumber)
                .WithAddressLine1(address1)
                .WithAddressLine2(address2)
                .WithCounty(county)
                .WithCity(city)
                .WithPostcode(postcode);

            location.CreateGbpAddress().City.Should().Be(city);
            location.CreateNldAddress().Woonplaats.Should().Be(city);
        }

        [TestCase("10", "Downing Street", "LondonAdd2", "London", "London City", "LND1")]
        [TestCase("22", "Random Street", "NorthAdd2", "Up North", "Scunthorpe", "SCN1")]
        public void LocationCreatedByBuilderHasCountyGiveToBuilder(string houseNameNumber, string address1, string address2, string county, string city, string postcode)
        {
            var location = new LocationBuilder()
                .WithHouseNameNumber(houseNameNumber)
                .WithAddressLine1(address1)
                .WithAddressLine2(address2)
                .WithCounty(county)
                .WithCity(city)
                .WithPostcode(postcode);

            location.CreateGbpAddress().County.Should().Be(county);
        }

        [TestCase("10", "Downing Street", "LondonAdd2", "London", "London City", "LND1")]
        [TestCase("22", "Random Street", "NorthAdd2", "Up North", "Scunthorpe", "SCN1")]
        public void LocationCreatedByBuilderHasPostcodeGiveToBuilder(string houseNameNumber, string address1, string address2, string county, string city, string postcode)
        {
            var location = new LocationBuilder()
                .WithHouseNameNumber(houseNameNumber)
                .WithAddressLine1(address1)
                .WithAddressLine2(address2)
                .WithCounty(county)
                .WithCity(city)
                .WithPostcode(postcode);

            location.CreateGbpAddress().Postcode.Should().Be(postcode);
            location.CreateNldAddress().Postcode.Should().Be(postcode);
        }
    }
}
