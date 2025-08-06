using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.BadArchitecture
{
    internal class UI
    {
        BusinessRules _businessRules;
        public UI (BusinessRules businessRules)
        {
            _businessRules = businessRules;
        }
        public void DisplayHomeScreen()
        {
            List<Person> people = _businessRules.LoadPeople();
            DisplayPeople(people);
        }
        void DisplayPeople(List<Person> people)
        {
            foreach(var person in people)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
}
