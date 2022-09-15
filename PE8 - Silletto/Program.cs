/* Rose Silletto
*  IGME-201 PE8 More Variables
*  September 14, 2022
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * Given the formula z = 3y^2 + 2x - 1 write a console application to calculate z 
             * for the following ranges of x and y:
             * -1 <= x <= 1 in 0.1 increments
             * 1 <= y <= 4 in 0.1 increments
             * Use a 3-dimensional array double[,,] to store the values of x, y and z for each computation.
             */

            double x;
            double y;
            double z;
            int nx = 0;
            int ny = 0;
            
            double[,,] myArray = new double[21, 31, 3];

            for (x = -1; x <= 1; x++)
            {
                x = Math.Round(x, 1);

                for (y = 1; y <= 4; y++)
                {
                    y = Math.Round(y, 1);

                    z = (3 *(Math.Pow(y, 2)) + (2*x) - 1);

                    z = Math.Round(z, 1);

                    myArray[nx, ny, 0] = x;
                    myArray[nx, ny, 1] = y;
                    myArray[nx, ny, 2] = z;

                    ny++;
                }

                nx++;

                nx = 0;
            }

        }
    }
}
