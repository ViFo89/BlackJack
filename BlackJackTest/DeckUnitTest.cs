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
        public void TestShuffle()
        {
            var deck = new Deck(1);


            

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
