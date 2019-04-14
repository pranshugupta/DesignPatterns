using System;

namespace SingletonLibrary
{
    //Fourth version - not quite as lazy, but thread-safe without using locks
    public class SingletonThreadSafeWithoutLock
    {
        private static int N0_Of_Instances = 0;
        private static SingletonThreadSafeWithoutLock instance = new SingletonThreadSafeWithoutLock();

        private SingletonThreadSafeWithoutLock()
        {
            Console.WriteLine(string.Format("Class: {0}\t\t Instance: {1}", this.ToString(), ++N0_Of_Instances));
        }

        public static SingletonThreadSafeWithoutLock Instance
        {
            get
            {
                return instance;
            }

        }
    }
}
