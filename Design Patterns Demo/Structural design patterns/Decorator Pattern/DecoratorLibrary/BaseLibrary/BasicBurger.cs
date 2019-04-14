namespace DecoratorLibrary.BaseLibrary
{
    public class BasicBurger : IBurger
    {
        public string GetName()
        {
            return "Burger";
        }

        public double GetPrice()
        {
            return 100;
        }
    }
}
