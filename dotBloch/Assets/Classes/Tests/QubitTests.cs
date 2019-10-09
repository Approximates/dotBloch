using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class QubitTests
    {
        
        // A Test behaves as an ordinary method
        [Test]
        public void HelloWorldTest()
        {
            Assert.AreEqual(true, true);
            Assert.AreEqual(null, null);
        }

        [Test]
        public void thetaZero()
        {
            Qubit quantumBit;  
            quantumBit = new Qubit(0,15);
            //Assert.AreEqual(,"|Ψ> =   1|0> + 0 |1>");
        }
    }
}
