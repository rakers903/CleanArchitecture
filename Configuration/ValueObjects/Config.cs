using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configuration.ValueObjects
{
    public record class Config
    {
        public string? AppName { get; init; }
        public string? Environment { get; init; }
        public string? FileType { get; init; }
    }
}
