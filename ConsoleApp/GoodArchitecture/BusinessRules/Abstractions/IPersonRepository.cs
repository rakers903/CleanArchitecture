using ConsoleApp.GoodArchitecture.BusinessRules.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.GoodArchitecture.BusinessRules.Abstractions
{
    internal interface IPersonRepository
    {
        List<Person> Load();
    }
}
