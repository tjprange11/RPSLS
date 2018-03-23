using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human : Player
    {
        string name;

        public Human(string name)
            : base()
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
    }
}
