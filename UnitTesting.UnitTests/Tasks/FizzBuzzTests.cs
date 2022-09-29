using UnitTesting.Tasks;

namespace UnitTesting.UnitTests.Tasks
{
    [TestClass]
    public class FizzBuzzTests
    {
        [DataRow(15, "FizzBuzz")]
        [DataRow(30, "FizzBuzz")]
        [DataRow(45, "FizzBuzz")]
        [DataRow(75, "FizzBuzz")]
        [TestMethod]
        public void Should_Be_FizzBuzz(int num, string result)
        {
            Assert.AreEqual(FizzBuzz.ReplaceWithFizzBuzz(num), result);
        }

        [DataRow(3, "Fizz")]
        [DataRow(9, "Fizz")]
        [DataRow(27, "Fizz")]
        [DataRow(99, "Fizz")]
        [TestMethod]
        public void Should_Be_Fizz(int num, string result)
        {
            Assert.AreEqual(FizzBuzz.ReplaceWithFizzBuzz(num), result);
        }

        [DataRow(5, "Buzz")]
        [DataRow(25, "Buzz")]
        [DataRow(50, "Buzz")]
        [DataRow(95, "Buzz")]
        [TestMethod]
        public void Should_Be_Buzz(int num, string result)
        {
            Assert.AreEqual(FizzBuzz.ReplaceWithFizzBuzz(num), result);
        }

        [DataRow(1)]
        [DataRow(2)]
        [DataRow(23)]
        [DataRow(58)]
        [DataRow(91)]
        [TestMethod]
        public void Should_Be_NumberItself(int num)
        {
            Assert.AreEqual(FizzBuzz.ReplaceWithFizzBuzz(num), num.ToString());
        }

        [DataRow(-5)]
        [DataRow(104)]
        [DataRow(0)]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void Should_Throw_ArgumentOutOfRangeException_If_Input_OutOfRange(int num)
        {
            FizzBuzz.ReplaceWithFizzBuzz(num);
        }
    }
}