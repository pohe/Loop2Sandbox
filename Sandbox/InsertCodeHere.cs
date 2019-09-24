using System;
using System.Runtime.Remoting.Channels;

namespace Sandbox
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line
            //int blankSpace = 0;
            int row = 1;
            while (row <= 10)
            {
                //blankSpace = 1;
                //while (blankSpace < row)
                //{
                //    Console.Write(" ");
                //    blankSpace++;
                //}
                for (int blankSpace = 1; blankSpace < row; blankSpace++)
                {
                    Console.Write(" ");
                }
                int col = 1;
                while (col <= 11 - row)
                {
                    Console.Write((col % 2 == 0)? "|": "*");
                    //if (col%2==0)
                    //    Console.Write("|");
                    //else
                    //{
                    //    Console.Write("*");
                    //}
                    col++;
                }
                Console.WriteLine();
                row++;
            }


            Console.WriteLine("Hello world!");

            // The LAST line of code should be ABOVE this line
        }
    }
}