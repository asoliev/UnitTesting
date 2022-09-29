using UnitTesting.Tasks;

namespace UnitTesting.UnitTests.Tasks
{
    [TestClass]
    public class PrimeFactorTests
    {
        [DataRow(2, "Prime")]
        [DataRow(3, "Prime")]
        [DataRow(11, "Prime")]
        [DataRow(17, "Prime")]
        [DataRow(73, "Prime")]
        [TestMethod]
        public void Should_Be_Prime(int num, string result)
        {
            Assert.AreEqual(PrimeFactor.CheckPrimeComposite(num), result);
        }

        [DataRow(4, "Composite")]
        [DataRow(12, "Composite")]
        [DataRow(33, "Composite")]
        [DataRow(100, "Composite")]
        [TestMethod]
        public void Should_Be_Composite(int num, string result)
        {
            Assert.AreEqual(PrimeFactor.CheckPrimeComposite(num), result);
        }

        [TestMethod]
        public void Should_Be_One_If_Input_One()
        {
            Assert.AreEqual(PrimeFactor.CheckPrimeComposite(1), "1");
        }

        [DataRow(-5)]
        [DataRow(104)]
        [DataRow(0)]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void Should_Throw_ArgumentOutOfRangeException_If_Input_OutOfRange(int num)
        {
            PrimeFactor.CheckPrimeComposite(num);
        }
    }
}