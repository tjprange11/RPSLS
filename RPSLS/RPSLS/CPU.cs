using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class CPU : Player
    {
        public CPU()
            :base()
        {
            
        }
        public void MakeChoice(List<string> choices)
        {
            Random rnd = new Random();
            string temporary = choices.ElementAt(rnd.Next(0, choices.Count));
            base.SetChoice(temporary);
        }
    }
}
