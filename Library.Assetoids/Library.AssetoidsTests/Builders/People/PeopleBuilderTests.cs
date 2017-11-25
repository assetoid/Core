using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Library.Assetoids.Builders.People;
using Library.Assetoids.People;
using NUnit.Framework;

namespace Library.AssetoidsTests
{
    [TestFixture]
    internal sealed class PeopleBuilderTests
    {
        [Test]
        public void PeopleBuilderCreatesManagerBuilderInstance()
        {
            var manager = PeopleBuilder.CreateManager();

            manager.Should().BeOfType<ManagerBuilder>();
        }

        [Test]
        public void PeopleBuilderCreatesOwnerBuilderInstance()
        {
            var owner = PeopleBuilder.CreateOwner();

            owner.Should().BeOfType<OwnerBuilder>();
        }
    }
}
