using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LineComputations
{
    public class LineComputations
    {
       int xOne, yOne, xTwo, yTwo;
       int xThree,yThree,xFour,yFour;
        public void LengthOfLine()
        {
            Console.WriteLine("Enter the Coordinates of Line1");
            Console.WriteLine("Enter the x1 coordinate");
            xOne=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the x2 Coordinate");
            xTwo=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the y1 Coordinate");
            yOne=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the y2 Coordinate");
            yTwo=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Enter the Coordinates of Line2");
            Console.WriteLine("Enter the x3 coordinate");
            xThree=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the x4 coordinate");
            xFour=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the y3 coordinate");
            yThree=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the y4 coordinates");
            yFour=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-------------------------------------");
            //Calculate the length of Line1
            double LengthOfLineOne = Math.Sqrt((xTwo - xOne)*(xTwo - xOne)+(yTwo - yOne)*(yTwo - yOne));
            Console.WriteLine("Length of Line1 is:" + LengthOfLineOne);
            Console.WriteLine("-------------------------------------");
            
            //Calculate the length of Line2
            double LengthOfLineTwo = Math.Sqrt((xFour - xThree) * (xFour - xThree) + (yFour - yThree) * (yFour - yThree));
            Console.WriteLine("Length of Line2 is:" + LengthOfLineTwo);

            //Check equality of two lines

            if (LengthOfLineOne.Equals(LengthOfLineTwo))
            {
                Console.WriteLine("Length of Line1 and Line2 are Equal");
            }
            else if ((LengthOfLineOne) > (LengthOfLineTwo))
            {
                Console.WriteLine("Length of Line1 is greater than Line2");
            }
            else
            {
                Console.WriteLine("Length of Line2 is greater than Line1");
            }

            }



        }
    }

