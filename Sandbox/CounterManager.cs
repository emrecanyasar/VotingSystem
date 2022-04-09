using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    internal class CounterManager
    {
        public CounterManager(params Counter[] counters)
        {
            Counters = new List<Counter>(counters);
        }
        public List<Counter> Counters { get; set; }
    }
}
