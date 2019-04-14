using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SingletonLibrary;
using System.Threading;

namespace SingletonTestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Choose Instace Creatin Class:\n\t1. SingletonNotThreadSafeInstances.\n\t2.SingletonSimpleThreadSafeInstances.\n\t3.SingletonDoubleCheckLockingInstances.\n\t4.SingletonThreadSafeWithoutLockInstances.\n\t5.SingletonFullyLazyInstances.\n\t6.SingletonDotNetLazyTypeInstances.\nOption:");
            string instanceType = Console.ReadLine();
            Console.Write("\nNo of Instances To be Created:");
            string intancesNumber = Console.ReadLine();
            int option = 0, noOfInstances;
            if (Int32.TryParse(instanceType, out option) && Int32.TryParse(intancesNumber, out noOfInstances))
            {
                InstanceCreator instanceCreator = new InstanceCreator();
            }
            
            Console.ReadKey();
        }
    }

    public class InstanceCreator
    {
    }
}