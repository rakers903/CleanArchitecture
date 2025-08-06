using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.GoodArchitecture.BusinessRules.Abstractions;

namespace ConsoleApp.GoodArchitecture.Presentation
{
    internal class ProductionUserInterface : IUserInterface
    {
        public void DisplayMessage(string message)
        {
            Console.WriteLine("Using Production UI");
            Console.WriteLine(message);
        }
    }
}
