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
        public void nUnit_Test()
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
        public void theta_30_phi_0_Tests(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 30;
            quantumBit.phiAngle = 0;
            Assert.AreEqual("|Ψ> = 0,966 |0> + 0,259 |1>", quantumBit.printBlochVector());
        }

        [Test]
        public void theta_30_phi_45_Tests(){
            quantumBit = new Qubit(30,45);
            Assert.AreEqual("|Ψ> = 0,966 |0> + 0,183 + 0,183i |1>", quantumBit.printBlochVector());
        }

        [Test]
        public void theta_30_phi_90_Tests(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 30;
            quantumBit.phiAngle = 90;
            Assert.AreEqual("|Ψ> = 0,966 |0> + 0,259i |1>", quantumBit.printBlochVector());
        }

        [Test]
        public void theta_30_phi_180_Tests(){
            quantumBit = new Qubit(30,180);
            Assert.AreEqual("|Ψ> = 0,966 |0> - 0,259 |1>", quantumBit.printBlochVector());
        }

        [Test]
        public void theta_30_phi_270_Tests(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 30;
            quantumBit.phiAngle = 270;
            Assert.AreEqual("|Ψ> = 0,966 |0> - 0,259i |1>", quantumBit.printBlochVector());
        }

        [Test]
        public void theta_30_phi_359_Tests(){
            quantumBit = new Qubit(30,359);
            Assert.AreEqual("|Ψ> = 0,966 |0> + 0,259 - 0,005i |1>", quantumBit.printBlochVector());
        }

        [Test]
        public void theta_45_phi_0_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 45;
            quantumBit.phiAngle = 0;
            Assert.AreEqual("|Ψ> = 0,924 |0> + 0,383 |1>", quantumBit.printBlochVector());
        }

        [Test]
        public void theta_45_phi_45_Test(){
            quantumBit = new Qubit(45,45);
            Assert.AreEqual("|Ψ> = 0,924 |0> + 0,271 + 0,271i |1>", quantumBit.printBlochVector());
        }
        
        [Test]
        public void theta_45_phi_90_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 45;
            quantumBit.phiAngle = 90;
            Assert.AreEqual("|Ψ> = 0,924 |0> + 0,383i |1>", quantumBit.printBlochVector());
        }

        [Test]
        public void theta_45_phi_180_Test(){
            quantumBit = new Qubit(45,180);
            Assert.AreEqual("|Ψ> = 0,924 |0> - 0,383 |1>", quantumBit.printBlochVector());
        }

        [Test]
        public void theta_45_phi_270_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 45;
            quantumBit.phiAngle = 270;
            Assert.AreEqual("|Ψ> = 0,924 |0> - 0,383i |1>", quantumBit.printBlochVector());
        }

        [Test]
        public void theta_45_phi_359_Test(){
            quantumBit = new Qubit(45,359);
            Assert.AreEqual("|Ψ> = 0,924 |0> + 0,383 - 0,007i |1>", quantumBit.printBlochVector());
        }

        [Test]
        public void theta_60_phi_0_with_settings_Tests(){
            quantumBit = new Qubit(60,0);
            PrintBlochSettings settings = new PrintBlochSettings(true,true,3,DecimalSeparator.comma,ImaginaryUnit.i);
            Assert.AreEqual("|Ψ> = 0,866 |0> + 0,5 |1>", quantumBit.printBlochVector());
        }

        [Test]
        public void theta_60_phi_45_Tests(){
            quantumBit = new Qubit(60,0);
            quantumBit.phiAngle = 45;
            Assert.AreEqual("|Ψ> = 0,866 |0> + 0,354 + 0,354i |1>", quantumBit.printBlochVector());
        }

        [Test]
        public void theta_60_phi_90_with_settings_Tests(){
            quantumBit = new Qubit(60,90);
            PrintBlochSettings settings = new PrintBlochSettings(true,true,3,DecimalSeparator.comma,ImaginaryUnit.i);
            Assert.AreEqual("|Ψ> = 0,866 |0> + 0,500i |1>", quantumBit.printBlochVector(settings));
        }

        [Test]
        public void theta_60_phi_180_Tests(){
            quantumBit = new Qubit(60,0);
            quantumBit.phiAngle = 180;
            Assert.AreEqual("|Ψ> = 0,866 |0> - 0,5 |1>", quantumBit.printBlochVector());
        }

        [Test]
        public void theta_60_phi_270_with_settings_Tests(){
            quantumBit = new Qubit(60,0);
            PrintBlochSettings settings = new PrintBlochSettings(true,true,3,DecimalSeparator.comma,ImaginaryUnit.i);
            quantumBit.phiAngle = 270;
            Assert.AreEqual("|Ψ> = 0,866 |0> - 0,500i |1>", quantumBit.printBlochVector(settings));
        }

        [Test]
        public void theta_60_phi_359_with_settings_Tests(){
            quantumBit = new Qubit(60,359);
            PrintBlochSettings settings = new PrintBlochSettings(true,true,3,DecimalSeparator.comma,ImaginaryUnit.i);
            Assert.AreEqual("|Ψ> = 0,866 |0> + 0,500 - 0,009i |1>", quantumBit.printBlochVector(settings));
        }

        [Test]
        public void theta_90_phi_0_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 90;
            quantumBit.phiAngle = 0;
            Assert.AreEqual("|Ψ> = 0,707 |0> + 0,707 |1>", quantumBit.printBlochVector());
        }

        [Test]
        public void theta_90_phi_45_Tests(){
            quantumBit = new Qubit(90,45);
            Assert.AreEqual("|Ψ> = 0,707 |0> + 0,5 + 0,5i |1>", quantumBit.printBlochVector());
            PrintBlochSettings settings = new PrintBlochSettings(true,true,3,DecimalSeparator.comma,ImaginaryUnit.i);
            Assert.AreEqual("|Ψ> = 0,707 |0> + 0,500 + 0,500i |1>", quantumBit.printBlochVector(settings));
        }

        [Test]
        public void theta_90_phi_90_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 90;
            quantumBit.phiAngle = 90;
            Assert.AreEqual("|Ψ> = 0,707 |0> + 0,707i |1>", quantumBit.printBlochVector());
        }

        [Test]
        public void theta_90_phi_180_Test(){
            quantumBit = new Qubit(90,180);
            Assert.AreEqual("|Ψ> = 0,707 |0> - 0,707 |1>", quantumBit.printBlochVector());
        }

        [Test]
        public void theta_90_phi_270_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 90;
            quantumBit.phiAngle = 270;
            Assert.AreEqual("|Ψ> = 0,707 |0> - 0,707i |1>", quantumBit.printBlochVector());
        }

        [Test]
        public void theta_90_phi_359_Test(){
            quantumBit = new Qubit(90,359);
            quantumBit.thetaAngle = 90;
            Assert.AreEqual("|Ψ> = 0,707 |0> + 0,707 - 0,012i |1>", quantumBit.printBlochVector());
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
        public void theta_120_phi_0_Tests(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 120;
            quantumBit.phiAngle = 0;
            Assert.AreEqual("|Ψ> = 0,5 |0> + 0,866 |1>", quantumBit.printBlochVector());
        }

        [Test]
        public void theta120_phi_45_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 120;
            quantumBit.phiAngle = 45;
            Assert.AreEqual("|Ψ> = 0,5 |0> + 0,612 + 0,612i |1>", quantumBit.printBlochVector());
        }

        [Test]
        public void theta_120_phi_90_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 120;
            quantumBit.phiAngle = 90;
            Assert.AreEqual("|Ψ> = 0,5 |0> + 0,866i |1>", quantumBit.printBlochVector());
        }

        [Test]
        public void theta_120_phi_180_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 120;
            quantumBit.phiAngle = 180;
            Assert.AreEqual("|Ψ> = 0,5 |0> - 0,866 |1>", quantumBit.printBlochVector());
        }

        [Test]
        public void theta_120_phi_270_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 120;
            quantumBit.phiAngle = 270;
            Assert.AreEqual("|Ψ> = 0,5 |0> - 0,866i |1>", quantumBit.printBlochVector());
        }

        [Test]
        public void theta_120_phi_359_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 120;
            quantumBit.phiAngle = 359;
            Assert.AreEqual("|Ψ> = 0,5 |0> + 0,866 - 0,015i |1>", quantumBit.printBlochVector());
        }

        [Test]
        public void theta_180_phi_0_Tests(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 180;
            quantumBit.phiAngle = 0;
            Assert.AreEqual("|Ψ> = 0 |0> + 1 |1>", quantumBit.printBlochVector());
        }

        [Test]
        public void theta_180_phi_45_Tests(){
            quantumBit = new Qubit(180,45);
            Assert.AreEqual("|Ψ> = 0 |0> + 0,707 + 0,707i |1>", quantumBit.printBlochVector());
        }

        [Test]
        public void theta_180_phi_90_Tests(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 180;
            quantumBit.phiAngle = 90;
            Assert.AreEqual("|Ψ> = 0 |0> + i |1>", quantumBit.printBlochVector());
        }

        [Test]
        public void theta_180_phi_180_Tests(){
            quantumBit = new Qubit(180,180);
            Assert.AreEqual("|Ψ> = 0 |0> - 1 |1>", quantumBit.printBlochVector());
        }

        [Test]
        public void theta_180_phi_270_Tests(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 180;
            quantumBit.phiAngle = 270;
            Assert.AreEqual("|Ψ> = 0 |0> - i |1>", quantumBit.printBlochVector());
        }

        [Test]
        public void theta_180_phi_359_Tests(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 180;
            quantumBit.phiAngle = 359;
            Assert.AreEqual("|Ψ> = 0 |0> + 1 - 0,017i |1>", quantumBit.printBlochVector());
        }

        [Test]
        public void invalid_argument_theta_minus_Tests(){
            quantumBit = new Qubit(120,45);
            Assert.AreEqual("|Ψ> = 0,5 |0> + 0,612 + 0,612i |1>", quantumBit.printBlochVector());
            quantumBit.thetaAngle = - 10;
            Assert.AreEqual("|Ψ> = 0,5 |0> + 0,612 + 0,612i |1>", quantumBit.printBlochVector());
        }

        [Test]
        public void invalid_argument_thetha_too_big_Test(){
            quantumBit = new Qubit(120,45);
            Assert.AreEqual("|Ψ> = 0,5 |0> + 0,612 + 0,612i |1>", quantumBit.printBlochVector());
            quantumBit.thetaAngle = - 183;
            Assert.AreEqual("|Ψ> = 0,5 |0> + 0,612 + 0,612i |1>", quantumBit.printBlochVector());
        }

        [Test]
        public void invalid_argument_phi_minus_Test(){
            quantumBit = new Qubit(120,45);
            Assert.AreEqual("|Ψ> = 0,5 |0> + 0,612 + 0,612i |1>", quantumBit.printBlochVector());
            quantumBit.phiAngle= - 13;
            Assert.AreEqual("|Ψ> = 0,5 |0> + 0,612 + 0,612i |1>", quantumBit.printBlochVector());
        }

        [Test]
        public void invalid_argument_phi_too_big_Test(){
            quantumBit = new Qubit(120,45);
            Assert.AreEqual("|Ψ> = 0,5 |0> + 0,612 + 0,612i |1>", quantumBit.printBlochVector());
            quantumBit.thetaAngle = - 378;
            Assert.AreEqual("|Ψ> = 0,5 |0> + 0,612 + 0,612i |1>", quantumBit.printBlochVector());
        }

        [Test]
        public void customSettings_theta30_phi_45_Test_1()
        {
            quantumBit = new Qubit(120,45);
            quantumBit.thetaAngle = 120;
            quantumBit.phiAngle = 45;
            Assert.AreEqual("|Ψ> = 0,5 |0> + 0,612 + 0,612i |1>", quantumBit.printBlochVector());

        }

        [Test]
        public void customSettings_theta30_phi_45_Test_2()
        {
            quantumBit = new Qubit(30,45);
            PrintBlochSettings settings = new PrintBlochSettings(true,true,4,PrintBlochSettings.DecimalSeparator.dot,PrintBlochSettings.ImaginaryUnit.I);
            Assert.AreEqual("|Ψ> = 0.9659 |0> + 0.1830 + 0.1830I |1>",quantumBit.printBlochVector(settings));
            settings = new PrintBlochSettings(true,false,4,PrintBlochSettings.DecimalSeparator.dot,PrintBlochSettings.ImaginaryUnit.I);
            Assert.AreEqual("|Ψ> = 0.9659 |0> + 0.183 + 0.183I |1>",quantumBit.printBlochVector(settings));
        }
        [Test]
        public void customSettings_theta30_phi_45_Test_3()
        {
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 30;
            quantumBit.phiAngle = 45;
            PrintBlochSettings settings = new PrintBlochSettings(false,true,8,PrintBlochSettings.DecimalSeparator.comma,PrintBlochSettings.ImaginaryUnit.j);
            Assert.AreEqual("|Ψ>=0,96592583|0>+0,18301270+0,18301270j|1>",quantumBit.printBlochVector(settings));
            settings = new PrintBlochSettings(false,false,8,PrintBlochSettings.DecimalSeparator.comma,PrintBlochSettings.ImaginaryUnit.j);
            Assert.AreEqual("|Ψ>=0,96592583|0>+0,1830127+0,1830127j|1>",quantumBit.printBlochVector(settings));
        }
        [Test]
        public void customSettings_theta30_phi_45_Test_4()
        {
            quantumBit = new Qubit(30,45);
            PrintBlochSettings settings = new PrintBlochSettings(true,true,15,PrintBlochSettings.DecimalSeparator.dot,PrintBlochSettings.ImaginaryUnit.J);
            Assert.AreEqual("|Ψ> = 0.965925826289068 |0> + 0.183012701892219 + 0.183012701892219J |1>",quantumBit.printBlochVector(settings));
        }
    }
}
