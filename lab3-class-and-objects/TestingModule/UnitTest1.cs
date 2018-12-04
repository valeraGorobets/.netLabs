using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BoolVectorLibrary;

namespace TestingModule
{
    [TestClass]
    public class UnitTest1
    {
        BoolVector boolVector = new BoolVector(true, true, false, true, false, false, true);

        [TestMethod]
        public void TestInversion()
        {
            BoolVector invertedBoolVector = new BoolVector(false, false, true, false, true, true, false);
            StringAssert.Equals(invertedBoolVector.GetVectorsStringFormat(), (!boolVector).GetVectorsStringFormat());
        }

        [TestMethod]
        public void TestСonjunction()
        {
            BoolVector boolVector1 = new BoolVector(false, false, true, true);
            BoolVector boolVector2 = new BoolVector(false, true, false, true);
            BoolVector shouldBeEqualTo = new BoolVector(false, false, false, true);
            StringAssert.Equals((boolVector1 & boolVector2).GetVectorsStringFormat(), shouldBeEqualTo.GetVectorsStringFormat());
        }

        [TestMethod]
        public void TestDisjunction()
        {
            BoolVector boolVector1 = new BoolVector(false, false, true, true);
            BoolVector boolVector2 = new BoolVector(false, true, false, true);
            BoolVector shouldBeEqualTo = new BoolVector(false, true, true, true);
            StringAssert.Equals((boolVector1 | boolVector2).GetVectorsStringFormat(), shouldBeEqualTo.GetVectorsStringFormat());
        }

        [TestMethod]
        public void TestAmountOfZeroValues()
        {
            Assert.AreEqual(boolVector.CountAmountOf(FindValue.Zero), 3);
        }

        [TestMethod]
        public void TestAmountOfOneValues()
        {
            Assert.AreEqual(boolVector.CountAmountOf(FindValue.One), 4);
        }
    }
}
