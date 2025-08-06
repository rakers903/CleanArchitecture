using ConsoleApp.GoodArchitecture.BusinessRules.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.GoodArchitecture.Presentation
{
    internal class DevelopmentUserInterface : IUserInterface
    {
        public void DisplayMessage(string message)
        {
            Console.WriteLine("Using Development UI");
            Console.WriteLine(message);
        }
    }
}
