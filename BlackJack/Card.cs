using System;

namespace BlackJack
{
    public enum Colors
    {
        Clubs = 0,
        Diamonds = 1,
        Spades = 2,
        Hearts = 3
    }
    public class Card
    {
        private readonly int _cardValue;
        private readonly Colors _color;

        public int CardValue
        {
            get { return _cardValue; }
        }
        public Colors CardColor
        {
            get { return _color; }
        }

        public Card(int cardColor, int cardValue)
        {

            if(cardColor < 0 || cardColor > 3)
                throw new IndexOutOfRangeException("cardColor has to be between 0-3");
            
            if (cardValue < 1 || cardValue > 13)
                throw new IndexOutOfRangeException("Card value has to be between 1-13");

            _color = (Colors)cardColor;
            _cardValue = cardValue;
        }
        public Card(Colors cardColor, int cardValue) : this((int)cardColor, cardValue) //TODO Look up a better way to do this
        {}


    }
}
