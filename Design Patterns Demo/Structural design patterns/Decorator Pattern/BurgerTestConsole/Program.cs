using DecoratorLibrary.BaseLibrary;
using DecoratorLibrary.Decorators;
using System;

namespace BurgerTestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            IBurger burger1 = new BasicBurger();    //100
            PrintNameAndPrice(burger1);

            burger1 = new HamBurger(burger1);   //100+50
            PrintNameAndPrice(burger1);

            burger1 = new CheezeBurger(burger1);    //100+50+20
            PrintNameAndPrice(burger1);

            burger1 = new ChocoBurger(burger1);     //100+50+20+10
            PrintNameAndPrice(burger1);

            burger1 = new Discount(burger1);    //100+50+20+10-5
            PrintNameAndPrice(burger1);

            Console.ReadKey();
        }

        static void PrintNameAndPrice(IBurger burger)
        {
            Console.WriteLine("Name: {0} - Price: {1}", burger.GetName(), burger.GetPrice());
        }
    }
}
