using Microsoft.VisualStudio.TestTools.UnitTesting;
using BeautifulString.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautifulString.Engine.Tests
{
    [TestClass()]
    public class BeautifulStringCalculatorTests
    {
        [TestMethod()]
        public void CalculateStringBeautyTest()
        {
            string string1 = "ABbCcc";
            string string2 = "Good luck in the Facebook Hacker Cup this year!";
            string string3 = "Ignore punctuation, please :)";
            string string4 = "Sometimes test cases are hard to make up.";
            string string5 = "So I just go consult Professor Dalves";

            Assert.AreEqual(152, StringBeautyCalculator.CalculateStringBeauty(string1));
            Assert.AreEqual(754, StringBeautyCalculator.CalculateStringBeauty(string2));
            Assert.AreEqual(491, StringBeautyCalculator.CalculateStringBeauty(string3));
            Assert.AreEqual(729, StringBeautyCalculator.CalculateStringBeauty(string4));
            Assert.AreEqual(646, StringBeautyCalculator.CalculateStringBeauty(string5));
        }
    }
}