using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace HTPTestFlow
{
    class ExecutionTPStart
    {        
        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            Console.ReadLine();
            int a = 1;

            //Console.WriteLine("Select Test Mode: Auto or Manual?");
            //string TestMode = Console.ReadLine();
            //Console.WriteLine($"\nStart in {TestMode} Mode");

            if (a == 1)
            {
                Console.WriteLine("Start in Auto Mode");
                Console.ReadLine();
                Console.WriteLine("TP_START");
                Console.ReadLine();
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("TP_RUN_SELECT");
                Console.ReadLine();
                Console.WriteLine("OK");
            }         
        }
    }
}