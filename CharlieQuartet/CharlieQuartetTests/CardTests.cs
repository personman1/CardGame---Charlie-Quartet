﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using CharlieQuartet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieQuartet.Tests
{
    [TestClass()]
    public class CardTests
    {

        [TestMethod()]
        public void CardTest()
        {
            //Card vCard = new Card(string pNumber, Suit pSuit, int pPoint);

            Card vCard = new Card("King", "Hearts", 10);

            Assert.IsInstanceOfType(vCard, typeof(Card));
        }

        [TestMethod()]
        public void getNumberTest()
        {
            Card vCard = new Card("King", "Hearts", 10);

            Assert.AreEqual(vCard.getNumber(), "King");

        }

        [TestMethod()]
        public void getSuitTest()
        {
            Card vCard = new Card("King", "Hearts", 10);
            Assert.AreEqual(vCard.getSuit(), "Hearts");
        }

        [TestMethod()]
        public void getPointTest()
        {
            Card vCard = new Card("King", "Hearts", 10);
            Assert.AreEqual(vCard.getPoint(), 10);
        }
    }
}