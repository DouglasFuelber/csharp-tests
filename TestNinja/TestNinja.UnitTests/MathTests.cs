using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class MathTests
    {
        [Test]
        public void Add_WhenCalled_ReturnSumOfArguments() {
            var math = new Math();

            var result = math.Add(1, 2);

            Assert.AreEqual(result, 3);
        }
    }
}
