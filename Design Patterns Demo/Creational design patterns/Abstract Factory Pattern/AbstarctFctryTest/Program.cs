using AbstractFactryLib.Client;
using AbstractFactryLib.FactoryLibrary;
using System;

namespace AbstarctFctryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalWorld world = new AnimalWorld(new AsiaContinentFactory());
            world.RunFoodChain();

            Console.ReadKey();
        }
    }
}


//public interface IMale { }
//public interface IFemale { }
//public interface IAgentFactory
//{
//    IMale CreateMale();
//    IFemale CreateFemale();
//}

//public class Smart_Male : IMale { }
//public class Tough_Male : IMale { }

//public class Smart_Female : IFemale { }
//public class Tough_Female : IFemale { }

//public class IndoorFactory : IAgentFactory
//{
//    public IMale CreateMale() { return new Smart_Male(); }
//    public IFemale CreateFemale() { return new Smart_Female(); }
//}
//public class OutdoorFactory : IAgentFactory
//{
//    public IMale CreateMale() { return new Tough_Male(); }
//    public IFemale CreateFemale() { return new Tough_Female(); }
//}


//public static void main()
//{
//    IAgentFactory factory = new IndoorFactory();
//    IMale agentA = factory.CreateMale();
//}