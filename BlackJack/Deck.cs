using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackJack
{
    public class Deck
    {
        private List<Card> cards;

        public Deck(int numberOfDecks)
        {
            if (numberOfDecks < 1)
                throw new IndexOutOfRangeException("Atleast one deck has to be created.");
            cards = new List<Card>();
            for (var i = numberOfDecks; i > 0; i--)
            {
                CreateDeck();
            }
            ShuffleCards();
        }


        public void ShuffleCards()
        {
            Random rng = new Random();
            int n = cards.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card value = cards[k];
                cards[k] = cards[n];
                cards[n] = value;
            }  
        }

        private void CreateDeck()
        {
            for (var i = 0; i < 4; i++)
            {
                for (var j = 1; j <= 13; j++)
                {
                    cards.Add(new Card(i, j));
                } 
            }
        }

        public Card DealCard()
        {
            Card cardToReturn = cards.Last();
            cards.Remove(cards.Last());
            return cardToReturn;
        }

        public int Count()
        {
            return cards.Count();
        }

    }
}
