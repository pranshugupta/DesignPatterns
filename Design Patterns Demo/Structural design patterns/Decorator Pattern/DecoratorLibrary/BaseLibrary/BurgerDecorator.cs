namespace DecoratorLibrary.BaseLibrary
{
    public abstract class BurgerDecorator : IBurger
    {
        IBurger _Burger;
        double _MyPrice;
        string _myName;

        public BurgerDecorator(IBurger burger,string myName, double myPrice)
        {
            _Burger = burger;
            _MyPrice = myPrice;
            _myName = myName;

    }
        public string GetName()
        {
            return _myName +" "+ _Burger.GetName();
        }

        public double GetPrice()
        {
           return _Burger.GetPrice()+ _MyPrice;
        }
    }
}
