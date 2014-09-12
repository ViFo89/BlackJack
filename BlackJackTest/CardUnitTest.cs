using System;
using BlackJack;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlackJackTest
{

    [TestClass]
    public class CardTest
    {
        [TestMethod]
        public void CardValueMid()
        {
            var card = new Card(1,5);

            Assert.AreEqual(5, card.CardValue, "The cardvalue are not equal to 5.");
        }
        [TestMethod]
        public void CardValueLowerLimit()
        {
            var card = new Card(0,1);

            Assert.AreEqual(1, card.CardValue, "The cardvalue are not equal to 1.");
        }
        [TestMethod]
        public void CardValueHigherLimit()
        {
            var card = new Card(0,13);

            Assert.AreEqual(13, card.CardValue, "The cardvalue are not equal to 13.");
        }
        [TestMethod]
        public void CardConstructorColorValueClubs()
        {
            var card = new Card(0, 6);

            Assert.AreEqual(Colors.Clubs, card.CardColor, "The cardColor is not Clubs when created with int.");
        }
        [TestMethod]
        public void CardConstructorColorValueDiamonds()
        {
            var card = new Card(1, 3);

            Assert.AreEqual(Colors.Diamonds, card.CardColor, "The cardColor is not Diamonds when created with int.");
        }
        [TestMethod]
        public void CardConstructorColorValueSpades()
        {
            var card = new Card(2, 4);

            Assert.AreEqual(Colors.Spades, card.CardColor, "The cardColor is not Spades when created with int.");
        }
        [TestMethod]
        public void CardConstructorColorValueHearts()
        {
            var card = new Card(3, 10);

            Assert.AreEqual(Colors.Hearts, card.CardColor, "The cardColor is not Hearts when created with int.");
        }

        [TestMethod]
        public void CardConstructorEnumColorValueClubs()
        {
            var card = new Card(Colors.Clubs, 6);

            Assert.AreEqual(Colors.Clubs, card.CardColor, "The cardColor is not Clubs when created with enum.");
        }
        [TestMethod]
        public void CardConstructorEnumColorValueDiamonds()
        {
            var card = new Card(Colors.Diamonds, 3);

            Assert.AreEqual(Colors.Diamonds, card.CardColor, "The cardColor is not Diamonds when created with enum.");
        }
        [TestMethod]
        public void CardConstructorEnumColorValueSpades()
        {
            var card = new Card(Colors.Spades, 4);

            Assert.AreEqual(Colors.Spades, card.CardColor, "The cardColor is not Spades when created with enum.");
        }
        [TestMethod]
        public void CardConstructorEnumColorValueHearts()
        {
            var card = new Card(Colors.Hearts, 10);

            Assert.AreEqual(Colors.Hearts, card.CardColor, "The cardColor is not Hearts when created with enum.");
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void ConstructorNegativeValue()
        {
            var card = new Card(0,-1);
        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void ConstructorZeroValue()
        {
            var card = new Card(0,0);
        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void ConstructorToHighValue()
        {
            var card = new Card(0,14);
        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void ConstructorToHighColorValue()
        {
            var card = new Card(4, 13);
        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void ConstructorToLowColorValue()
        {
            var card = new Card(-1, 13);
        }

    }
}
