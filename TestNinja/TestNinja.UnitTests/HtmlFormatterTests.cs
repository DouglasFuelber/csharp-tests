using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class HtmlFormatterTests
    {
        [Test]
        public void FormatAsBold_WhenCalledShouldEncloseStringWithStrongElement()
        {
            var formatter = new HtmlFormatter();

            var result = formatter.FormatAsBold("abc");

            // Specific
            Assert.That(result, Is.EqualTo("<strong>abc</strong>"));

            // General
            Assert.That(result, Does.StartWith("<strong>"));
            StringAssert.StartsWith("<strong>", result);

            Assert.That(result, Does.EndWith("</strong>"));
            StringAssert.EndsWith("</strong>", result);

            Assert.That(result, Does.Contain("abc"));
            StringAssert.Contains("abc", result);
        }
    }
}
