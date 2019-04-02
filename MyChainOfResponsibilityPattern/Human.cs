using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyChainOfResponsibilityPattern
{
    class Human : EventHandler
    {
        public override void RespondToEvent(Event theEvent)
        {
            if (theEvent.TypeOfEvent == "Logical")
            {
                Console.WriteLine("Logical event was handled by the human");
            }
            else
            {
                Console.WriteLine("Event was catastrophic");
            }
        }
    }
}
