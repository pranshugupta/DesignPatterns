using System;

namespace SingletonLibrary
{
    //Fifth version - fully lazy instantiation
    public class SingletonFullyLazy
    {
        private static int N0_Of_Instances = 0;
        public SingletonFullyLazy()
        {
            Console.WriteLine(string.Format("Class: {0}\t\t Instance: {1}",this.ToString(), ++N0_Of_Instances));
        }
        public SingletonFullyLazy Instance
        {
            get
            {
                return NestedClass.instance;
            }
        }

        private class NestedClass
        {
            internal static readonly SingletonFullyLazy instance = new SingletonFullyLazy();
        }

    }
}
