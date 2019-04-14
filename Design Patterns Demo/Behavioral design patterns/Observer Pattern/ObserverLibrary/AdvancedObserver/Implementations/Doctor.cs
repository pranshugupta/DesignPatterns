using AdvancedObserver.BaseLibrary;
using System;
using System.Collections.Generic;

namespace AdvancedObserver.Implementations
{
    public class Doctor : IObserver
    {
        private Dictionary<string, Kid> _kids = new Dictionary<string, Kid>();

        public Dictionary<string, Kid> Kids
        {
            get { return _kids; }
            set { _kids = value; }
        }

        public void DailyStatusUpdate(string paitientName)
        {
            Console.WriteLine("Doctor:\n\tPatient Name:{0}\n\tUpdated On: {1}\n\tNotes:{2}", Kids[paitientName].Name, Kids[paitientName].Status.UpdatedOn, Kids[paitientName].Status.Description);
        }
    }
}
