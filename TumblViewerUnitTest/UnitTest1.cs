using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace TumblViewerUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void StringLettersToUpperCase()
        {
            String inputString = "tEsTsTrInG";
            inputString = inputString.ToUpper();
            String expectedString = "TESTSTRING";

            Assert.AreEqual(expectedString, inputString);
        }
    }
}
