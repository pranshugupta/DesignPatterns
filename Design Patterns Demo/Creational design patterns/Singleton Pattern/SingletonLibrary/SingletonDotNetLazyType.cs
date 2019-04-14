using System;

namespace SingletonLibrary
{
    //Sixth version - using .NET 4's Lazy<T> type
    public class SingletonDotNetLazyType
    {
        private static int N0_Of_Instances = 0;
        private static readonly Lazy<SingletonDotNetLazyType> instance = new Lazy<SingletonDotNetLazyType>(()=> new SingletonDotNetLazyType());
        private SingletonDotNetLazyType()
        {
            Console.WriteLine(string.Format("Class: {0}\t\t Instance: {1}", this.ToString(), ++N0_Of_Instances));
        }

        public static SingletonDotNetLazyType Instance
        {
            get { return instance.Value; }
        }
    }
}
