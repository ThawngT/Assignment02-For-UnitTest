using Group_11_Assignment02;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment02.Tests
{
    [TestFixture]

    public class RectangleTest
    {
        [Test]
        //  the length should be zero for the default constructed newly recangle
        public void GetLength_newRectangleWithDefaultConstructor_0()
        {
            //Arrange
            Rectangle rectangle1 = new Rectangle();
            //act
            int length = rectangle1.GetLength();
            //assert
            Assert.That(0, Is.EqualTo(length));


        }
       
    }
}
