using System;

namespace Fundamentals
{
    public class NameChangedEventArgs: EventArgs
    {
        public string ExistingName
        {
            get;
            set;
        }

        public string NewName
        {
            get;
            set;
        }
    }
}
