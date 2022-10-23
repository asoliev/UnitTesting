using System;
using static UnitTesting.Tasks.PrimeFactor;

namespace UnitTesting.UnitTests.Tasks
{
    [TestClass]
    public class PrimeFactorTests
    {
        //arrange
        [DataRow(2, PrimeFactorEnum.Prime)]
        [DataRow(3, PrimeFactorEnum.Prime)]
        [DataRow(11, PrimeFactorEnum.Prime)]
        [DataRow(17, PrimeFactorEnum.Prime)]
        [DataRow(73, PrimeFactorEnum.Prime)]
        [TestMethod]
        public void Should_Be_Prime(int num, PrimeFactorEnum expecting)
        {
            //act
            var actual = CheckPrimeComposite(num);

            //assert
            Assert.AreEqual(actual, expecting);
        }

        //arrange
        [DataRow(4, PrimeFactorEnum.Composite)]
        [DataRow(12, PrimeFactorEnum.Composite)]
        [DataRow(33, PrimeFactorEnum.Composite)]
        [DataRow(100, PrimeFactorEnum.Composite)]
        [TestMethod]
        public void Should_Be_Composite(int num, PrimeFactorEnum expecting)
        {
            //act
            var actual = CheckPrimeComposite(num);

            //assert
            Assert.AreEqual(actual, expecting);
        }

        //arrange
        [TestMethod]
        public void Should_Be_One_If_Input_One()
        {
            //act
            var actual = CheckPrimeComposite(1);

            //assert
            Assert.AreEqual(actual, PrimeFactorEnum.One);
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
            CheckPrimeComposite(num);
        }
    }
}