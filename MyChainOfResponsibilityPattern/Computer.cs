using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyChainOfResponsibilityPattern
{
    class Computer : EventHandler
    {
        public override void RespondToEvent(Event theEvent)
        {
            if (theEvent.TypeOfEvent == "Habit")
            {
                Console.WriteLine("Habit recognised and is handled by the computer");
            }
            else if(eventHandler != null)
            {
                eventHandler.RespondToEvent(theEvent);
            }
        }
    }
}
