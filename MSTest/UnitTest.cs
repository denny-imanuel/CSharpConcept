using CSharpConcept;

namespace MSTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestAdd()
        {
            var bm = new TestClass();
            var actual = bm.Add(10, 1);
            var expected = 11;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSubstract()
        {
            var bm = new TestClass();
            var actual = bm.Substract(10, 1);
            var expected = 9;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDivide()
        {
            var bm = new TestClass();
            var actual = bm.Divide(10, 2);
            var expected = 5;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMultiply()
        {
            var bm = new TestClass();
            var actual = bm.Multiply(5, 2);
            var expected = 10;
            Assert.AreEqual(expected, actual);
        }

    }
}