using AdvancedObserver.Implementations;
using System.Collections.Generic;

namespace AdvancedObserver.BaseLibrary
{
    public interface IObserver
    {
        Dictionary<string, Kid> Kids { get; set; }

        void DailyStatusUpdate(string key);
    }
}
