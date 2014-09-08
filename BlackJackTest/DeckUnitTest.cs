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
            Deck deck = new Deck(1);
            Assert.AreEqual(52, deck.Count());
        }

        [TestMethod]
        public void TestShuffle()
        {
            var deck = new Deck(1);


            deck.ShuffleCards();

            for (var i = 0; i < 52; i++)
            {
                
            }

        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void CreateNoDeck()
        {
            Deck deck = new Deck(0);
        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void CreateNegativeDeck()
        {
            Deck deck = new Deck(-1);
        }
    }
}
