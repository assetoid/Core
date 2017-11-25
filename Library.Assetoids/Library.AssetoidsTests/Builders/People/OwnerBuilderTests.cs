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
    internal sealed class OwnerBuilderTests
    {
        [TestCase]
        public void ManagerBuilderCreatesManagerInstance()
        {
            var owner = PeopleBuilder.CreateOwner();

            owner.With("", "", "").Should().BeOfType<Owner>();
        }

        [TestCase("Eric", "Cartman", "Mr")]
        public void OwnerCreatedByBuilderAsFirstNameGiveToBuilder(string firstname, string lastname, string title)
        {
            var owner = PeopleBuilder.CreateOwner().With(firstname, lastname, title);

            owner.FirstName.Should().Be(firstname);
        }

        [TestCase("Eric", "Cartman", "Mr")]
        public void OwnerCreatedByBuilderAsLastNameGiveToBuilder(string firstname, string lastname, string title)
        {
            var owner = PeopleBuilder.CreateOwner().With(firstname, lastname, title);

            owner.LastName.Should().Be(lastname);
        }

        [TestCase("Eric", "Cartman", "Mr")]
        public void OwnerCreatedByBuilderAsTitleNameGiveToBuilder(string firstname, string lastname, string title)
        {
            var owner = PeopleBuilder.CreateOwner().With(firstname, lastname, title);

            owner.Title.Should().Be(title);
        }
    }
}
