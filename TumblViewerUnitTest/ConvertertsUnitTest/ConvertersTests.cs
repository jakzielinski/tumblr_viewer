using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TumblViewerUnitTest.ConvertertsUnitTest
{
    [TestClass]
    public class ConvertersTests
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
