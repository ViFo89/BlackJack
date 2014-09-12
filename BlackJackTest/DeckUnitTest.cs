using System;
using BlackJack;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlackJackTest
{
    [TestClass]
    public class DeckUnitTest
    {

        [TestMethod]
        public void CreateFourDecks()
        {
            var deck = new Deck(4);
            Assert.AreEqual(208, deck.Count());
        }
        [TestMethod]
        public void CreateOneDeck()
        {
            var deck = new Deck(1);
            Assert.AreEqual(52, deck.Count());
        }
        [TestMethod]
        public void DealCards()
        {
            var deck = new Deck(1);
            var card = deck.DealCard();

            Assert.AreEqual(51, deck.Count(), "There is not 51 cards in the deck!");
            Assert.AreEqual(13, card.CardValue, "The card that got dealt was not a 13");
            Assert.AreEqual(Colors.Hearts, card.CardColor, "The card that got dealt was not a Hearts");

            card = deck.DealCard();

            Assert.AreEqual(50, deck.Count(), "There is not 50 cards in the deck!");
            Assert.AreEqual(12, card.CardValue, "The card that got dealt was not a 12");
            Assert.AreEqual(Colors.Hearts, card.CardColor, "The card that got dealt was not a Hearts");
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void CreateNoDeck()
        {
            var deck = new Deck(0);
        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void CreateNegativeDeck()
        {
            var deck = new Deck(-1);
        }
    }
}
