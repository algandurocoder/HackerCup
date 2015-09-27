using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace BalancedSmileys
{
    [TestFixture]
    class BalancedSmileysTests
    {
        [TestCase("", true)]
        [TestCase("sad sd :", true)]
        [TestCase("(I am balanced)", true)]
        [TestCase("(I am balanced)(I am too!)", true)]
        [TestCase(":)", true)]
        [TestCase(":(", true)]
        [TestCase("(", false)]
        [TestCase("()", true)]
        [TestCase(":(:)", true)]
        [TestCase("(:)", false)]
        [TestCase("::(:)", true)]
        [TestCase("(:))", true)]
        [TestCase("(())", true)]
        [TestCase("()()", true)]
        [TestCase(")(", false)]
        [TestCase("(:):):(:::)", false)]
        public void TestBalance(string inputString, Boolean expectedResult)
        {
            Boolean result = BalancedSmileys.AreSmileysBalanced(inputString);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

    }
}
