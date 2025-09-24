using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BasicThreading
{
    // 2. Create a class named MyThreadClass. Inside the class, declare a static method named Thread1.
    internal class MyThreadClass
    {
        public static void Thread1()
        {
            // 3. Create a loop that terminates the thread in the fifth attempt.
            // Suspend the current thread for 1.5 seconds
            for (int loopCount = 0; loopCount <= 5; loopCount++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + loopCount);

                Thread.Sleep(1500);

                if (loopCount == 5)
                {
                    break;
                }

            }
        }
    }
}
