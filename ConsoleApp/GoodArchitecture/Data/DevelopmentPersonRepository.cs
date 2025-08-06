using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.GoodArchitecture.BusinessRules.Abstractions;
using ConsoleApp.GoodArchitecture.BusinessRules.Entities;

namespace ConsoleApp.GoodArchitecture.Data
{
    internal class DevelopmentPersonRepository : IPersonRepository
    {
        public List<Person> Load()
        {
            return new()
            {
                new("Development Person 1"),
                new("Development Person 2"),
                new("Development Person 3")
            };
        }
    }
}
