using AdvancedObserver.BaseLibrary;
using System;
using System.Collections.Generic;

namespace AdvancedObserver.Implementations
{
    public class Parent : IObserver
    {
        private Dictionary<string, Kid> _kids = new Dictionary<string, Kid>();

        public Dictionary<string, Kid> Kids
        {
            get { return _kids; }
            set { _kids = value; }
        }

        public void DailyStatusUpdate(string key)
        {
            Console.WriteLine("Parent:\n\tKid Name:{0}\n\tUpdated On: {1}\n\tNotes:{2}", Kids[key].Name, Kids[key].Status.UpdatedOn, Kids[key].Status.Description);
        }
    }
}
