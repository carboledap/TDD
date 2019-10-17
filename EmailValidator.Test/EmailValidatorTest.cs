using System;
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
    }
}
