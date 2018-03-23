using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Player
    {
        int score;

        public Player()
        {
            score = 0;
        }
        public void IncrementScore()
        {
            score++;
        }
        public int GetScore()
        {
            return score;
        }
    }
}
