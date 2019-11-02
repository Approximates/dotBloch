using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using static PrintBlochSettings;

namespace Tests
{
    public class printZeroValue
    {
        Qubit quantumBit;
        // A Test behaves as an ordinary method
        [Test]
        public void nUnit_test()
        {
            Assert.AreEqual(true, true);
            Assert.AreEqual(null, null);
        }

        [Test]
        public void theta_0_without_trailing_zeros_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 0;
            Assert.AreEqual("1", quantumBit.printZeroValue());
        }

        [Test]
        public void theta_0_with_trailing_zeros_Test(){
            // no trailing zeroes when value is 0 or 1
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 0;
            PrintBlochSettings customSettings = new PrintBlochSettings(true,true,3,PrintBlochSettings.DecimalSeparator.comma,PrintBlochSettings.ImaginaryUnit.i);
            Assert.AreEqual("1", quantumBit.printZeroValue());
        }

        [Test]
        public void theta_5_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 5;
            Assert.AreEqual("0,999", quantumBit.printZeroValue());
        }

        [Test]
        public void theta_37_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 37;
            Assert.AreEqual("0,948", quantumBit.printZeroValue());
        }        
        [Test]
        public void theta_43_without_trailing_zeros_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 43;
            Assert.AreEqual("0,93", quantumBit.printZeroValue());
        }

        [Test]
        public void theta_43_with_trailing_zeros_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 43;
            PrintBlochSettings customSettings = new PrintBlochSettings(true,true,3,PrintBlochSettings.DecimalSeparator.dot,PrintBlochSettings.ImaginaryUnit.i);
            Assert.AreEqual("0.930", quantumBit.printZeroValue(customSettings));
        }
        
        [Test]
        public void theta_87_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 87;
            Assert.AreEqual("0,725", quantumBit.printZeroValue());
        }

        [Test]
        public void theta_97_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 97;
            PrintBlochSettings customSettings = new PrintBlochSettings(true,false,3,PrintBlochSettings.DecimalSeparator.dot,PrintBlochSettings.ImaginaryUnit.i);
            Assert.AreEqual("0.663", quantumBit.printZeroValue(customSettings));
        }
        
        [Test]
        public void theta_127_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 127;
            PrintBlochSettings customSettings = new PrintBlochSettings(true,false,3,PrintBlochSettings.DecimalSeparator.dot,PrintBlochSettings.ImaginaryUnit.i);
            Assert.AreEqual("0.446", quantumBit.printZeroValue(customSettings));
        }
        
        [Test]
        public void theta_167_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 167;
            PrintBlochSettings customSettings = new PrintBlochSettings(true,false,3,PrintBlochSettings.DecimalSeparator.comma,PrintBlochSettings.ImaginaryUnit.i);
            Assert.AreEqual("0,113", quantumBit.printZeroValue(customSettings));
        }
        
        [Test]
        public void theta_179_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 179;
            PrintBlochSettings customSettings = new PrintBlochSettings(true,false,3,PrintBlochSettings.DecimalSeparator.comma,PrintBlochSettings.ImaginaryUnit.i);
            Assert.AreEqual("0,009", quantumBit.printZeroValue(customSettings));
        }
        
        [Test]
        public void theta_180_without_trailing_zeros_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 180;
            Assert.AreEqual("0", quantumBit.printZeroValue());
        }

        [Test]
        public void theta_180_with_trailing_zeros_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 180;
            PrintBlochSettings customSettings = new PrintBlochSettings(true,true,3,PrintBlochSettings.DecimalSeparator.dot,PrintBlochSettings.ImaginaryUnit.i);
            Assert.AreEqual("0", quantumBit.printZeroValue());
        }
    }
}
