using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configuration.Exceptions
{
    public class ConfigurationLoadException: Exception
    {
        public ConfigurationLoadException(string message, Exception? innerException)
            : base(message, innerException) { }
    }
}
