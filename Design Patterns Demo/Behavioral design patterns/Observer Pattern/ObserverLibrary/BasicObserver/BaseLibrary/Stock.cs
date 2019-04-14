using System;
using System.Collections.Generic;

namespace BasicObserver.BaseLibrary
{
    public abstract class Stock
    {
        List<IInvestor> _Investors;
        string _StockName;
        int _Price;

        public Stock(string stockName, int price)
        {
            _StockName = stockName;
            _Price = price;

            _Investors = new List<IInvestor>();
        }
        public string StockName
        {
            get { return _StockName; }
            set
            {
                _StockName = value;
            }
        }
        public int Price
        {
            get { return _Price; }
            set
            {
                _Price = value;
                Notify();
            }
        }

        public void Notify()
        {
            Console.WriteLine(string.Format("!--------------------New {0} Price: {1}------------------------!", _StockName, _Price));
            foreach (var investor in _Investors)
            {
                investor.Update(this);
            }
        }

        public void Subscribe(IInvestor investor)
        {
            _Investors.Add(investor);
        }

        public void UnSubscribe(IInvestor investor)
        {
            _Investors.Remove(investor);
        }
    }
}
