using System;
using System.Collections.Generic;   // must have this using statement in order to use collections

namespace StateCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            var states = new List<State>()
            {
                new State("OH","Ohio"),
                new State("KY","Kentucky"),
                new State("IN", "Indiana"),
                new State("IL", "Illinois")
            };


            //var state1 = new State("OH","Ohio");
            //states.Add(state1);
            //var stateky = new State("KY", "Kentucky");
            //states.Add(stateky);

            //states.Add( new State("IN", "Indiana") );

            foreach (var state in states)
            {
                Console.WriteLine($"The Code is: {state.Code} The State is {state.Name}");
            }

            //var statecodes = new Dictionary<string, string>();
            //statecodes.Add("OH", "Ohio");
            //statecodes.Add("IN", "Indiana");
            //statecodes.Add("KY", "Kentucky");

            //var ohio = statecodes["OH"];
            //Console.WriteLine(ohio);
        }
    }
}
