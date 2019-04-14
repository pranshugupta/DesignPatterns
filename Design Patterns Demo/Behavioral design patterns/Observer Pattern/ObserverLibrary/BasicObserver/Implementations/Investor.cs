using BasicObserver.BaseLibrary;
using System;

namespace BasicObserver.Implementations
{
    public class Investor : IInvestor
    {
        string _Name;

        public Investor(string name)
        {
            _Name = name;
        }
        public void Update(Stock stock)
        {
            Console.WriteLine("To {0}:\t{1} - Price {2}", _Name, stock.StockName, stock.Price);
        }
    }
}
