using DivisionExample;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DivisionExsample.Test
{
    [TestFixture]
    public class TestSumDouble
    {
        [Test]
        public void SumDouble6Plus2Get8()
        {
            Sumator sum = new Sumator();
            double result = sum.SumDouble(6, 2);
            Assert.AreEqual(8, result, " 6 plus 2 does " +
                "not result in 8.");
        }
    }
}
