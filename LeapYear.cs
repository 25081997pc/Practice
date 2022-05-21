using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class LeapYear
    {
        public static void Year()
        {
             int y;
             Console.WriteLine("Enter the year in four digits : ");
             y=Convert.ToInt32(Console.ReadLine());

            if((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0))
            {
                Console.WriteLine(" {0} is leap year ", y);
            }

            else
            {
                Console.WriteLine(" {0} is not a leap year ", y);
            }

            Console.ReadLine();
        }
    }
}
