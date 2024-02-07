using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_11_Assignment02
{
    public class Rectangle
    {

        // this is the change to test git
        private int recLength;
        private int recWidth;

        public Rectangle()
        { 
            recLength = 0;
            recWidth = 0;
            //this is the push test
        }

        public Rectangle(int initLength, int initWidth)
        {
            SetLength(initLength);
            SetWidth(initWidth);
        }

        public int GetLength() 
        { 
            return recLength;
        }

        public int GetWidth() 
        { 
            return recWidth;
        }

        public void SetLength(int newLength)
        {
            //if(newLength >= recLength)
            //{
            //    recLength = newLength;
            //}
            //else
            //{
            //    recLength = recLength;
            //}
            recLength = newLength;
        }

        public void SetWidth(int newWidth)
        {
            recWidth = newWidth;

        }

        public int GetPerimeter() 
        { 

            return 2 * (recLength +  recWidth);    
        }

        public int GetArea()
        {
            return recLength * recWidth;
        }

    }
}
