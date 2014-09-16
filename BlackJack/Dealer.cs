using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Dealer : Person
    {
        public Dealer():base()
        {
        }
       
        public override string AskForAction()
        {
            int[] currentScore = score.CalculateScore(hand);
            return score.HigherScore < 17 ? "hit" : "stay";
        }
    }
}
