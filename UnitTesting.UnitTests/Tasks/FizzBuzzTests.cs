using static UnitTesting.Tasks.FizzBuzz;

namespace UnitTesting.UnitTests.Tasks
{
    [TestClass]
    public class FizzBuzzTests
    {
        //arrange
        [DataRow(15, FizzBuzzEnum.FizzBuzz)]
        [DataRow(30, FizzBuzzEnum.FizzBuzz)]
        [DataRow(45, FizzBuzzEnum.FizzBuzz)]
        [DataRow(75, FizzBuzzEnum.FizzBuzz)]
        [TestMethod]
        public void Should_Be_FizzBuzz(int num, FizzBuzzEnum expecting)
        {
            //act
            var actual = ReplaceWithFizzBuzz(num);

            //assert
            Assert.AreEqual(actual, expecting);
        }

        //arrange
        [DataRow(3, FizzBuzzEnum.Fizz)]
        [DataRow(9, FizzBuzzEnum.Fizz)]
        [DataRow(27, FizzBuzzEnum.Fizz)]
        [DataRow(99, FizzBuzzEnum.Fizz)]
        [TestMethod]
        public void Should_Be_Fizz(int num, FizzBuzzEnum expecting)
        {
            //act
            var actual = ReplaceWithFizzBuzz(num);

            //assert
            Assert.AreEqual(actual, expecting);
        }

        //arrange
        [DataRow(5, FizzBuzzEnum.Buzz)]
        [DataRow(25, FizzBuzzEnum.Buzz)]
        [DataRow(50, FizzBuzzEnum.Buzz)]
        [DataRow(95, FizzBuzzEnum.Buzz)]
        [TestMethod]
        public void Should_Be_Buzz(int num, FizzBuzzEnum expecting)
        {
            //act
            var actual = ReplaceWithFizzBuzz(num);

            //assert
            Assert.AreEqual(actual, expecting);
        }

        //arrange
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(23)]
        [DataRow(58)]
        [DataRow(91)]
        [TestMethod]
        public void Should_Be_NumberItself(int num)
        {
            //act
            var actual = ReplaceWithFizzBuzz(num);

            //assert
            Assert.AreEqual(actual, (FizzBuzzEnum)Enum.Parse(typeof(FizzBuzzEnum), num.ToString()));
        }

        //arrange
        [DataRow(-5)]
        [DataRow(104)]
        [DataRow(0)]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]//assert
        [TestMethod]
        public void Should_Throw_ArgumentOutOfRangeException_If_Input_OutOfRange(int num)
        {
            //act
            ReplaceWithFizzBuzz(num);
        }
    }
}