using NUnit.Framework;

namespace TestProject4
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("ky setup method");
        }

        [Test]
        public void Test1()
        {
            Console.WriteLine("ky eshte testi 1");

        }
        [Test]
        public void Test2()
        {
            Console.WriteLine("ky eshte testi 2");

        }

        [TearDown]

        public void closebrowser()
        {
            Console.WriteLine("Tea down metoda");
        }
    }
}