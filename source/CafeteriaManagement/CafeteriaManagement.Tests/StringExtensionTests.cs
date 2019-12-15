using System;
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
           // var actual = input.RemoveIllegalChars();

            // --Assert

           // Assert.AreEqual(expected, actual);

        }

        
    }
}
