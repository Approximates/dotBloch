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
            
    }
}
