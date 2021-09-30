using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateCodes
{
    class State
    {
        public string Code { get; set; }
        public string Name { get; set; }

        public State(string Code, string Name)
        {
            this.Code = Code;
            this.Name = Name;
        }
    }
}
