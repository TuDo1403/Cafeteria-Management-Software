using System;
using CM.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CafeteriaManagement.Tests
{
    [TestClass]
    public class StringExtensionTests
    {
        [TestMethod]
        public void IllegalCharsConvertTest()
        {
            // --Arrange
            var input = "?/:*";
            var expected = "____";


            // --Act
            var actual = input.RemoveIllegalChars();

            // --Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StandardlizeTest()
        {
            //-- Arrange
            var name = " dO  minh   tU ";
            var expected = "Do Minh Tu";

            //-- Act
            var actual = name.Standardlize();

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MD5HashTest()
        {
            // -- Arrange
            var input = "U0003";
            var expected = "6731cc970e206e3c2868da02a9e23a9a";

            // -- Act
            var actual = input.GetMD5HashedString();

            // -- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsValidNameTest()
        {
            // -- Arrange
            var name1 = "dominhtu";
            var name2 = "dom1nh tu";
            var expected = false;

            // -- Act
            var actual1 = name1.IsValidName();
            var actual2 = name2.IsValidName();

            // -- Assert
            Assert.AreEqual(expected, actual1);
            Assert.AreEqual(expected, actual2);
        }

        [TestMethod]
        public void IsvalidPhoneNumberTest()
        {
            // -- Arrange
            var number1 = "0972183064";
            var number2 = "93939393421112";
            var number3 = "123";
            var number4 = "123abc";
            var number5 = "123./?";

            var expected1 = true;
            var expected2 = false;
            var expected3 = false;
            var expected4 = false;
            var expected5 = false;

            // -- Act
            var actual1 = number1.IsValidNumber();
            var actual2 = number2.IsValidNumber();
            var actual3 = number3.IsValidNumber();
            var actual4 = number4.IsValidNumber();
            var actual5 = number5.IsValidNumber();

            // -- Assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
            Assert.AreEqual(expected4, actual4);
            Assert.AreEqual(expected5, actual5);
        }

        [TestMethod]
        public void IsValidEmailTest()
        {
            // -- Arrange
            var email1 = "@gmail.com";
            var email2 = "aadasdad";
            var email3 = "adq2312//232";

            var expected1 = false;
            var expected2 = false;
            var expected3 = false;

            // -- Act
            var actual1 = email1.IsValidEmail();
            var actual2 = email2.IsValidEmail();
            var actual3 = email3.IsValidEmail();

            // -- Assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
        }
    }
}
