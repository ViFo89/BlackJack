using System.Collections.Generic;

namespace BlackJack
{
    public abstract class Person
    {
        protected Hand hand;
        protected Score score;
        protected static int counter = 0;

        protected int _name;
        
            public int Name{
            get { return _name; }
        }

        protected Person()
        {
            hand = new Hand();
            score = new Score();
            _name = ++counter;
        }

        public void GiveCard(Card card)
        {
            hand.Add(card);
            score.CalculateScore(hand);
        }

        public bool isBust()
        {
            return score.IsBust();
        }

        public abstract string AskForAction();

    }
}
