using NUnit.Framework;
using OOP.PeopleUtils;

namespace OOP.Tests
{
    [TestFixture]
    public class ManTests
    {
        [Test]
        public void Test()
        {
            var employee = new Employee("man1", "man2", 25, 10000);
            Man man = (Man) employee;

            Assert.That(man.FirstName, Is.EqualTo("man1"));
            Assert.That(man.LastName, Is.EqualTo("man2"));
            Assert.That(man.Age, Is.EqualTo(25));

            var developer = new Developer("first", "second", 21, "C#", 100500);
            Man dev = (Man) developer;
            Employee empl = (Employee) developer;

            Assert.That(dev.Age, Is.EqualTo(21));
            Assert.That(dev.FirstName, Is.EqualTo("first"));
            Assert.That(dev.LastName, Is.EqualTo("second"));

            Assert.That(empl.Age, Is.EqualTo(21));
            Assert.That(empl.FirstName, Is.EqualTo("first"));
            Assert.That(empl.LastName, Is.EqualTo("second"));
            Assert.That(empl.GetSalary(), Is.EqualTo(100500 - 100500/10));

        }
    }
}
