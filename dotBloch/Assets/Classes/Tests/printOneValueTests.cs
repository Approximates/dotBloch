using NUnit.Framework;
using static PrintBlochSettings;

namespace Tests
{
    public class printOneValue
    {
        Qubit quantumBit;

        [Test]
        public void nUnit_Tests()
        {
            Assert.AreEqual(true, true);
            Assert.AreEqual(null, null);
        }
        
        [Test]
        public void theta_0_phi_0_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 0;
            quantumBit.phiAngle = 0;
            Assert.AreEqual("0", quantumBit.printOneValue());
        }

        [Test]
        public void theta_180_phi_0_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 180;
            quantumBit.phiAngle = 0;
            Assert.AreEqual("1", quantumBit.printOneValue());
        }   

        [Test]
        public void theta_30_phi_0_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 30;
            quantumBit.phiAngle = 0;
            Assert.AreEqual("0,259", quantumBit.printOneValue());
        }   

        [Test]
        public void theta_120_phi_180_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 120;
            quantumBit.phiAngle = 180;
            Assert.AreEqual("- 0,866", quantumBit.printOneValue());
        }   

        [Test]
        public void theta_120_phi_270_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 120;
            quantumBit.phiAngle = 270;
            Assert.AreEqual("- 0,866i", quantumBit.printOneValue());
        }  
             
        [Test]
        public void theta_60_phi_45_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 60;
            quantumBit.phiAngle = 45;
            Assert.AreEqual("0,354 + 0,354i", quantumBit.printOneValue());
        }   
             
        [Test]
        public void theta_90_phi_90_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 90;
            quantumBit.phiAngle = 90;
            Assert.AreEqual("0,707i", quantumBit.printOneValue());
        }   
             
        [Test]
        public void custom_settings_theta_90_phi_180_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 90;
            quantumBit.phiAngle = 180;
            PrintBlochSettings settings = new PrintBlochSettings(false,false,3,PrintBlochSettings.DecimalSeparator.comma,PrintBlochSettings.ImaginaryUnit.J);
            Assert.AreEqual("-0,707", quantumBit.printOneValue(settings));
        }
        [Test]
        public void custom_settings_theta_45_phi_45_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 45;
            quantumBit.phiAngle = 45;
            Assert.AreEqual("0,271 + 0,271i", quantumBit.printOneValue());
        }

        [Test]
        public void custom_settings_theta_45_phi_45_with_cutsom_settings_1_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 45;
            quantumBit.phiAngle = 45;
            PrintBlochSettings settings = new PrintBlochSettings(true,false,3,PrintBlochSettings.DecimalSeparator.dot,PrintBlochSettings.ImaginaryUnit.I);
            Assert.AreEqual("0.271 + 0.271I", quantumBit.printOneValue(settings));
        }

        [Test]
        public void custom_settings_theta_45_phi_45_with_cutsom_settings_2_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 45;
            quantumBit.phiAngle = 45;
            PrintBlochSettings settings = new PrintBlochSettings(false,false,3,PrintBlochSettings.DecimalSeparator.comma,PrintBlochSettings.ImaginaryUnit.j); 
            Assert.AreEqual("0,271+0,271j", quantumBit.printOneValue(settings));
        }

        [Test]
        public void theta_change_0_to_30_Test(){
            quantumBit = new Qubit(0,120);
            Assert.AreEqual("0",quantumBit.printOneValue());
            quantumBit.thetaAngle = 30;
            Assert.AreEqual("- 0,129 + 0,224i",quantumBit.printOneValue());
        }

        [Test]
        public void theta_change_30_to_90_Test(){
            quantumBit = new Qubit(30,90);
            Assert.AreEqual("0,259i",quantumBit.printOneValue());
            quantumBit.thetaAngle = 90;
            Assert.AreEqual("0,707i",quantumBit.printOneValue());
        }

        [Test]
        public void theta_change_90_to_120_Test(){
            quantumBit = new Qubit(90,30);
            Assert.AreEqual("0,612 + 0,354i",quantumBit.printOneValue());
            quantumBit.thetaAngle = 120;
            PrintBlochSettings settings = new PrintBlochSettings(false,true,3,DecimalSeparator.dot,ImaginaryUnit.j);
            Assert.AreEqual("0.750+0.433j",quantumBit.printOneValue(settings));
        }
        [Test]
        public void theta_change_120_to_170_Test(){
            quantumBit = new Qubit(120,140);
            Assert.AreEqual("- 0,663 + 0,557i",quantumBit.printOneValue());
            quantumBit.thetaAngle = 170;
            PrintBlochSettings settings = new PrintBlochSettings(true,true,3,DecimalSeparator.comma,ImaginaryUnit.i);
            Assert.AreEqual("- 0,763 + 0,640i",quantumBit.printOneValue(settings));
        }

        [Test]
        public void theta_90_phi_100_Test(){
            quantumBit = new Qubit(90,100);
            Assert.AreEqual("- 0,123 + 0,696i",quantumBit.printOneValue());
        }

        [Test]
        public void theta_95_phi_200_Test(){
            quantumBit = new Qubit(95,200);
            Assert.AreEqual("- 0,693 - 0,252i",quantumBit.printOneValue());
        }
    }
}
