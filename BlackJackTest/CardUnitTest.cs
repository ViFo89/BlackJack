﻿using System;
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
            var card = new Card(5);

            Assert.AreEqual(5, card.cardValue, "The cardvalue are not equal to 5.");
        }
        [TestMethod]
        public void CardValueLowerLimit()
        {
            var card = new Card(1);

            Assert.AreEqual(1, card.cardValue, "The cardvalue are not equal to 1.");
        }
        [TestMethod]
        public void CardValueHigherLimit()
        {
            var card = new Card(13);

            Assert.AreEqual(13, card.cardValue, "The cardvalue are not equal to 13.");
        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void ConstructorNegativeValue()
        {
            var card = new Card(-1);
        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void ConstructorZeroValue()
        {
            var card = new Card(0);
        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void ConstructorToHighValue()
        {
            var card = new Card(14);
        }
    }
}
