using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Assetoids.Location
{
    public sealed class GbpAddress 
    {
        private RawAddress Address { get; }

        internal GbpAddress(RawAddress address)
        {
            Address = address;
        }

        public string HouseNameNumber => Address.HouseNameNumber;
        public string Street => Address.AddressLine1;
        public string District => Address.AddressLine2;
        public string City => Address.City;
        public string County => Address.County;
        public string Postcode => Address.Postcode;

        public override string ToString()
        {
            return $"{HouseNameNumber} {Street}\n{District}\n{City}\n{County}\n{Postcode}";
        }


    }
}
