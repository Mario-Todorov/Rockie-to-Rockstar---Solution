using System;

namespace Rockie_to_Rockstar___Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // Here is half the height of the logo. It is used in the cycles below.
            int halfHeight = (n + 1) / 2;

            int dashesAtTheEdgeCount = n;
            int dashesInTheMiddleCount = n;
            int starsCount = n;

            // Here is the top of the logo.
            for (int i = 1; i <= halfHeight; i++)
            {
                string dashesAtTheEdge = new string('-', dashesAtTheEdgeCount);
                string stars = new string('*', starsCount);
                string dashesInTheMiddle = new string('-', dashesInTheMiddleCount);

                Console.WriteLine("{0}{1}{2}{1}{0}{0}{1}{2}{1}{0}", dashesAtTheEdge, stars,
                dashesInTheMiddle);

                dashesAtTheEdgeCount -= 1;
                starsCount += 2;
                dashesInTheMiddleCount -= 2;
                
            }

            // Here the values ​​are overwritten to be used for the bottom of the logo.
            dashesAtTheEdgeCount = n / 2;
            starsCount = n;
            dashesInTheMiddleCount = 1;

            int starsInTheMiddleCount = 2 * n - 1;

            // Here is the bottom of the logo.
             for (int i = 1; i <= halfHeight; i++)
            {
                string dashesAtTheEdge = new string('-', dashesAtTheEdgeCount);
                string stars = new string('*', starsCount);
                string dashesInTheMiddle = new string('-', dashesInTheMiddleCount);
                string starsInTheMiddle = new string('*', starsInTheMiddleCount);

                Console.WriteLine("{0}{1}{2}{3}{2}{1}{0}{0}{1}{2}{3}{2}{1}{0}", dashesAtTheEdge,
                stars, dashesInTheMiddle, starsInTheMiddle);

                dashesAtTheEdgeCount -= 1;
                dashesInTheMiddleCount += 2;
                starsInTheMiddleCount -= 2;
                
            }

        }
    }
}