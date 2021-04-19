using NUnit.Framework;
using CalculatorPract2;
using static CalculatorPract2.Program;

namespace CalculatorTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestAdd()
        {
            Assert.AreEqual(10, add(12, -2), "An Error");
        }

        [Test]
        public void TestSub()
        {
            Assert.AreEqual(5, sub(10, 5), "An Error");
        }

        [Test]
        public void TestMul()
        {
            Assert.AreEqual(10, mul(2, 5), "An Error");
        }

        [Test]
        public void TestDiv()
        {
            Assert.AreEqual(3, div(9, 3), "An Error");
        }
    }
}