using DecoratorLibrary.BaseLibrary;

namespace DecoratorLibrary.Decorators
{
    public class Discount: BurgerDecorator
    {
        public Discount(IBurger burger):base(burger, "Discount", -5)
        {

        }
    }
}
