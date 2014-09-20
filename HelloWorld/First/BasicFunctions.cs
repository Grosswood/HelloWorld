using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.First
{
    class BasicFunctions
    {
        static void FirstMain()
        {
//Printing
            Console.WriteLine("Hello World");
            int x = 10;
            int y = 8;
            int result = x + y;
            Console.WriteLine("Result = " + result);
//Complicating printing
            Console.WriteLine("The result of sum {0} and {1} is {2}", x, y, x + y);
//"If" statement
            if (x > y)
            {
                Console.WriteLine("X is greater then Y");
            }
//"For" statement
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("i= " + i);
            }
//"While" loop
            int z = 10;
            while (z > 0) 
            {
                Console.WriteLine("z= " + z);
                z--;
            }
//"Do while" statement
            int a = -10;
            do
            {
                Console.WriteLine("a= " + a);
                a--;
            } while (a > -20);
// "And"operator
            int b = -5;
            int c = 1;
            if (b < 0 && c > 0)
            {
                Console.WriteLine("B is less then 0 and C is greater than 0");
            }
//"Or" Case
            if (b>0 || c>0)
            {
                Console.WriteLine("B or C is greater than 0");
            }
//"Switch" case
                        string j = "Two";

                        switch (j)
                        {
                            case "Zero":
                                Console.WriteLine("The value is 0");
                                break;
                            case "One":
                                Console.WriteLine("The value is 1");
                                break;
                            default:
                                Console.WriteLine("The value is unknown");
                                break;
                        }
        }
    }
}
