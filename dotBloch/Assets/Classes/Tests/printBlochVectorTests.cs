using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using static PrintBlochSettings;

namespace Tests
{
    public class printBlochVectorTests
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
        public void thetaZero_Tests()
        {
            quantumBit = new Qubit(0,0);
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
        public void theta30_Tests()
        {
            quantumBit = new Qubit(0,0);
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
            Assert.AreEqual("|Ψ> = 0,966 |0> + 0,259 - 0,005i |1>", quantumBit.printBlochVector());
        }

        [Test]
        public void theta45_Tests()
        {
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 45;

            quantumBit.phiAngle = 0;
            Assert.AreEqual("|Ψ> = 0,924 |0> + 0,383 |1>", quantumBit.printBlochVector());

            quantumBit.phiAngle = 45;
            Assert.AreEqual("|Ψ> = 0,924 |0> + 0,271 + 0,271i |1>", quantumBit.printBlochVector());

            quantumBit.phiAngle = 90;
            Assert.AreEqual("|Ψ> = 0,924 |0> + 0,383i |1>", quantumBit.printBlochVector());

            quantumBit.phiAngle = 180;
            Assert.AreEqual("|Ψ> = 0,924 |0> - 0,383 |1>", quantumBit.printBlochVector());

            quantumBit.phiAngle = 270;
            Assert.AreEqual("|Ψ> = 0,924 |0> - 0,383i |1>", quantumBit.printBlochVector());

            quantumBit.phiAngle = 359;
            Assert.AreEqual("|Ψ> = 0,924 |0> + 0,383 - 0,007i |1>", quantumBit.printBlochVector());
        }

        [Test]
        public void theta60_Tests()
        {
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 60;

            PrintBlochSettings settings = new PrintBlochSettings(true,true,3,DecimalSeparator.comma,ImaginaryUnit.i);

            quantumBit.phiAngle = 0;
            Assert.AreEqual("|Ψ> = 0,866 |0> + 0,5 |1>", quantumBit.printBlochVector());

            quantumBit.phiAngle = 45;
            Assert.AreEqual("|Ψ> = 0,866 |0> + 0,354 + 0,354i |1>", quantumBit.printBlochVector());

            quantumBit.phiAngle = 90;
            Assert.AreEqual("|Ψ> = 0,866 |0> + 0,500i |1>", quantumBit.printBlochVector(settings));

            quantumBit.phiAngle = 180;
            Assert.AreEqual("|Ψ> = 0,866 |0> - 0,5 |1>", quantumBit.printBlochVector());

            quantumBit.phiAngle = 270;
            Assert.AreEqual("|Ψ> = 0,866 |0> - 0,500i |1>", quantumBit.printBlochVector(settings));

            quantumBit.phiAngle = 359;
            Assert.AreEqual("|Ψ> = 0,866 |0> + 0,500 - 0,009i |1>", quantumBit.printBlochVector(settings));
        }

        [Test]
        public void theta90_Tests()
        {
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 90;

            quantumBit.phiAngle = 0;
            Assert.AreEqual("|Ψ> = 0,707 |0> + 0,707 |1>", quantumBit.printBlochVector());

            quantumBit.phiAngle = 45;
            Assert.AreEqual("|Ψ> = 0,707 |0> + 0,5 + 0,5i |1>", quantumBit.printBlochVector());
            PrintBlochSettings settings = new PrintBlochSettings(true,true,3,DecimalSeparator.comma,ImaginaryUnit.i);
            Assert.AreEqual("|Ψ> = 0,707 |0> + 0,500 + 0,500i |1>", quantumBit.printBlochVector(settings));

            quantumBit.phiAngle = 90;
            Assert.AreEqual("|Ψ> = 0,707 |0> + 0,707i |1>", quantumBit.printBlochVector());

            quantumBit.phiAngle = 180;
            Assert.AreEqual("|Ψ> = 0,707 |0> - 0,707 |1>", quantumBit.printBlochVector());

            quantumBit.phiAngle = 270;
            Assert.AreEqual("|Ψ> = 0,707 |0> - 0,707i |1>", quantumBit.printBlochVector());

            quantumBit.phiAngle = 359;
            Assert.AreEqual("|Ψ> = 0,707 |0> + 0,707 - 0,012i |1>", quantumBit.printBlochVector());
        }


        [Test]
        public void theta120_phi0_Tests(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 120;
            quantumBit.phiAngle = 0;
            Assert.AreEqual("|Ψ> = 0,5 |0> + 0,866 |1>", quantumBit.printBlochVector());
        }

        [Test]
        public void theta120_phi45_Tests(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 120;
            quantumBit.phiAngle = 45;
            Assert.AreEqual("|Ψ> = 0,5 |0> + 0,612 + 0,612i |1>", quantumBit.printBlochVector());
        }

        [Test]
        public void theta120_phi90_Tests(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 120;
            quantumBit.phiAngle = 90;
            Assert.AreEqual("|Ψ> = 0,5 |0> + 0,866i |1>", quantumBit.printBlochVector());
        }

        [Test]
        public void theta120_phi180_Tests(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 120;
            quantumBit.phiAngle = 180;
            Assert.AreEqual("|Ψ> = 0,5 |0> - 0,866 |1>", quantumBit.printBlochVector());
        }

        [Test]
        public void theta120_phi270_Tests(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 120;
            quantumBit.phiAngle = 270;
            Assert.AreEqual("|Ψ> = 0,5 |0> - 0,866i |1>", quantumBit.printBlochVector());
        }

        [Test]
        public void theta120_phi359_Tests(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 120;
            quantumBit.phiAngle = 359;
            Assert.AreEqual("|Ψ> = 0,5 |0> + 0,866 - 0,015i |1>", quantumBit.printBlochVector());
        }

        [Test]
        public void theta180_Tests()
        {
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 180;

            quantumBit.phiAngle = 0;
            Assert.AreEqual("|Ψ> = 0 |0> + 1 |1>", quantumBit.printBlochVector());

            quantumBit.phiAngle = 45;
            Assert.AreEqual("|Ψ> = 0 |0> + 0,707 + 0,707i |1>", quantumBit.printBlochVector());

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
        public void invalid_arguments_Tests()
        {
            quantumBit = new Qubit(0,0);
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
        public void customSettings_Tests()
        {
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 30;
            quantumBit.phiAngle = 45;
            
            PrintBlochSettings settings = new PrintBlochSettings(false,false,1,PrintBlochSettings.DecimalSeparator.comma,PrintBlochSettings.ImaginaryUnit.i);
            Assert.AreEqual("|Ψ>=1,0|0>+0,2+0,3i|1>",quantumBit.printBlochVector(settings));

            settings = new PrintBlochSettings(true,true,4,PrintBlochSettings.DecimalSeparator.dot,PrintBlochSettings.ImaginaryUnit.I);
            Assert.AreEqual("|Ψ> = 0.9659 |0> + 0.1830 + 0.2588I |1>",quantumBit.printBlochVector(settings));

            settings = new PrintBlochSettings(false,false,8,PrintBlochSettings.DecimalSeparator.comma,PrintBlochSettings.ImaginaryUnit.j);
            Assert.AreEqual("|Ψ>=0,96592583|0>+0,18301270+0,25881905j|1>",quantumBit.printBlochVector(settings));

            settings = new PrintBlochSettings(true,true,15,PrintBlochSettings.DecimalSeparator.dot,PrintBlochSettings.ImaginaryUnit.J);
            Assert.AreEqual("|Ψ> = 0.965925826289068 |0> + 0.183012701892219 + 0.258819045102521J |1>",quantumBit.printBlochVector(settings));
        }
    }
}
