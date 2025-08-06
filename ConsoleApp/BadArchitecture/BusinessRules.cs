using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.BadArchitecture
{
    internal class BusinessRules
    {
        Data _data;
        public BusinessRules(Data data)
        {
            _data = data;
        }
        public List<Person> LoadPeople()
        {
            return _data.SqlQuery();
        }
    }
}
