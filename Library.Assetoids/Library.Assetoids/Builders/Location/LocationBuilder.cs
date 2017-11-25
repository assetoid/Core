using System;
using System.Collections.Generic;
using System.Text;
using Library.Assetoids.Location;

namespace Library.Assetoids.Builders.Location
{
    public class LocationBuilder
    {
        private RawAddress _address;
        
        public LocationBuilder()
        {
            _address = new RawAddress();
        }

        public LocationBuilder WithHouseNameNumber(string houseNameNumber)
        {
            _address.HouseNameNumber = houseNameNumber;
            return this;
        }

        public LocationBuilder WithAddressLine1(string address1)
        {
            _address.AddressLine1 = address1;
            return this;
        }

        public LocationBuilder WithAddressLine2(string address2)
        {
            _address.AddressLine2 = address2;
            return this;
        }

        public LocationBuilder WithCity(string city)
        {
            _address.City = city;
            return this;
        }

        public LocationBuilder WithCounty(string county)
        {
            _address.County = county;
            return this;
        }

        public LocationBuilder WithPostcode(string postcode)
        {
            _address.Postcode = postcode;
            return this;
        }

        public GbpAddress CreateGbpAddress()
        {
            return new GbpAddress(_address);
        }

        public NldAddress CreateNldAddress()
        {
            return new NldAddress(_address);
        }
    }
}
