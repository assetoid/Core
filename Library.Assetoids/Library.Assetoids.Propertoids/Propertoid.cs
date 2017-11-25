using System;
using System.Reflection.Emit;
using Library.Assetoids.Builders.Location;
using Library.Assetoids.Builders.People;
using Library.Assetoids.Location;
using Library.Assetoids.People;

namespace Library.Assetoids.Propertoids
{
    public class Propertoid
    {
        public Propertoid(Owner owner, IAddress address)
        {
            Owner = owner;
            Address = address;
        }

        public Owner Owner { get; }
        public IAddress Address { get; }
    }
}
