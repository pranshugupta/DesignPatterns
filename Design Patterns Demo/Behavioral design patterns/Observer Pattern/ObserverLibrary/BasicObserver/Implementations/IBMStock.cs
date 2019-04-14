using BasicObserver.BaseLibrary;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BasicObserver.Implementations
{
    public class IBMStock : Stock
    {
        public IBMStock(string stockName, int price) : base(stockName, price)
        {
            Task.Factory.StartNew(ChangeStockPrices);
        }

        Task ChangeStockPrices()
        {
            Random r = new Random();
            while (true)
            {
                Price += r.Next(-10, 10);
                Thread.Sleep(2000);
            }
        }
    }
}