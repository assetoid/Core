using Library.Assetoids.People;

namespace Library.Assetoids.Builders.People
{
    public class OwnerBuilder
    {
        internal OwnerBuilder() 
        {   
        }

        public Owner With(string firstName, string lastName, string title)
        {
            return new Owner(firstName, lastName, title);
        }
    }
}
