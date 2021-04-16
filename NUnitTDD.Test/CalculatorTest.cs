using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTDD.Test
{
    [TestFixture]
    public class CalculatorTest
    {
        [Test]
        public void MustAdd()
        {
            var sut = new Calculator();

            var result = sut.Sum(15, 5);

            Assert.That(result, Is.EqualTo(20));
        }

        [Test]
        public void MustMultiply()
        {
            var sut = new Calculator();

            var result = sut.Multiply(15, 5);

            Assert.That(result, Is.EqualTo(75));
        }
    }
}
