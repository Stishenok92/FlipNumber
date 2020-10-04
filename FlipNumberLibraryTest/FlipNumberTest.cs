using System.ComponentModel.DataAnnotations;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static FlipNumberLibrary.FlipNumber;

namespace FlipNumberLibraryTest
{
    [TestClass]
    public class FlipNumberTest
    {
        [TestMethod]
        public void ValidationNumber_45_ReturnedTrue()
        {
            //arrange
            int number = 45;
            bool expected = true;

            //act
            bool actual = ValidationNumber(number);

            //assert
            AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidationNumber_Minus4_ReturnedFalse()
        {
            //arrange
            int number = -4;
            bool expected = false;

            //act
            bool actual = ValidationNumber(number);

            //assert
            AreEqual(expected, actual);
        }

        [TestMethod]
        public void FlipIntNumber_483_Returned384()
        {
            //arrange
            int number = 483;
            int expected = 384;

            //act
            int actual = FlipIntNumber(number);

            //assert
            AreEqual(expected, actual);
        }

        [TestMethod]
        public void FlipIntNumber_960_Returned9()
        {
            //arrange
            int number = 960;
            int expected = 69;

            //act
            int actual = FlipIntNumber(number);

            //assert
            AreEqual(expected, actual);
        }

        [ExpectedException(typeof(ValidationException))]
        [TestMethod]
        public void FlipintNumber_Minus44_ValidationException()
        {
            //arrange
            int number = -44;

            //act + assert
            FlipIntNumber(number);
        }
    }
}