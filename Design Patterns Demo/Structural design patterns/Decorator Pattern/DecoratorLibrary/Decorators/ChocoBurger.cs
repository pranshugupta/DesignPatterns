using DecoratorLibrary.BaseLibrary;

namespace DecoratorLibrary.Decorators
{
    public class ChocoBurger : BurgerDecorator
    {
        public ChocoBurger(IBurger burger):base(burger, "Choco", 10)
        {

        }
    }
}
