using DivisionExample;
using NUnit.Framework;
using System;

namespace ClassLibrary1
{
    [TestFixture]
    public class TestDivision
    {
        [Test]
        public void Dividing6_By2_Gives2()
        {
            //Arrange
            Divider div = new Divider();

            //Act
            int result = div.Divide(6, 2);

            //Assert
            Assert.AreEqual(3, result, "Dividing 6 by 2 does not result in 3.");

        }

    }
}
