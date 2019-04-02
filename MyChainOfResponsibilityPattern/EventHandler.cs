using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyChainOfResponsibilityPattern
{
    abstract class EventHandler
    {
        protected EventHandler eventHandler;

        public void SetResponder(EventHandler eventHandler)
        {
            this.eventHandler = eventHandler;
        }

        public abstract void RespondToEvent(Event theEvent);
    }
}
