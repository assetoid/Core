namespace Library.Assetoids.Location
{
    public sealed class NldAddress
    {
        private RawAddress Address { get; }

        internal NldAddress(RawAddress address)
        {
            Address = address;
        }

        public string Huisnummer => Address.HouseNameNumber;
        public string Straat => Address.AddressLine1;
        public string Woonplaats => Address.City;
        public string Postcode => Address.Postcode;

        public override string ToString()
        {
            return $"{Straat} {Huisnummer} \n {Postcode} {Woonplaats}";
        }
    }
    
}
