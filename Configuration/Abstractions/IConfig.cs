using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Configuration.ValueObjects;

namespace Configuration.Abstractions
{
    public interface IConfig
    {
        public void Open();
        public Config Read();
        public void Close();
    }
}
