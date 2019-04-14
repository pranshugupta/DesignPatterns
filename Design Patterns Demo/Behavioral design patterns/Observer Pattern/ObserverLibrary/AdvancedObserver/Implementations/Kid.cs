using AdvancedObserver.BaseLibrary;
using System;

namespace AdvancedObserver.Implementations
{
    public class Kid : Subject
    {
        Status _Status;
        public Status Status
        {
            get { return _Status; }
            set
            {
                _Status = value;
                Notify(Name);
            }
        }
        public string Name { get; set; }

        public Kid(string name)
        {
            Name = name;
        }
    }

    public class Status
    {
        public string Description { get; set; }
        public DateTime UpdatedOn { get; set; }

        public Status(string notes)
        {
            Description = notes;
            UpdatedOn = DateTime.Now;
        }
    }
}
