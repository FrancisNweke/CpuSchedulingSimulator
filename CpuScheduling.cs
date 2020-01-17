using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cpuscheduling
{
    class CpuScheduling
    {
        public void FCFS()
        {
            int[] bp = new int[5];
            int[] wtp = new int[5];
            String[] output1 = new String[10];
            int twt = 0, awt, num;
            for (num = 0; num <= 4; num++)
            {
                Console.WriteLine("\nEnter Burst time for P" + (num + 1) + ":");
                var input = Console.ReadLine();
                bp[num] = Convert.ToInt32(input);
            }
            Console.WriteLine("\nFirst Come First Serve: ");
            for (num = 0; num <= 4; num++)
            {
                if (num == 0)
                {
                    wtp[num] = 0;
                }
                else
                {
                    wtp[num] = wtp[num - 1] + bp[num - 1];
                    output1[num] = "\nWaiting time for P" + (num + 1) + " = " + wtp[num];
                    Console.WriteLine(output1[num]);
                }
            }
            for (num = 0; num <= 4; num++)
            {
                twt = twt + wtp[num];
            }
            awt = twt / 5;
            Console.WriteLine("\nAverage Waiting Time = " + awt);
            Console.ReadLine();
        }

        public void SJF()
        {
            int[] bp = new int[5];
            int[] wtp = new int[5];
            int[] p = new int[5];
            int twt = 0, awt, x, num;
            int temp = 0;
            bool found = false;
            for (num = 0; num <= 4; num++)
            {
                Console.WriteLine("\nEnter Burst time for P" + (num + 1) + ":");
                var input = Console.ReadLine();
                bp[num] = Convert.ToInt32(input);
            }
            for (num = 0; num <= 4; num++)
            {
                p[num] = bp[num];
            }
            for (x = 0; x <= 3; x++)
            {
                for (num = 0; num <= 3; num++)
                {
                    if (p[num] > p[num + 1])
                    {
                        temp = p[num];
                        p[num] = p[num + 1];
                        p[num + 1] = temp;
                    }
                }
            }
            for (num = 0; num <= 4; num++)
            {
                if (num == 0)
                {
                    for (x = 0; x <= 4; x++)
                    {
                        if (p[num] == bp[x] && found == false)
                        {
                            wtp[num] = 0;
                            Console.WriteLine("\nWaiting time for P" + (x + 1) + " = " + wtp[num]);
                            bp[x] = 0;
                            found = true;
                        }
                    }
                    found = false;
                }
                else
                {
                    for (x = 0; x <= 4; x++)
                    {
                        if (p[num] == bp[x] && found == false)
                        {
                            wtp[num] = wtp[num - 1] + p[num - 1];
                            Console.WriteLine ("\nWaiting time for P" + (x + 1) + " = " + wtp[num]);
                            bp[x] = 0;
                            found = true;
                        }
                    }
                    found = false;
                }
            }
            for (num = 0; num <= 4; num++)
            {
                twt = twt + wtp[num];
            }
            Console.WriteLine("\n\nAverage waiting time: " + (awt = twt / 5));
            Console.ReadLine();
        }
        public void P()
        {
            int[] bp = new int[5];
            int[] wtp = new int[6];
            int[] p = new int[5];
            int[] sp = new int[5];
            int twt = 0, awt, x, num;
            int temp = 0;
            bool found = false;
            for (num = 0; num <= 4; num++)
            {
                Console.WriteLine("\nEnter Burst time for P" + (num + 1) + ":");
                var input = Console.ReadLine();
                bp[num] = Convert.ToInt32(input);
            }
            for (num = 0; num <= 4; num++)
            {
                Console.WriteLine("\nEnter Priority for P" + (num + 1) + ":");
                var input2 = Console.ReadLine();
                p[num] = Convert.ToInt32(input2);
            }
            for (num = 0; num <= 4; num++)
            {
                sp[num] = p[num];
            }
            for (x = 0; x <= 3; x++)
            {
                for (num = 0; num <= 3; num++)
                {
                    if (sp[num] > sp[num + 1])
                    {
                        temp = sp[num];
                        sp[num] = sp[num + 1];
                        sp[num + 1] = temp;
                    }
                }
            }
            for (num = 0; num <= 4; num++)
            {
                if (num == 0)
                {
                    for (x = 0; x <= 4; x++)
                    {
                        if (sp[num] == p[x] && found == false)
                        {
                            wtp[num] = 0;
                            Console.WriteLine("\nWaiting time for P" + (x + 1) + " = " + wtp[num]);
                            temp = x;
                            p[x] = 0;
                            found = true;
                        }
                    }
                    found = false;
                }
                else
                {
                    for (x = 0; x <= 4; x++)
                    {
                        if (sp[num] == p[x] && found == false)
                        {
                            wtp[num] = wtp[num - 1] + bp[temp];
                            Console.WriteLine("\nWaiting time for P" + (x + 1) + " = " + wtp[num]);
                            temp = x;
                            p[x] = 0;
                            found = true;
                        }
                    }
                    found = false;
                }
            }
            for (num = 0; num <= 4; num++)
            {
                twt = twt + wtp[num];
            }
            Console.WriteLine("\n\nAverage waiting time: " + (awt = twt / 5));
            Console.ReadLine();
        }    
    }
}
