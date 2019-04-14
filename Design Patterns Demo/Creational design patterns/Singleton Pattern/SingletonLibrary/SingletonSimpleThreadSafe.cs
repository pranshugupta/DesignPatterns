using System;

namespace SingletonLibrary
{
    //Second version - simple thread-safety
    //Locking on objects which other classes can access and lock on(such as the type) risks performance issues and even deadlocks
    public class SingletonSimpleThreadSafe
    {
        private static int N0_Of_Instances = 0;
        private static SingletonSimpleThreadSafe instance = null;
        private static readonly object lockObject = new object();

        private SingletonSimpleThreadSafe()
        {
            Console.WriteLine(string.Format("Class: {0}\t\t Instance: {1}", this.ToString(), ++N0_Of_Instances));
        }

        public static SingletonSimpleThreadSafe Instance
        {
            get
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new SingletonSimpleThreadSafe();
                    }
                    return instance;
                }
            }

        }
    }
}
