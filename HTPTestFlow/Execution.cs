using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace HTPTestFlow
{
    class Execution
    {        
        static void Main(string[] args)
        {
            Console.WriteLine("Ready to Start\n");     
            Console.WriteLine("Select Test Mode: Auto or Manual:");
            string TestMode = Console.ReadLine();
            if (TestMode == "Auto")
            {
                Console.WriteLine("\nStart in Auto Mode\n");
                Console.WriteLine("TP_START\n");
                Console.WriteLine("OK\n");
                Console.WriteLine("Select Test Method: DO or Run?\n");
                string TestMethod = Console.ReadLine();
                if (TestMethod == "Do")
                {
                    Console.WriteLine("\nTP_GROUP_START\n");
                    Console.WriteLine("OK\n");
                }
                else if (TestMethod == "Run")
                {
                    Console.WriteLine("OK\n");
                }
                Console.WriteLine("TP_METHOD_START\n");
                Console.WriteLine("TP_METHOD_END\n");
                Console.WriteLine("TP_END\n");
            }
            else if(TestMode == "Manual")
            {
                Console.WriteLine("\nTP_RUN_SELECT\n");
                Console.WriteLine("OK\n");
                Console.WriteLine("Select Test Method: DO or Run?\n");
                string TestMethod = Console.ReadLine();
                if (TestMethod == "Do")
                {
                    Console.WriteLine("\nTP_GROUP_START\n");
                    Console.WriteLine("OK\n");
                }
                else if (TestMethod == "Run")
                {
                    Console.WriteLine("OK\n");
                }
                Console.WriteLine("TP_METHOD_START\n");
                Console.WriteLine("TP_METHOD_END\n");
                Console.WriteLine("TP_SELECT_END\n");
            }         
        }
    }
}