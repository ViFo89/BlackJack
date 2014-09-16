using System.Collections.Generic;

namespace BlackJack
{
    public class Score
    {
        private int _lowerScore = 0;
        private int _higherScore = 0;

        public int[] CalculateScore(List<Card> hand)
        {
            _lowerScore = 0;
            _higherScore = 0;

            foreach (var card in hand)
            {
                if (card.CardValue == 1)
                {
                    _lowerScore += 1;
                    _higherScore += 11;
                }
                else if (card.CardValue >= 10)
                {
                    _lowerScore += 10;
                    _higherScore += 10;
                }
                else
                {
                    _lowerScore += card.CardValue;
                    _higherScore += card.CardValue;
                }
            }

            return null;
        }

        public bool IsBust()
        {
            return _lowerScore > 21;
        }

        public int LowerScore
        {
            get { return _lowerScore; }
        }

        public int HigherScore
        {
            get { return _higherScore; }
        }
    }
}
