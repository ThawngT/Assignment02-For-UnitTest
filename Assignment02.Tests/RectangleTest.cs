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
        //***Length***
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

        // Assign length value to default value when input is negative value

        [Test]
        public void SetLength_NegativeInput_AssignDefaultValue()
        {
            Rectangle rect = new Rectangle();

            rect.SetLength(-1);

            int length = rect.GetLength();

            Assert.That(0, Is.EqualTo(length));
        }

        // When the length has over max value input
        [Test]
        public void SetLength_AboveMaxValueInput()
        {
            Rectangle rect = new Rectangle();

            rect.SetLength(2340);
            int actualLength = rect.GetLength();

            Assert.That(0, Is.EqualTo(actualLength));
        }

        //****Width****

        // Valid input with valid range 0-2300
        [Test]
        public void SetWidth_InputValidRange0_2300()
        {
            //Arrange
            Rectangle rect = new Rectangle();
            //Act
            rect.SetWidth(6);

            int actualWidth = rect.GetWidth();

            //Assert
            Assert.That(6, Is.EqualTo(actualWidth));
        }

        // When a SetWidth has negative input

        [Test]
        public void SetWidth_NegativeInput_AssignDefaultValue()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();

            //Act
             rectangle.SetWidth(-2);
            int width = rectangle.GetWidth();

            // Assert
            Assert.That(0, Is.EqualTo(width));

        }

        // When the width has over max value input
        [Test]
        public void SetWidth_AboveMaxValueInput()
        {
            Rectangle rect = new Rectangle();

            rect.SetWidth(2340);
            int actualWidth = rect.GetWidth();

            Assert.That(0, Is.EqualTo(actualWidth));
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

        //test#4 Having Maximun value on both length and width
        [Test]
        public void PerimeterWith_MaxLengthAndWidth_ReturnValidPerimeter()
        {
            //Arrange
            Rectangle rect = new Rectangle(2300,2300);

            //Act
            int expectedPerimeter = rect.GetPerimeter();
            
            //Assert
            Assert.That(9200, Is.EqualTo(expectedPerimeter));   
        }

        // Test#5 Having minumum value on both input

        [Test]
        public void PerimeterWith_MinValueInput_0_0()
        {
            Rectangle rectangle = new Rectangle(0,0);
            

            //Act
            int expectedPerimeter = rectangle.GetPerimeter();

            //Assert
           
            Assert.That(0, Is.EqualTo(expectedPerimeter));


        }

        // Test#6 Having Width value 0 and return valid perimeter

        [Test]
        public void PerimeterWith_ZeroWidthAndReturnValidPerimeter()
        {
            //Arrange
            Rectangle rect = new Rectangle(0, 6);

            //Act
            int expectedPerimeter = (int)rect.GetPerimeter();

            //Assert
            Assert.That(12, Is.EqualTo(expectedPerimeter));
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
        // test2: area should be 0 if any of the one value is more than 2300
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

        //test#4 Having Maximun value on both length and width
        [Test]
        public void AreaWith_MaxLengthAndWidth_ReturnValidArea()
        {
            //Arrange
            Rectangle rect = new Rectangle(2300, 2300);

            //Act
            int expectedArea = rect.GetArea();

            //Assert
            Assert.That(5290000, Is.EqualTo(expectedArea));
        }

        // Test#5 Having minumum value on both input

        [Test]
        public void AreaWith_MinValueInput_0_0()
        {
            Rectangle rectangle = new Rectangle(0, 0);


            //Act
            int expectedArea = rectangle.GetArea();

            //Assert

            Assert.That(0, Is.EqualTo(expectedArea));


        }
    }
}
