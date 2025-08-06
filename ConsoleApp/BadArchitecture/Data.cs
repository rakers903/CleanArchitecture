using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.BadArchitecture
{
    internal class Data
    {
        internal List<Person> SqlQuery()
        {
            return new()
            {
                new("Simon"),
                new("Robert"),
                new("Akers")
            };
        }
    }
}
