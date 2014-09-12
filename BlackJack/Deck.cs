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
        }


        public void ShuffleCards()
        {
            Random rng = new Random();
            int n = cards.Count;
            while (n > 1)
            {
                n--;
                var randomNumber = rng.Next(n + 1);
                var card = cards[randomNumber];
                cards[randomNumber] = cards[n];
                cards[n] = card;
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
