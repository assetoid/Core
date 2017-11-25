using Library.Assetoids.People;

namespace Library.Assetoids.Builders.People
{
    public class ManagerBuilder
    {
        internal ManagerBuilder() 
        {   
        }

        public Manager With(string firstName, string lastName, string title)
        {
            return new Manager(firstName, lastName, title);
        }
    }
}
