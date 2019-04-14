using DecoratorLibrary.BaseLibrary;

namespace DecoratorLibrary.Decorators
{
    public class HamBurger: BurgerDecorator
    {
        public HamBurger(IBurger burger):base(burger, "Ham", 50)
        {

        }
    }
}
