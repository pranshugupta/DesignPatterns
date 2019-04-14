using DecoratorLibrary.BaseLibrary;

namespace DecoratorLibrary.Decorators
{
    public class CheezeBurger: BurgerDecorator
    {
        public CheezeBurger(IBurger burger):base(burger, "Cheeze", 20)
        {

        }
    }
}
