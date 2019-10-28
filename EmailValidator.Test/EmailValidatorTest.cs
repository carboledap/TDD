using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmailValidator.Test
{
    [TestClass]
    public class EmailValidatorTest
    {
        [TestMethod]
        public void CorreoConCaracteresValidos()
        {
            //Arrange
            bool expected = true;

            //Act
            var result = EmailValidator.ValidateEmail("ahernandezc@intergrupo.com");

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CorreoConCaracteresInvalidos()
        {
            //Arrange
            bool expected = false;

            //Act
            var result = EmailValidator.ValidateEmail("ahernandezc/#)(=*¨][@intergrupo.com");

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CorreoNulo()
        {
            //Arrange
            bool expected = false;

            //Act
            var result = EmailValidator.ValidateEmail(null);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CorreoVacio()
        {
            //Arrange
            bool expected = false;

            //Act
            var result = EmailValidator.ValidateEmail("");

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}