using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Cpuscheduling
{
    class Program
    {
        public static List<string> MainMethodArgs = new List<string>();
        static void Main(string[] args)
        {
            MainMethodArgs = args.ToList();
            Run(MainMethodArgs.ToArray());
        }
        public static void Run(string[] args)
        {
            var obj = new CpuScheduling();
            Console.WriteLine("CPU Scheduling Simulator\n\nEnter[1]:First-Come First-Served\nEnter[2]:Shortest Job First\nEnter[3]:Priority\n\nPlease select an algorithm:");
            string input = Console.ReadLine();
            int m = Convert.ToInt32(input);
            if (input == "1")
            {
                Console.WriteLine("You selected First Come First Served Scheduling");
                obj.FCFS();
            }
            else if (m == 2)
            {
                Console.WriteLine("Shortest Job First Scheduling");
                obj.SJF();
            }
            else if (m == 3)
            {
                Console.WriteLine("Priority Scheduling");
                obj.P();
            }
            else //if (m != 1 || m!=2 || m!=3 )
            {
                Console.WriteLine("\nError 1302: Invalid input\n");
                ReRun();
                //Console.ReadKey();
                //Console.WriteLine("\nPress any key to exit. Run program again.....");
                //Console.ReadKey();
            }
        }
        public static void ReRun()
        {
            Console.WriteLine("Rebuild Log Files;"
            + " Press Enter to close program, or R to restart the program...");
            string restart = Console.ReadLine();
            if (restart.ToUpper() == "R")
            {
                //here the code to restart the console...
                Run(MainMethodArgs.ToArray());
            }
        }
    }
}
