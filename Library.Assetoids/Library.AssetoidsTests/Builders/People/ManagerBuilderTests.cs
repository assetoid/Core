using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Library.Assetoids.Builders;
using Library.Assetoids.Builders.People;
using Library.Assetoids.People;
using NUnit.Framework;

namespace Library.AssetoidsTests
{
    [TestFixture]
    internal sealed class ManagerBuilderTests
    {
        [TestCase]
        public void ManagerBuilderCreatesManagerInstance()
        {
            var manager = PeopleBuilder.CreateManager();

            manager.With("", "", "").Should().BeOfType<Manager>();
        }

        [TestCase("Eric", "Cartman", "Mr")]
        public void ManagerCreatedByBuilderAsFirstNameGiveToBuilder(string firstname, string lastname, string title)
        {
            var manager = PeopleBuilder.CreateManager().With(firstname, lastname, title);

            manager.FirstName.Should().Be(firstname);
        }

        [TestCase("Eric", "Cartman", "Mr")]
        public void ManagerCreatedByBuilderAsLastNameGiveToBuilder(string firstname, string lastname, string title)
        {
            var manager = PeopleBuilder.CreateManager().With(firstname, lastname, title);

            manager.LastName.Should().Be(lastname);
        }

        [TestCase("Eric", "Cartman", "Mr")]
        public void ManagerCreatedByBuilderAsTitleNameGiveToBuilder(string firstname, string lastname, string title)
        {
            var manager = PeopleBuilder.CreateManager().With(firstname, lastname, title);

            manager.Title.Should().Be(title);
        }
    }
}
