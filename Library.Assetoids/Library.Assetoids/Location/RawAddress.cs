using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Assetoids.Location
{
    internal sealed class RawAddress : IAddress
    {
        internal RawAddress(string houseNameNumber ="", string addressLine1 ="", string addressLine2 ="", string city="", string county="", string postcode="", string country="")
        {
            HouseNameNumber = houseNameNumber;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            City = city;
            County = county;
            Postcode = postcode;
            Country = country;
        }

        public string HouseNameNumber { get; internal set; }
        public string AddressLine1 { get; internal set; }
        public string AddressLine2 { get; internal set; }
        public string City { get; internal set; }
        public string Country { get; internal set; }
        public string County { get; internal set; }
        public string Postcode { get; internal set; }
    }
}
