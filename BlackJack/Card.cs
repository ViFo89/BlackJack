using System;

namespace BlackJack
{
    public class Card
    {
        private readonly int _cardValue;
        private readonly int _color;

        public int CardValue
        {
            get { return this._cardValue; }
        }
        public int Color
        {
            get { return this._cardValue; }
        }

        public Card(int cardColor, int cardValue)
        {
            if (cardValue < 1 || cardValue > 13)
                throw new IndexOutOfRangeException("Card value has to be between 1-13");
            _cardValue = cardValue;
        }
        public Card(string cardColor, int cardValue)
        {
            if (cardValue < 1 || cardValue > 13)
                throw new IndexOutOfRangeException("Card value has to be between 1-13");
            _cardValue = cardValue;
        }

        public override bool Equals(object obj)
        {
            this.CardValue
            return base.Equals(obj);
        }
    }
}
