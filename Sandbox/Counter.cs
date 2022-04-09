using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class Counter
    {
       public Counter(string name, int count)
        {
            Name = name;
            Count = count;
        }
        
        public string Name { get; set; }
        public int Count { get;  }

        public double GetPercent(int total)
        {
            return Math.Round(Count * 100.0 / total, 2);
        }

    }
}
