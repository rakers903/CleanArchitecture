using ConsoleApp.GoodArchitecture.BusinessRules.Abstractions;
using ConsoleApp.GoodArchitecture.BusinessRules.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.GoodArchitecture.Data
{
    internal class ProductionPersonRepository : IPersonRepository
    {
        public List<Person> Load()
        {
            return new()
            {
                new("Production Person 1"),
                new("Production Person 2"),
                new("Production Person 3")
            };
        }
    }
}
