using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Assetoids.People
{
    public abstract class Person
    {
        protected Person(string firstName, string lastName, string title)
        {
            FirstName = firstName;
            LastName = lastName;
            Title = title;
        }

        public string FirstName { get; }
        public string LastName { get; }
        public string Title { get; }
    }
}
