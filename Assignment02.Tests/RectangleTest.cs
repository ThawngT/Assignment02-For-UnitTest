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
        //test for the get length 
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
        [Test]
        //test for the set length 
        //  the length should be exact as expected
        public void SetLength_lengthIs05_5()
        {
            // Arrange
            Rectangle rectangle = new Rectangle();

            // Act
            rectangle.SetLength(5);
            int length = rectangle.GetLength();

            // Assert
            Assert.That(5, Is.EqualTo(length));


        }
        [Test]
        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@    PERIMETER @@@@@@@@@@@@@@@@@@@@@@@
        // test1--- THE Default parameter should be zero
        public void GetPerimeter_DefaultValue_0()
        {
            //Arrange
            Rectangle rectangle1 = new Rectangle();
            //act
            int perimeter = rectangle1.GetPerimeter();
            //assert
            Assert.That(0, Is.EqualTo(perimeter));


        }

        // test 2- the parameter with given values should be exact

        [Test]

        public void GetPerimeter_CorrectValueLength1width2_6()
        {
            //Arrange
            Rectangle rectangle1 = new Rectangle(1,2);
            //act
            int perimeter = rectangle1.GetPerimeter();
            //assert
            Assert.That(6, Is.EqualTo(perimeter));



        }
        // test 3 parameter-- the maximum value of the length/weidth should be 2300 so the parameter of the anyrectangle havong morre leght or bredth
        // than this should be zero
        [Test]
        public void GetPerimeter_putValueMoreThan2300_0()
        {
            //Arrange
            Rectangle rectangle1 = new Rectangle(2400, 2500);
            //act
            int perimeter = rectangle1.GetPerimeter();
            //assert
            Assert.That(0, Is.EqualTo(perimeter));


        }





        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@  AREA  @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
        //Test1,Area,checkTheCorrectValue



        [Test]
        public void GetArea_putlenght2Bredth4_8()
        {
            // Arrange
            Rectangle rectangle1 = new Rectangle(2, 4);

            // Act
            int area = rectangle1.GetArea();

            // Assert
            Assert.That(8, Is.EqualTo(area));
        }
        // test2: area should be 0 if any of the one vlaue is more than 2300
        [Test]
        public void GetArea_PutWidthMoreThanMaximumValue_0()
        {
            // Arrange
            Rectangle rectangle1 = new Rectangle(2300, 2500);

            // Act
            int area = rectangle1.GetArea();

            // Assert
            Assert.That(0, Is.EqualTo(area));
        }

        // test3: area of negativenumber should be zero
        [Test]
        public void GetArea_PutNegativeValue_0()
        {
            // Arrange
            Rectangle rectangle1 = new Rectangle(-2300, 25);

            // Act
            int area = rectangle1.GetArea();

            // Assert
            Assert.That(0, Is.EqualTo(area));
        }
    }
}
