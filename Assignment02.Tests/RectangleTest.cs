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
        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@   get length  @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
        //  the length should be zero for the default rectangle
        public void GetLength_DefaultLength_0()
        {
            //Arrange
            Rectangle rectangle1 = new Rectangle();
            //act
            int length = rectangle1.GetLength();
            //assert
            Assert.That(0, Is.EqualTo(length));


        }
        [Test]
        // length should be 5 if set to 5
        public void GetLength_UseTheConstructorToGetLength5_5()
        {
            //Arrange
            Rectangle rectangle1 = new Rectangle(5,2);
            //act
            int length = rectangle1.GetLength();
            //assert
            Assert.That(5, Is.EqualTo(length));


        }


        [Test]
        // negative value of length should give 0
        public void GetLength_putNegativeValueInConstructor_0()
        {
            //Arrange
            Rectangle rectangle1 = new Rectangle(-5, 2);
            //act
            int length = rectangle1.GetLength();
            //assert
            Assert.That(0, Is.EqualTo(length));


        }



        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@    set length   @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
        //  the length should be exact as expected
        [Test]
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
        // the length should not be set more than 2300 
        [Test]
        public void SetLength_SetLengthTo2301_0()
        {
            // Arrange
            Rectangle rectangle = new Rectangle();

            // Act
            rectangle.SetLength(2301);
            int length = rectangle.GetLength();

            // Assert
            Assert.That(0, Is.EqualTo(length));


        }
        // the length should not be set to negative number
        [Test]
        public void SetLength_lengthIsNegative1_0()
        {
            // Arrange
            Rectangle rectangle = new Rectangle();

            // Act
            rectangle.SetLength(-1);
            int length = rectangle.GetLength();

            // Assert
            Assert.That(0, Is.EqualTo(length));


        }



        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@   GET WIDTH @@@@@@@@@@@@@@@@@@@

        //  the width should be zero for the default rectangle
        [Test]
        public void GetWidth_DefaultLength_0()
        {
            //Arrange
            Rectangle rectangle1 = new Rectangle();
            //act
            int Width = rectangle1.GetWidth();
            //assert
            Assert.That(0, Is.EqualTo(Width));


        }

        // after using the second constructor width should be as provided
        [Test]
        public void GetWidth_UseTheConstructorToGetWidth5_5()
        {
            //Arrange
            Rectangle rectangle1 = new Rectangle(2, 5);
            //act
            int Width = rectangle1.GetWidth();
            //assert
            Assert.That(5, Is.EqualTo(Width));


        }
        [Test]
        // negative value of width should give 0
        public void GetWidth_putNegativeValueInConstructor_0()
        {
            //Arrange
            Rectangle rectangle1 = new Rectangle(5, -2);
            //act
            int Width = rectangle1.GetWidth();
            //assert
            Assert.That(0, Is.EqualTo(Width));


        }

        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@   SET Width @@@@@@@@@@@@@@@@@@@@@@
        //  the width should be exact as expected
        [Test]
        public void SetWidth_widthIs05_5()
        {
            // Arrange
            Rectangle rectangle = new Rectangle();

            // Act
            rectangle.SetWidth(5);
            int width = rectangle.GetWidth();

            // Assert
            Assert.That(5, Is.EqualTo(width));


        }
        // the width should not be set more than 2300 
        [Test]
        public void SetWidth_SetWidthTo2500_0()
        {
            // Arrange
            Rectangle rectangle = new Rectangle();

            // Act
            rectangle.SetWidth(2500);
            int Width = rectangle.GetWidth();

            // Assert
            Assert.That(0, Is.EqualTo(Width));


        }
        // the width should not be set to negative number
        [Test]
        public void SetWidth_WidthIsNegative5_0()
        {
            // Arrange
            Rectangle rectangle = new Rectangle();

            // Act
            rectangle.SetWidth(-5);
            int width = rectangle.GetWidth();

            // Assert
            Assert.That(0, Is.EqualTo(width));


        }


        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@    PERIMETER @@@@@@@@@@@@@@@@@@@@@@@
        // test1--- THE Default parameter should be zero
        [Test]
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
