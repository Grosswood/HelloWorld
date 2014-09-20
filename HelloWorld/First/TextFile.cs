using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.First
{
    class TextFile
    {
        public static void Main()
        {



            foreach (string line in File.ReadLines(@"c:\temp\GuessNumberByHuman.txt"))
            {
                Console.WriteLine(line);
            }
                


            /*Console.WriteLine("Please enter your initials for the table of records");
            int a = 5;
            using (StreamWriter writer = new StreamWriter(@"c:\temp\GuessNumberByHuman.txt", true))
            {
                writer.Write(Console.ReadLine());
                writer.Write(" ");
                writer.WriteLine(a);
            }*/
        }
    }
}
