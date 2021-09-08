using System;

namespace ATMWebApplication.Controllers
{
    internal class NSAlert
    {
        public NSAlert()
        {
        }

        public object AlertStyle { get; set; }
        public string InformativeText { get; set; }
        public string MessageText { get; set; }

        internal void RunModal()
        {
            throw new NotImplementedException();
        }
    }
}