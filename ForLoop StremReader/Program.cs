using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop_StremReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======= For Loop ============");

            StreamReader sr = new StreamReader(@"..\..\Program.cs");

            int i = 0;

            for (string line =sr.ReadLine(); line !=null ; line=sr.ReadLine() )
            {
                Console.WriteLine($"{++i:000}  {line}");
            }
            sr.Close();

            Console.WriteLine("============ While Loop ===================");

            StreamReader sr1 = new StreamReader(@"..\..\Program.cs");

            int j = 0;
            string line1 = sr.ReadLine();
            while(line1 != null)
            {
                Console.WriteLine($"{++i:000}  {line1}");
                line1 = sr1.ReadLine();
            }
            sr1.Close();

            Console.ReadKey();

        }//Main
    }//Class
}//Namespace
