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
        public int recLength;
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
            if (newLength >=0  && newLength<=2300)
            {
                recLength = newLength;
            }
            else
            {
                recLength = 0;
            }
           
        }

        public void SetWidth(int newWidth)
        {
            if (newWidth >=0 && newWidth<=2300)
            {
                recWidth = newWidth;
            }
            else
            {
                recWidth = 0;
            }
            
           

        }

        public int GetPerimeter() 
        {

            return 2*( recLength + recWidth );
        }

        public int GetArea()
        {

            return recLength * recWidth;
        }

    }
}
