using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyChainOfResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            EventHandler computer = new Computer();
            EventHandler chimp = new Chimp();
            EventHandler human = new Human();

            computer.SetResponder(chimp);
            chimp.SetResponder(human);

            Event logical = new Event("Logical");
            computer.RespondToEvent(logical);

            Event emotional = new Event("Emotional");
            computer.RespondToEvent(emotional);

            Event habit = new Event("Habit");
            computer.RespondToEvent(habit);

            Console.ReadLine();
        }
    }
}
