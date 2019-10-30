using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class QubitTests
    {
        Qubit quantumBit;
        // A Test behaves as an ordinary method
        [Test]
        public void nUnit_test()
        {
            quantumBit = new Qubit(0,0);
            Assert.AreEqual(true, true);
            Assert.AreEqual(null, null);
        }

        [Test]
        public void printBlochVector_thetaZero_Tests()
        {
            quantumBit.thetaAngle = 0;

            quantumBit.phiAngle = 0;
            Assert.AreEqual("|Ψ> = 1 |0> + 0 |1>", quantumBit.printBlochVector());

            quantumBit.phiAngle = 45;
            Assert.AreEqual("|Ψ> = 1 |0> + 0 |1>", quantumBit.printBlochVector());

            quantumBit.phiAngle = 90;
            Assert.AreEqual("|Ψ> = 1 |0> + 0 |1>",quantumBit.printBlochVector());

            quantumBit.phiAngle = 180;
            Assert.AreEqual("|Ψ> = 1 |0> + 0 |1>", quantumBit.printBlochVector());

            quantumBit.phiAngle = 270;
            Assert.AreEqual("|Ψ> = 1 |0> + 0 |1>", quantumBit.printBlochVector());

            quantumBit.phiAngle = 359;
            Assert.AreEqual("|Ψ> = 1 |0> + 0 |1>", quantumBit.printBlochVector());
        }
        
        [Test]
        public void printBlochVector_theta30_Tests()
        {
            quantumBit.thetaAngle = 30;

            quantumBit.phiAngle = 0;
            Assert.AreEqual("|Ψ> = 0,966 |0> + 0,259 |1>", quantumBit.printBlochVector());

            quantumBit.phiAngle = 45;
            Assert.AreEqual("|Ψ> = 0,966 |0> + 0,183 + 0,183i |1>", quantumBit.printBlochVector());

            quantumBit.phiAngle = 90;
            Assert.AreEqual("|Ψ> = 0,966 |0> + 0,259i |1>", quantumBit.printBlochVector());

            quantumBit.phiAngle = 180;
            Assert.AreEqual("|Ψ> = 0,966 |0> - 0,259 |1>", quantumBit.printBlochVector());

            quantumBit.phiAngle = 270;
            Assert.AreEqual("|Ψ> = 0,966 |0> - 0,259i |1>", quantumBit.printBlochVector());

            quantumBit.phiAngle = 359;
            Assert.AreEqual("|Ψ> = 0,966 |0> + 0,259 |1>", quantumBit.printBlochVector());

        }

        [Test]
        public void printBlochVector_theta45_Tests()
        {
            quantumBit.thetaAngle = 45;

            quantumBit.phiAngle = 0;
            Assert.AreEqual("Ψ> = 0,924 |0> + 0,383 |1>", quantumBit.printBlochVector());

            quantumBit.phiAngle = 45;
            Assert.AreEqual("Ψ> = 0,924 |0> + 0,271 + 0,271i |1>", quantumBit.printBlochVector());

            quantumBit.phiAngle = 90;
            Assert.AreEqual("|Ψ> = 0,924 |0> + 0,383i |1>", quantumBit.printBlochVector());

            quantumBit.phiAngle = 180;
            Assert.AreEqual("|Ψ> = 0,924 |0> - 0,383 |1>", quantumBit.printBlochVector());

            quantumBit.phiAngle = 270;
            Assert.AreEqual("|Ψ> = 0,924 |0> - 0,383i |1>", quantumBit.printBlochVector());

            quantumBit.phiAngle = 359;
            Assert.AreEqual("|Ψ> = 0,924 |0> + 0,383 |1>", quantumBit.printBlochVector());
        }

        [Test]
        public void printBlochVector_theta60_Tests()
        {
            quantumBit.thetaAngle = 60;

            quantumBit.phiAngle = 0;
            Assert.AreEqual("Ψ> = 0,866 |0> + 0,5 |1>", quantumBit.printBlochVector());

            quantumBit.phiAngle = 45;
            Assert.AreEqual("Ψ> = 0,866 |0> + 0,354 + 0,354i |1>", quantumBit.printBlochVector());

            quantumBit.phiAngle = 90;
            Assert.AreEqual("Ψ> = 0,866 |0> + 0,5i |1>", quantumBit.printBlochVector());

            quantumBit.phiAngle = 180;
            Assert.AreEqual("Ψ> = 0,866 |0> - 0,5 |1>", quantumBit.printBlochVector());

            quantumBit.phiAngle = 270;
            Assert.AreEqual("Ψ> = 0,866 |0> - 0,5i |1>", quantumBit.printBlochVector());

            quantumBit.phiAngle = 359;
            Assert.AreEqual("Ψ> 0,866 |0> + 0,5 |1>", quantumBit.printBlochVector());
        }

        [Test]
        public void printBlochVector_theta90_Tests()
        {
            quantumBit.thetaAngle = 90;

            quantumBit.phiAngle = 0;
            Assert.AreEqual("Ψ> = 0,707 |0> + 0,707 |1>", quantumBit.printBlochVector());

            quantumBit.phiAngle = 45;
            Assert.AreEqual("Ψ> = 0,707 |0> + 0,5 + 0,5i |1>", quantumBit.printBlochVector());

            quantumBit.phiAngle = 90;
            Assert.AreEqual("Ψ> = 0,707|0> + 0,707i |1>", quantumBit.printBlochVector());

            quantumBit.phiAngle = 180;
            Assert.AreEqual("Ψ> = 0,707 |0> - 0,707 |1>", quantumBit.printBlochVector());

            quantumBit.phiAngle = 270;
            Assert.AreEqual("Ψ> = 0,707 |0> + 0,707i |1>", quantumBit.printBlochVector());

            quantumBit.phiAngle = 359;
            Assert.AreEqual("Ψ> = 0,707 |0> + 0,707 |1>", quantumBit.printBlochVector());
        }

        [Test]
        public void printBlochVector_theta120_Tests(){
            quantumBit.thetaAngle = 120;

            quantumBit.phiAngle = 0;
            Assert.AreEqual("Ψ> = 0,5 |0> + 0,866 |1>", quantumBit.printBlochVector());

            quantumBit.phiAngle = 45;
            Assert.AreEqual("Ψ> = 0,5 |0> + 0,612+0,612i |1>", quantumBit.printBlochVector());

            quantumBit.phiAngle = 90;
            Assert.AreEqual("Ψ> = 0,5 |0> + 0,866i |1>", quantumBit.printBlochVector());

            quantumBit.phiAngle = 180;
            Assert.AreEqual("Ψ> = 0,5 |0> - 0,866 |1>", quantumBit.printBlochVector());

            quantumBit.phiAngle = 270;
            Assert.AreEqual("Ψ> = 0,5 |0> + 0,866 |1>", quantumBit.printBlochVector());

            quantumBit.phiAngle = 359;
            Assert.AreEqual("Ψ> = 0,5 |0> + 0,866 |1>", quantumBit.printBlochVector());
        }

        [Test]
        public void printBlochVector_theta180_Tests()
        {
            quantumBit.thetaAngle = 180;

            quantumBit.phiAngle = 0;
            Assert.AreEqual("|Ψ> = 0 |0> + 1 |1>", quantumBit.printBlochVector());

            quantumBit.phiAngle = 45;
            Assert.AreEqual("Ψ> = 0 |0> + 0,707+0,707i |1>", quantumBit.printBlochVector());

            quantumBit.phiAngle = 90;
            Assert.AreEqual("|Ψ> = 0 |0> + i |1>", quantumBit.printBlochVector());

            quantumBit.phiAngle = 180;
            Assert.AreEqual("|Ψ> = 0 |0> - 1 |1>", quantumBit.printBlochVector());

            quantumBit.phiAngle = 270;
            Assert.AreEqual("|Ψ> = 0 |0> - i |1>", quantumBit.printBlochVector());

            quantumBit.phiAngle = 359;
            Assert.AreEqual("|Ψ> = 0 |0> + 1 |1>", quantumBit.printBlochVector());
        }

        [Test]
        public void printBlochVector_invalid_arguments()
        {
            quantumBit.thetaAngle = -10;
            quantumBit.phiAngle = 15;
            Assert.AreEqual(new ArgumentException("Theta angle is less than 0 degrees"), quantumBit.printBlochVector());

            quantumBit.thetaAngle = 86;
            quantumBit.phiAngle = -23;
            Assert.AreEqual(new ArgumentException("Phi angle is less than 0 degrees"), quantumBit.printBlochVector());

            quantumBit.thetaAngle = 183;
            quantumBit.phiAngle = 270;
            Assert.AreEqual(new ArgumentException("Theta angle is greater than 180 degrees"), quantumBit.printBlochVector());

            quantumBit.thetaAngle = 20;
            quantumBit.phiAngle = 380;
            Assert.AreEqual(new ArgumentException("Phi angle is greater than 360 degrees"), quantumBit.printBlochVector());
        }

        [Test]
        public void printBlochVector_customSettings_Tests()
        {
            quantumBit.thetaAngle = 30;
            quantumBit.phiAngle = 45;
            
            PrintBlochSettings settings = new PrintBlochSettings(false,1,PrintBlochSettings.DecimalSeparator.comma,PrintBlochSettings.ImaginaryUnit.i);
            Assert.AreEqual("|Ψ>=1,0|0>+0,2+0,3i|1>",quantumBit.printBlochVector(settings));

            settings = new PrintBlochSettings(true,4,PrintBlochSettings.DecimalSeparator.dot,PrintBlochSettings.ImaginaryUnit.I);
            Assert.AreEqual("|Ψ> = 0.9659 |0> + 0.183 + 0.2588I |1>",quantumBit.printBlochVector(settings));

            settings = new PrintBlochSettings(false,8,PrintBlochSettings.DecimalSeparator.comma,PrintBlochSettings.ImaginaryUnit.j);
            Assert.AreEqual("|Ψ>=0,96592583|0>+0,18301270+0,25881905j|1>",quantumBit.printBlochVector(settings));

            settings = new PrintBlochSettings(true,15,PrintBlochSettings.DecimalSeparator.dot,PrintBlochSettings.ImaginaryUnit.J);
            Assert.AreEqual("|Ψ> = 0.965925826289068 |0> + 0.183012701892219 + 0.258819045102521J |1>",quantumBit.printBlochVector(settings));
        }
    }
}
