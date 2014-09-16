using System.Collections.Generic;


namespace BlackJack
{
    public class Hand
    {
        private List<Card> _hand;
        int LowerScore { get; }
        int HigherScore { get; }

        public Hand()
        {
            _hand = new List<Card>();
        }

        public void Add(Card card)
        {
            _hand.Add(card);
        }
    }
}
