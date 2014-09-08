namespace BlackJack
{
    public class Card
    {
        private readonly int _cardValue;

        public int cardValue
        {
            get { return this._cardValue; }
        }

        public Card(int cardValue)
        {
            _cardValue = cardValue;
        }
    }
}
