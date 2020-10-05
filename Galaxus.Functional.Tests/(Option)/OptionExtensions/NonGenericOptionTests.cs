using NUnit.Framework;

namespace Galaxus.Functional.Tests.OptionExtensions
{
    [TestFixture]
    public class NonGenericOptionTests
    {
        [Test]
        public void From_NullValue_ReturnsNone()
        {
            var value = (string) null;
            var option = Option.From(value);

            Assert.IsTrue(option.IsNone);
        }

        [Test]
        public void From_NullableValue_ReturnsNone()
        {
            var value = (bool?) null;
            var option = Option.From(value);

            Assert.IsTrue(option.IsNone);
        }

        [Test]
        public void From_Value_ReturnsSome()
        {
            var value = "test";
            var option = Option.From(value);

            Assert.IsTrue(option.IsSome);
            Assert.AreEqual("test", option.Unwrap());
        }

        [Test]
        public void From_NullableValue_ReturnsSome()
        {
            var value = (bool?) true;
            var option = Option.From(value);

            Assert.IsTrue(option.IsSome);
            Assert.AreEqual(true, option.Unwrap());
        }
    }
}
