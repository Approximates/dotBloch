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
            
        }

        [Test]
        public void theta_0_phi_45_Tests(){
            quantumBit = new Qubit(0,45);
            
        }

        [Test]
        public void theta_0_phi_90_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 0;
            quantumBit.phiAngle = 90;
            
        }

        [Test]
        public void theta_0_phi_180_Tests(){
            quantumBit = new Qubit(0,180);
            
        }

        [Test]
        public void theta_0_phi_270_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 0;
            quantumBit.phiAngle = 270;
            
        }

        [Test]
        public void theta_0_phi_359_Tests(){
            quantumBit = new Qubit(0,359);
            
        }
        
        [Test]
        public void theta_0_phi_360_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 0;
            quantumBit.phiAngle = 360;
            
        }
        #endregion

        #region theta_30
        [Test]
        public void theta_30_phi_0_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 30;
            quantumBit.phiAngle = 0;
            
        }

        [Test]
        public void theta_30_phi_45_Tests(){
            quantumBit = new Qubit(30,45);

        }

        [Test]
        public void theta_30_phi_90_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 30;
            quantumBit.phiAngle = 90;

        }

        [Test]
        public void theta_30_phi_180_Tests(){
            quantumBit = new Qubit(30,180);

        }

        [Test]
        public void theta_30_phi_270_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 30;
            quantumBit.phiAngle = 270;

        }

        [Test]
        public void theta_30_phi_359_Tests(){
            quantumBit = new Qubit(30,359);

        }

        [Test]
        public void theta_30_phi_360_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 30;
            quantumBit.phiAngle = 360;

        }
        #endregion

        #region theeta_45
        [Test]
        public void theta_45_phi_0_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 45;
            quantumBit.phiAngle = 0;

        }

        [Test]
        public void theta_45_phi_45_Tests(){
            quantumBit = new Qubit(45,45);

        }

        [Test]
        public void theta_45_phi_90_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 45;
            quantumBit.phiAngle = 90;

        }

        [Test]
        public void theta_45_phi_180_Tests(){
            quantumBit = new Qubit(45,180);

        }

        [Test]
        public void theta_45_phi_270_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 45;
            quantumBit.phiAngle = 270;

        }

        [Test]
        public void theta_45_phi_359_Tests(){
            quantumBit = new Qubit(45,359);

        }

        [Test]
        public void theta_45_phi_360_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 45;
            quantumBit.phiAngle = 360;

        }
        #endregion

        #region theta_60
        [Test]
        public void theta_60_phi_0_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 60;
            quantumBit.phiAngle = 0;

        }

        [Test]
        public void theta_60_phi_45_Tests(){
            quantumBit = new Qubit(60,45);

        }

        [Test]
        public void theta_60_phi_90_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 60;
            quantumBit.phiAngle = 90;

        }

        [Test]
        public void theta_60_phi_180_Tests(){
            quantumBit = new Qubit(60,180);

        }

        [Test]
        public void theta_60_phi_270_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 60;
            quantumBit.phiAngle = 270;

        }

        [Test]
        public void theta_60_phi_359_Tests(){
            quantumBit = new Qubit(60,359);

        }

        [Test]
        public void theta_60_phi_360_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 60;
            quantumBit.phiAngle = 360;

        }
        #endregion

        #region theta_90
        [Test]
        public void theta_90_phi_0_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 90;
            quantumBit.phiAngle = 0;

        }

        [Test]
        public void theta_90_phi_45_Tests(){
            quantumBit = new Qubit(90,45);

        }

        [Test]
        public void theta_90_phi_90_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 90;
            quantumBit.phiAngle = 90;

        }

        [Test]
        public void theta_90_phi_180_Tests(){
            quantumBit = new Qubit(90,180);

        }

        [Test]
        public void theta_90_phi_270_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 90;
            quantumBit.phiAngle = 270;

        }

        [Test]
        public void theta_90_phi_359_Tests(){
            quantumBit = new Qubit(90,359);

        }

        [Test]
        public void theta_90_phi_360_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 90;
            quantumBit.phiAngle = 360;

        }
        #endregion

        #region theta_120
        [Test]
        public void theta_120_phi_0_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 120;
            quantumBit.phiAngle = 0;

        }

        [Test]
        public void theta_120_phi_45_Tests(){
            quantumBit = new Qubit(120,45);

        }

        [Test]
        public void theta_120_phi_90_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 120;
            quantumBit.phiAngle = 90;

        }

        [Test]
        public void theta_120_phi_180_Tests(){
            quantumBit = new Qubit(120,180);

        }

        [Test]
        public void theta_120_phi_270_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 120;
            quantumBit.phiAngle = 270;

        }

        [Test]
        public void theta_120_phi_359_Tests(){
            quantumBit = new Qubit(120,359);

        }

        [Test]
        public void theta_120_phi_360_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 120;
            quantumBit.phiAngle = 360;

        }
        #endregion

        #region theta_180
        [Test]
        public void theta_180_phi_0_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 180;
            quantumBit.phiAngle = 0;

        }

        [Test]
        public void theta_180_phi_45_Tests(){
            quantumBit = new Qubit(180,45);

        }

        [Test]
        public void theta_180_phi_90_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 180;
            quantumBit.phiAngle = 90;

        }

        [Test]
        public void theta_180_phi_180_Tests(){
            quantumBit = new Qubit(180,180);

        }

        [Test]
        public void theta_180_phi_270_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 180;
            quantumBit.phiAngle = 270;

        }

        [Test]
        public void theta_180_phi_359_Tests(){
            quantumBit = new Qubit(180,359);

        }

        [Test]
        public void theta_180_phi_360_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 180;
            quantumBit.phiAngle = 360;

        }
        #endregion
    }
}
