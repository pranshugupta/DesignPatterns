using System;

namespace SingletonLibrary
{
    //First version - not thread-safe
    //Bad code! Do not use!
    public class SingletonNotThreadSafe
    {
        private static int N0_Of_Instances = 0;
        private static SingletonNotThreadSafe instance = null;

        private SingletonNotThreadSafe()
        {
            Console.WriteLine(string.Format("Class: {0}\t\t Instance: {1}", this.ToString(), ++N0_Of_Instances));
        }

        public static SingletonNotThreadSafe Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SingletonNotThreadSafe();
                }
                return instance;
            }

        }
    }
}
