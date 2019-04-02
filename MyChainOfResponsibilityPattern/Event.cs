using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyChainOfResponsibilityPattern
{
    class Event
    {
        public string TypeOfEvent { get; set; }


        public Event(string typeOfEvent)
        {
            TypeOfEvent = typeOfEvent;

            Console.WriteLine($"Event has occured of type: {TypeOfEvent}");
        }


    }
}
