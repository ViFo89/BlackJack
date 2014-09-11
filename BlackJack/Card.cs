using System;

namespace BlackJack
{
    public class Card
    {
        private readonly int _cardValue;
        private readonly string _color;

        public int CardValue
        {
            get { return _cardValue; }
        }
        public string Color
        {
            get { return _color; }
        }

        public Card(int cardColor, int cardValue)
        {
            switch (cardColor)
            {
                case 0:
                    _color = "Clubs";
                    break;
                case 1:
                    _color = "Diamonds";
                    break;
                case 2:
                    _color = "Spades";
                    break;
                case 3:
                    _color = "Hearts";
                    break;
                default:
                    throw new IndexOutOfRangeException("cardColor has to be between 0-4");
            }
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
            if (obj == null)
                return false;

            Card other = obj as Card;
            if ((object)other == null)
            {
                return false;
            }

            return true; //(_color == other.Color) && (_cardValue == other.CardValue);
        }

        protected bool Equals(Card other)
        {
            return _cardValue == other._cardValue && _color == other._color;
        }
    }
}
