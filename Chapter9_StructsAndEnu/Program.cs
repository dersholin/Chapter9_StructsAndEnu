using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter9_StructsAndEnu
{
    class Program
    {
        static void doWork()
        {
            Month first = Month.January;
            Console.WriteLine(first);
            first++;
            Console.WriteLine(first);
            first++;
            Console.WriteLine(first);
            first++;
            Console.WriteLine(first);
            first++;
            Console.WriteLine(first);
            first++;
            Console.WriteLine(first);
            first++;
            Console.WriteLine(first);
            first++;
            Console.WriteLine(first);
            first++;
            Console.WriteLine(first);
            first++;
            Console.WriteLine(first);
            first++;
            Console.WriteLine(first);
            first++;
            Console.WriteLine(first);
            first++;
            Console.WriteLine(first);
            first++;
            Console.WriteLine(first);
        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
