using static UnitTesting.Tasks.OddEven;

namespace UnitTesting.UnitTests.Tasks
{
    [TestClass]
    public class OddEvenTests
    {
        //arrange
        [DataRow(1, OddEvenEnum.Odd)]
        [DataRow(15, OddEvenEnum.Odd)]
        [DataRow(27, OddEvenEnum.Odd)]
        [DataRow(33, OddEvenEnum.Odd)]
        [DataRow(81, OddEvenEnum.Odd)]
        [TestMethod]
        public void Should_Be_Odd(int num, OddEvenEnum expecting)
        {
            //act
            var actual = CheckOddEven(num);

            //assert
            Assert.AreEqual(actual, expecting);
        }

        //arrange
        [DataRow(2, OddEvenEnum.Even)]
        [DataRow(4, OddEvenEnum.Even)]
        [DataRow(10, OddEvenEnum.Even)]
        [DataRow(82, OddEvenEnum.Even)]
        [DataRow(100, OddEvenEnum.Even)]
        [TestMethod]
        public void Should_Be_Even(int num, OddEvenEnum expecting)
        {
            //act
            var actual = CheckOddEven(num);

            //assert
            Assert.AreEqual(actual, expecting);
        }

        //arrange
        [DataRow(3, OddEvenEnum.Prime)]
        [DataRow(7, OddEvenEnum.Prime)]
        [DataRow(11, OddEvenEnum.Prime)]
        [DataRow(17, OddEvenEnum.Prime)]
        [DataRow(73, OddEvenEnum.Prime)]
        [TestMethod]
        public void Should_Be_Prime(int num, OddEvenEnum expecting)
        {
            //act
            var actual = CheckOddEven(num);

            //assert
            Assert.AreEqual(actual, expecting);
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
            CheckOddEven(num);
        }
    }
}