using System.Collections.Generic;

namespace BlackJack
{
    public class Person
    {
        private List<Card> hand;
        private Score score;
        private static int counter = 0;

        private int _name;
        
            public int Name{
            get { return _name; }
        }

        public Person()
        {
            hand = new List<Card>();
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

        public string AskForAction()
        {
            return null;
        }

    }
}
