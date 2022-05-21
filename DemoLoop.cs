using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
   public class DemoLoop
   {
        public static void PrintForLoop()
        {
            //int n = 5, sum = 0;
            //for (int i=1;i<=n;i++)
            for(int i=0;i<=5;i++)
            {
                //sum += i;
                Console.WriteLine("Value of i: {0}", i);
            }
            //Console.WriteLine("sum of first {0} natural numbers = {1}", n, sum);
        }
   }
}
