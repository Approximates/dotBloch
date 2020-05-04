using System.Diagnostics;
using NUnit.Framework;
using static PrintBlochSettings;

namespace Tests
{
    public class print_quantum_probability
    {
        Qubit quantumBit;

        [Test]
        public void nUnit_Tests()
        {
            Assert.AreEqual(true, true);
            Assert.AreEqual(null, null);
        }    

        #region theta_0
        [Test]
        public void theta_0_phi_0_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 0;
            quantumBit.phiAngle = 0;
            
            Assert.AreEqual("P(|0>) = 100%", quantumBit.print_zero_probability());
            Assert.AreEqual("P(|1>) = 0%", quantumBit.print_one_probability());
        }

        [Test]
        public void theta_0_phi_45_Tests(){
            quantumBit = new Qubit(0,45);
            
            Assert.AreEqual("P(|0>) = 100%", quantumBit.print_zero_probability());
            Assert.AreEqual("P(|1>) = 0%", quantumBit.print_one_probability());
        }

        [Test]
        public void theta_0_phi_90_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 0;
            quantumBit.phiAngle = 90;
            
            Assert.AreEqual("P(|0>) = 100%", quantumBit.print_zero_probability());
            Assert.AreEqual("P(|1>) = 0%", quantumBit.print_one_probability());
        }

        [Test]
        public void theta_0_phi_180_Tests(){
            quantumBit = new Qubit(0,180);

            Assert.AreEqual("P(|0>) = 100%", quantumBit.print_zero_probability());
            Assert.AreEqual("P(|1>) = 0%", quantumBit.print_one_probability());
        }

        [Test]
        public void theta_0_phi_270_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 0;
            quantumBit.phiAngle = 270;
            
            Assert.AreEqual("P(|0>) = 100%", quantumBit.print_zero_probability());
            Assert.AreEqual("P(|1>) = 0%", quantumBit.print_one_probability());
        }

        [Test]
        public void theta_0_phi_359_Tests(){
            quantumBit = new Qubit(0,359);
            
            Assert.AreEqual("P(|0>) = 100%", quantumBit.print_zero_probability());
            Assert.AreEqual("P(|1>) = 0%", quantumBit.print_one_probability());
        }
        
        [Test]
        public void theta_0_phi_360_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 0;
            quantumBit.phiAngle = 360;
            
            Assert.AreEqual("P(|0>) = 100%", quantumBit.print_zero_probability());
            Assert.AreEqual("P(|1>) = 0%", quantumBit.print_one_probability());
        }
        #endregion

        #region theta_30
        [Test]
        public void theta_30_phi_0_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 30;
            quantumBit.phiAngle = 0;
            
            Assert.AreEqual("P(|0>) = 93,301%", quantumBit.print_zero_probability());
            Assert.AreEqual("P(|1>) = 6,699%", quantumBit.print_one_probability());
        }

        [Test]
        public void theta_30_phi_45_Tests(){
            quantumBit = new Qubit(30,45);

            Assert.AreEqual("P(|0>) = 93,301%", quantumBit.print_zero_probability());
            Assert.AreEqual("P(|1>) = 6,699%", quantumBit.print_one_probability());
        }

        [Test]
        public void theta_30_phi_90_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 30;
            quantumBit.phiAngle = 90;

            Assert.AreEqual("P(|0>) = 93,301%", quantumBit.print_zero_probability());
            Assert.AreEqual("P(|1>) = 6,699%", quantumBit.print_one_probability());
        }

        [Test]
        public void theta_30_phi_180_Tests(){
            quantumBit = new Qubit(30,180);

            Assert.AreEqual("P(|0>) = 93,301%", quantumBit.print_zero_probability());
            Assert.AreEqual("P(|1>) = 6,699%", quantumBit.print_one_probability());
        }

        [Test]
        public void theta_30_phi_270_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 30;
            quantumBit.phiAngle = 270;

            Assert.AreEqual("P(|0>) = 93,301%", quantumBit.print_zero_probability());
            Assert.AreEqual("P(|1>) = 6,699%", quantumBit.print_one_probability());
        }

        [Test]
        public void theta_30_phi_359_Tests(){
            quantumBit = new Qubit(30,359);

            Assert.AreEqual("P(|0>) = 93,301%", quantumBit.print_zero_probability());
            Assert.AreEqual("P(|1>) = 6,699%", quantumBit.print_one_probability());
        }

        [Test]
        public void theta_30_phi_360_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 30;
            quantumBit.phiAngle = 360;

            Assert.AreEqual("P(|0>) = 93,301%", quantumBit.print_zero_probability());
            Assert.AreEqual("P(|1>) = 6,699%", quantumBit.print_one_probability());
        }
        #endregion

        #region theeta_45
        [Test]
        public void theta_45_phi_0_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 45;
            quantumBit.phiAngle = 0;

            Assert.AreEqual("P(|0>) = 85,355%", quantumBit.print_zero_probability());
            Assert.AreEqual("P(|1>) = 14,645%", quantumBit.print_one_probability());
        }

        [Test]
        public void theta_45_phi_45_Tests(){
            quantumBit = new Qubit(45,45);
            
            Assert.AreEqual("P(|0>) = 85,355%", quantumBit.print_zero_probability());
            Assert.AreEqual("P(|1>) = 14,645%", quantumBit.print_one_probability());
        }

        [Test]
        public void theta_45_phi_90_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 45;
            quantumBit.phiAngle = 90;

            Assert.AreEqual("P(|0>) = 85,355%", quantumBit.print_zero_probability());
            Assert.AreEqual("P(|1>) = 14,645%", quantumBit.print_one_probability());
        }

        [Test]
        public void theta_45_phi_180_Tests(){
            quantumBit = new Qubit(45,180);
            
            Assert.AreEqual("P(|0>) = 85,355%", quantumBit.print_zero_probability());
            Assert.AreEqual("P(|1>) = 14,645%", quantumBit.print_one_probability());
        }

        [Test]
        public void theta_45_phi_270_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 45;
            quantumBit.phiAngle = 270;

            Assert.AreEqual("P(|0>) = 85,355%", quantumBit.print_zero_probability());
            Assert.AreEqual("P(|1>) = 14,645%", quantumBit.print_one_probability());
        }

        [Test]
        public void theta_45_phi_359_Tests(){
            quantumBit = new Qubit(45,359);

            Assert.AreEqual("P(|0>) = 85,355%", quantumBit.print_zero_probability());
            Assert.AreEqual("P(|1>) = 14,645%", quantumBit.print_one_probability());
        }

        [Test]
        public void theta_45_phi_360_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 45;
            quantumBit.phiAngle = 360;
            
            Assert.AreEqual("P(|0>) = 85,355%", quantumBit.print_zero_probability());
            Assert.AreEqual("P(|1>) = 14,645%", quantumBit.print_one_probability());
        }
        #endregion

        #region theta_60
        [Test]
        public void theta_60_phi_0_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 60;
            quantumBit.phiAngle = 0;

            Assert.AreEqual("P(|0>) = 75%", quantumBit.print_zero_probability());
            Assert.AreEqual("P(|1>) = 25%", quantumBit.print_one_probability());
        }

        [Test]
        public void theta_60_phi_45_Tests(){
            quantumBit = new Qubit(60,45);
            
            Assert.AreEqual("P(|0>) = 75%", quantumBit.print_zero_probability());
            Assert.AreEqual("P(|1>) = 25%", quantumBit.print_one_probability());
        }

        [Test]
        public void theta_60_phi_90_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 60;
            quantumBit.phiAngle = 90;

            Assert.AreEqual("P(|0>) = 75%", quantumBit.print_zero_probability());
            Assert.AreEqual("P(|1>) = 25%", quantumBit.print_one_probability());
        }

        [Test]
        public void theta_60_phi_180_Tests(){
            quantumBit = new Qubit(60,180);

            Assert.AreEqual("P(|0>) = 75%", quantumBit.print_zero_probability());
            Assert.AreEqual("P(|1>) = 25%", quantumBit.print_one_probability());
        }

        [Test]
        public void theta_60_phi_270_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 60;
            quantumBit.phiAngle = 270;
            
            Assert.AreEqual("P(|0>) = 75%", quantumBit.print_zero_probability());
            Assert.AreEqual("P(|1>) = 25%", quantumBit.print_one_probability());
        }  

        [Test]
        public void theta_60_phi_359_Tests(){
            quantumBit = new Qubit(60,359);

            Assert.AreEqual("P(|0>) = 75%", quantumBit.print_zero_probability());
            Assert.AreEqual("P(|1>) = 25%", quantumBit.print_one_probability());
        }

        [Test]
        public void theta_60_phi_360_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 60;
            quantumBit.phiAngle = 360;

            Assert.AreEqual("P(|0>) = 75%", quantumBit.print_zero_probability());
            Assert.AreEqual("P(|1>) = 25%", quantumBit.print_one_probability());
        }
        #endregion

        #region theta_90
        [Test]
        public void theta_90_phi_0_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 90;
            quantumBit.phiAngle = 0;

            Assert.AreEqual("P(|0>) = 50%", quantumBit.print_zero_probability());
            Assert.AreEqual("P(|1>) = 50%", quantumBit.print_one_probability());
        }

        [Test]
        public void theta_90_phi_45_Tests(){
            quantumBit = new Qubit(90,45);

            Assert.AreEqual("P(|0>) = 50%", quantumBit.print_zero_probability());
            Assert.AreEqual("P(|1>) = 50%", quantumBit.print_one_probability());
        }

        [Test]
        public void theta_90_phi_90_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 90;
            quantumBit.phiAngle = 90;

            Assert.AreEqual("P(|0>) = 50%", quantumBit.print_zero_probability());
            Assert.AreEqual("P(|1>) = 50%", quantumBit.print_one_probability());
        }

        [Test]
        public void theta_90_phi_180_Tests(){
            quantumBit = new Qubit(90,180);
            Assert.AreEqual("P(|0>) = 50%", quantumBit.print_zero_probability());
            Assert.AreEqual("P(|1>) = 50%", quantumBit.print_one_probability());

        }

        [Test]
        public void theta_90_phi_270_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 90;
            quantumBit.phiAngle = 270;

            Assert.AreEqual("P(|0>) = 50%", quantumBit.print_zero_probability());
            Assert.AreEqual("P(|1>) = 50%", quantumBit.print_one_probability());
        }

        [Test]
        public void theta_90_phi_359_Tests(){
            quantumBit = new Qubit(90,359);

            Assert.AreEqual("P(|0>) = 50%", quantumBit.print_zero_probability());
            Assert.AreEqual("P(|1>) = 50%", quantumBit.print_one_probability());
        }

        [Test]
        public void theta_90_phi_360_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 90;
            quantumBit.phiAngle = 360;

            Assert.AreEqual("P(|0>) = 50%", quantumBit.print_zero_probability());
            Assert.AreEqual("P(|1>) = 50%", quantumBit.print_one_probability());
        }
        #endregion

        #region theta_120
        [Test]
        public void theta_120_phi_0_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 120;
            quantumBit.phiAngle = 0;

            Assert.AreEqual("P(|0>) = 25%", quantumBit.print_zero_probability());
            Assert.AreEqual("P(|1>) = 75%", quantumBit.print_one_probability());
        }

        [Test]
        public void theta_120_phi_45_Tests(){
            quantumBit = new Qubit(120,45);

            Assert.AreEqual("P(|0>) = 25%", quantumBit.print_zero_probability());
            Assert.AreEqual("P(|1>) = 75%", quantumBit.print_one_probability());
        }

        [Test]
        public void theta_120_phi_90_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 120;
            quantumBit.phiAngle = 90;

            Assert.AreEqual("P(|0>) = 25%", quantumBit.print_zero_probability());
            Assert.AreEqual("P(|1>) = 75%", quantumBit.print_one_probability());
        }

        [Test]
        public void theta_120_phi_180_Tests(){
            quantumBit = new Qubit(120,180);

            Assert.AreEqual("P(|0>) = 25%", quantumBit.print_zero_probability());
            Assert.AreEqual("P(|1>) = 75%", quantumBit.print_one_probability());
        }

        [Test]
        public void theta_120_phi_270_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 120;
            quantumBit.phiAngle = 270;

            Assert.AreEqual("P(|0>) = 25%", quantumBit.print_zero_probability());
            Assert.AreEqual("P(|1>) = 75%", quantumBit.print_one_probability());
        }

        [Test]
        public void theta_120_phi_359_Tests(){
            quantumBit = new Qubit(120,359);

            Assert.AreEqual("P(|0>) = 25%", quantumBit.print_zero_probability());
            Assert.AreEqual("P(|1>) = 75%", quantumBit.print_one_probability());
        }

        [Test]
        public void theta_120_phi_360_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 120;
            quantumBit.phiAngle = 360;

            Assert.AreEqual("P(|0>) = 25%", quantumBit.print_zero_probability());
            Assert.AreEqual("P(|1>) = 75%", quantumBit.print_one_probability());
        }
        #endregion

        #region theta_180
        [Test]
        public void theta_180_phi_0_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 180;
            quantumBit.phiAngle = 0;

            Assert.AreEqual("P(|0>) = 0%", quantumBit.print_zero_probability());
            Assert.AreEqual("P(|1>) = 100%", quantumBit.print_one_probability());
        }

        [Test]
        public void theta_180_phi_45_Tests(){
            quantumBit = new Qubit(180,45);

            Assert.AreEqual("P(|0>) = 0%", quantumBit.print_zero_probability());
            Assert.AreEqual("P(|1>) = 100%", quantumBit.print_one_probability());
        }

        [Test]
        public void theta_180_phi_90_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 180;
            quantumBit.phiAngle = 90;

            Assert.AreEqual("P(|0>) = 0%", quantumBit.print_zero_probability());
            Assert.AreEqual("P(|1>) = 100%", quantumBit.print_one_probability());
        }

        [Test]
        public void theta_180_phi_180_Tests(){
            quantumBit = new Qubit(180,180);

            Assert.AreEqual("P(|0>) = 0%", quantumBit.print_zero_probability());
            Assert.AreEqual("P(|1>) = 100%", quantumBit.print_one_probability());
        }

        [Test]
        public void theta_180_phi_270_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 180;
            quantumBit.phiAngle = 270;

            Assert.AreEqual("P(|0>) = 0%", quantumBit.print_zero_probability());
            Assert.AreEqual("P(|1>) = 100%", quantumBit.print_one_probability());
        }

        [Test]
        public void theta_180_phi_359_Tests(){
            quantumBit = new Qubit(180,359);

            Assert.AreEqual("P(|0>) = 0%", quantumBit.print_zero_probability());
            Assert.AreEqual("P(|1>) = 100%", quantumBit.print_one_probability());
        }

        [Test]
        public void theta_180_phi_360_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 180;
            quantumBit.phiAngle = 360;

            Assert.AreEqual("P(|0>) = 0%", quantumBit.print_zero_probability());
            Assert.AreEqual("P(|1>) = 100%", quantumBit.print_one_probability());
        }
        #endregion
    
        #region custom_printing

        [Test]
        public void custom_settings_theta_45_phi_45_with_cutsom_settings_1_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 45;
            quantumBit.phiAngle = 45;
            PrintBlochSettings settings = new PrintBlochSettings(true,false,2,PrintBlochSettings.DecimalSeparator.dot,PrintBlochSettings.ImaginaryUnit.I);
            Assert.AreEqual("P(|0>) = 85.36%", quantumBit.print_zero_probability(settings));
            Assert.AreEqual("P(|1>) = 14.64%", quantumBit.print_one_probability(settings));
        }

        [Test]
        public void custom_settings_theta_45_phi_45_with_cutsom_settings_2_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 45;
            quantumBit.phiAngle = 45;
            PrintBlochSettings settings = new PrintBlochSettings(false,false,1,PrintBlochSettings.DecimalSeparator.comma,PrintBlochSettings.ImaginaryUnit.j); 
            Assert.AreEqual("P(|0>)=85,4%", quantumBit.print_zero_probability(settings));
            Assert.AreEqual("P(|1>)=14,6%", quantumBit.print_one_probability(settings));
        }

        #endregion
    }
}
