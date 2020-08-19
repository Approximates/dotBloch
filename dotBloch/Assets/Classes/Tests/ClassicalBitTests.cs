using NUnit.Framework;
using UnityEngine;
namespace Tests
{
    public class ClassicalBitTests
    {
        Bit classicalBit;
        // A Test behaves as an ordinary method
        [Test]
        public void nUnit_Test()
        {
            Assert.AreEqual(true, true);
            Assert.AreEqual(null, null);
        }
        [Test]
        public void constructorTrue_Test()
        {
             classicalBit=new Bit(true);
             Assert.AreEqual("1",classicalBit.getState());
        }

        [Test]
        public void constructorFalse_Test()
        {
             classicalBit=new Bit(false);
             Assert.AreEqual("0",classicalBit.getState());
        }
            
        [Test]
        public void setOne_Test()
        {
             classicalBit=new Bit(false);
             classicalBit.setOne();
             Assert.AreEqual("1",classicalBit.getState());
        }

        [Test]
        public void setZero_Test()
        {
             classicalBit=new Bit(true);
             classicalBit.setZero();
             Assert.AreEqual("0",classicalBit.getState());
        }

        [Test]
        public void notGateToTrue_Test()
        {
             classicalBit=new Bit(false);
             classicalBit.NotGate();
             Assert.AreEqual("1",classicalBit.getState());
        }

        [Test]
        public void notGateToFalse_Test()
        {
             classicalBit=new Bit(true);
             classicalBit.NotGate();
             Assert.AreEqual("0",classicalBit.getState());
        }

        [Test]
        public void getZeroProbability_1_Test()
        {
             classicalBit=new Bit(false);
             
             Assert.AreEqual("P(0) = 100%",classicalBit.getZeroProbability());
        }

        [Test]
        public void getZeroProbability_2_Test()
        {
             classicalBit=new Bit(true);
             
             Assert.AreEqual("P(0) = 0%",classicalBit.getZeroProbability());
        }

        [Test]
        public void getOneProbability_1_Test()
        {
             classicalBit=new Bit(true);
             
             Assert.AreEqual("P(1) = 100%",classicalBit.getOneProbability());
        }

        [Test]
        public void getOneProbability_2_Test()
        {
             classicalBit=new Bit(false);
             
             Assert.AreEqual("P(1) = 0%",classicalBit.getOneProbability());
        }
    }
}
