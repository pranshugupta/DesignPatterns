using System;

namespace SingletonLibrary
{
    //Third version - attempted thread-safety using double-check locking
    //Bad code! Do not use!
    public class SingletonDoubleCheckLocking
    {
        private static int N0_Of_Instances = 0;
        private static SingletonDoubleCheckLocking instance = null;
        private static readonly object lockObject = new object();

        private SingletonDoubleCheckLocking()
        {
            Console.WriteLine(string.Format("Class: {0}\t\t Instance: {1}", this.ToString(), ++N0_Of_Instances));
        }

        public static SingletonDoubleCheckLocking Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new SingletonDoubleCheckLocking();
                        }
                    }
                }
                return instance;
            }

        }
    }
}
