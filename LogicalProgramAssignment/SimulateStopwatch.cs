﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LogicalProgramAssignment
{
    public class SimulateStopwatch
    {
        public  void FindSimulateStopwatchProgram()
        {

            Stopwatch stopwatch = new Stopwatch();


            stopwatch.Start();


            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(1);
            }


            stopwatch.Stop();


            Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
        }
    }
}
