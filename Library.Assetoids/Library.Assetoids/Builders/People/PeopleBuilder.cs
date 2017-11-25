namespace Library.Assetoids.Builders.People
{
    public class PeopleBuilder
    {
        public static OwnerBuilder CreateOwner()
        {
            return new OwnerBuilder();
        }

        public static ManagerBuilder CreateManager()
        {
            return new ManagerBuilder();
        }
    }
}
