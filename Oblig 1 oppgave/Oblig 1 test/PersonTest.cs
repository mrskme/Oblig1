using NUnit.Framework;
using Oblig_1_oppgave;

namespace Oblig_1_test
{
	public class Tests
	{
		[Test]
        public void TestAllFields()
        {
            var p = new Person
            {
                Id = 17,
                FirstName = "Ola",
                LastName = "Nordmann",
                BirthYear = 2000,
                DeathYear = 3000,
                Father = new Person() { Id = 23, FirstName = "Per" },
                Mother = new Person() { Id = 29, FirstName = "Lise" },
            };

            var actualDescription = p.GetDescription();
            var expectedDescription = "Ola Nordmann (Id=17) Født: 2000 Død: 3000 Far: Per (Id=23) Mor: Lise (Id=29)";

            Assert.AreEqual(expectedDescription, actualDescription);
        }
        [Test]
        public void TestNoFields()
        {
            var p = new Person
            {
                Id = 1,
            };

            var actualDescription = p.GetDescription();
            var expectedDescription = "(Id=1)";

            Assert.AreEqual(expectedDescription, actualDescription);
        }
        [Test]
        public void TestSomeFields()
        {
            var p = new Person
            {
                Id = 1,
                FirstName = "Ola",
                LastName = "Nordmann",
                Mother = new Person() {Id = 2, LastName = "Langbak"}
            };

            var actualDescription = p.GetDescription();
            var expectedDescription = "Ola Nordmann (Id=1) Mor: (Id=2)";

            Assert.AreEqual(expectedDescription, actualDescription);
        }
    }
}