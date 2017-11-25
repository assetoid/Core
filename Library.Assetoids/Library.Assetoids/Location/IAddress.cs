using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Assetoids.Location
{
    public interface IAddress
    {
        string HouseNameNumber { get; }
        string AddressLine1 { get; }
        string AddressLine2 { get; }
        string City { get; }
        string Country { get; }
        string County { get; }
        string Postcode { get; }
    }
}
