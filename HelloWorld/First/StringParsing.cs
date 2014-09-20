using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.First
{
    class StringParsing
    {
        public static int Input(string input)
        {
            int number = 0;
            int.TryParse(input, out number);
            while (number == 0)
            {
                Console.WriteLine("You've entered invalid value, please enter valid one");
                int.TryParse(Console.ReadLine(), out number);
            }
            return number;
        }
        
        
        
        public static void SecondMain()
        {
            int var1 = Input(Console.ReadLine());
            Console.WriteLine(var1);
            //Console.WriteLine("String to int32");
            //int.TryParse(Console.ReadLine(), out var1);
            //Console.WriteLine(var1);
            
        }
    }
}
