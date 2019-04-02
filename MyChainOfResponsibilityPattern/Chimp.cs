using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyChainOfResponsibilityPattern
{
    class Chimp : EventHandler
    {
        public override void RespondToEvent(Event theEvent)
        {
            if (theEvent.TypeOfEvent == "Emotional")
            {
                Console.WriteLine("Emotional event handled by the chimp");
            }
            else if (eventHandler != null)
            {
                eventHandler.RespondToEvent(theEvent);
            }
        }
    }
}
