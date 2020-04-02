using System.Diagnostics;
using NUnit.Framework;
using static PrintBlochSettings;

namespace Tests
{
    public class printDensityMatrix
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
            Assert.AreEqual("1", quantumBit.printDensityMatrix(0,0));
            Assert.AreEqual("0", quantumBit.printDensityMatrix(0,1));
            Assert.AreEqual("0", quantumBit.printDensityMatrix(1,0));
            Assert.AreEqual("0", quantumBit.printDensityMatrix(1,1));
        }

        [Test]
        public void theta_0_phi_45_Tests(){
            quantumBit = new Qubit(0,45);
            Assert.AreEqual("1", quantumBit.printDensityMatrix(0,0));
            Assert.AreEqual("0", quantumBit.printDensityMatrix(0,1));
            Assert.AreEqual("0", quantumBit.printDensityMatrix(1,0));
            Assert.AreEqual("0", quantumBit.printDensityMatrix(1,1));
        }

        [Test]
        public void theta_0_phi_90_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 0;
            quantumBit.phiAngle = 90;
            Assert.AreEqual("1", quantumBit.printDensityMatrix(0,0));
            Assert.AreEqual("0", quantumBit.printDensityMatrix(0,1));
            Assert.AreEqual("0", quantumBit.printDensityMatrix(1,0));
            Assert.AreEqual("0", quantumBit.printDensityMatrix(1,1));
        }

        [Test]
        public void theta_0_phi_180_Tests(){
            quantumBit = new Qubit(0,180);
            Assert.AreEqual("1", quantumBit.printDensityMatrix(0,0));
            Assert.AreEqual("0", quantumBit.printDensityMatrix(0,1));
            Assert.AreEqual("0", quantumBit.printDensityMatrix(1,0));
            Assert.AreEqual("0", quantumBit.printDensityMatrix(1,1));
        }

        [Test]
        public void theta_0_phi_270_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 0;
            quantumBit.phiAngle = 270;
            Assert.AreEqual("1", quantumBit.printDensityMatrix(0,0));
            Assert.AreEqual("0", quantumBit.printDensityMatrix(0,1));
            Assert.AreEqual("0", quantumBit.printDensityMatrix(1,0));
            Assert.AreEqual("0", quantumBit.printDensityMatrix(1,1));
        }

        [Test]
        public void theta_0_phi_359_Tests(){
            quantumBit = new Qubit(0,359);
            Assert.AreEqual("1", quantumBit.printDensityMatrix(0,0));
            Assert.AreEqual("0", quantumBit.printDensityMatrix(0,1));
            Assert.AreEqual("0", quantumBit.printDensityMatrix(1,0));
            Assert.AreEqual("0", quantumBit.printDensityMatrix(1,1));
        }
        
        [Test]
        public void theta_0_phi_360_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 0;
            quantumBit.phiAngle = 360;
            Assert.AreEqual("1", quantumBit.printDensityMatrix(0,0));
            Assert.AreEqual("0", quantumBit.printDensityMatrix(0,1));
            Assert.AreEqual("0", quantumBit.printDensityMatrix(1,0));
            Assert.AreEqual("0", quantumBit.printDensityMatrix(1,1));
        }
        #endregion

        #region theta_30
        [Test]
        public void theta_30_phi_0_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 30;
            quantumBit.phiAngle = 0;
            
            Assert.AreEqual("0,933", quantumBit.printDensityMatrix(0,0));
            Assert.AreEqual("0,25", quantumBit.printDensityMatrix(0,1));
            Assert.AreEqual("0,25", quantumBit.printDensityMatrix(1,0));
            Assert.AreEqual("0.067", quantumBit.printDensityMatrix(1,1));
        }

        [Test]
        public void theta_30_phi_45_Tests(){
            quantumBit = new Qubit(30,45);
            Assert.AreEqual("0,933", quantumBit.printDensityMatrix(0,0));
            Assert.AreEqual("0,179", quantumBit.printDensityMatrix(0,1));
            Assert.AreEqual("0,177 + 0,177i", quantumBit.printDensityMatrix(1,0));
            Assert.AreEqual("0,0667", quantumBit.printDensityMatrix(1,1));
        }

        [Test]
        public void theta_30_phi_90_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 30;
            quantumBit.phiAngle = 90;
            Assert.AreEqual("0,933", quantumBit.printDensityMatrix(0,0));
            Assert.AreEqual("0 - 0,25i", quantumBit.printDensityMatrix(0,1));
            Assert.AreEqual("0 + 0,25i", quantumBit.printDensityMatrix(1,0));
            Assert.AreEqual("0,067", quantumBit.printDensityMatrix(1,1));
        }

        [Test]
        public void theta_30_phi_180_Tests(){
            quantumBit = new Qubit(30,180);
            Assert.AreEqual("0,933", quantumBit.printDensityMatrix(0,0));
            Assert.AreEqual("-0,25", quantumBit.printDensityMatrix(0,1));
            Assert.AreEqual("-0,25", quantumBit.printDensityMatrix(1,0));
            Assert.AreEqual("0,067", quantumBit.printDensityMatrix(1,1));
        }

        [Test]
        public void theta_30_phi_270_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 30;
            quantumBit.phiAngle = 270;
            Assert.AreEqual("0,933", quantumBit.printDensityMatrix(0,0));
            Assert.AreEqual("0 + 0,25i", quantumBit.printDensityMatrix(0,1));
            Assert.AreEqual("0 - 0,25i", quantumBit.printDensityMatrix(1,0));
            Assert.AreEqual("0,067", quantumBit.printDensityMatrix(1,1));
        }

        [Test]
        public void theta_30_phi_359_Tests(){
            quantumBit = new Qubit(30,359);
            Assert.AreEqual("0,933", quantumBit.printDensityMatrix(0,0));
            Assert.AreEqual("0,25 + 0,004i", quantumBit.printDensityMatrix(0,1));
            Assert.AreEqual("0,25 - 0,004i", quantumBit.printDensityMatrix(1,0));
            Assert.AreEqual("0,067", quantumBit.printDensityMatrix(1,1));
        }

        [Test]
        public void theta_30_phi_360_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 30;
            quantumBit.phiAngle = 360;
            Assert.AreEqual("0,933", quantumBit.printDensityMatrix(0,0));
            Assert.AreEqual("0,25", quantumBit.printDensityMatrix(0,1));
            Assert.AreEqual("0,25", quantumBit.printDensityMatrix(1,0));
            Assert.AreEqual("0,067", quantumBit.printDensityMatrix(1,1));
        }
        #endregion

        #region theeta_45
        [Test]
        public void theta_45_phi_0_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 45;
            quantumBit.phiAngle = 0;
            Assert.AreEqual("0,854", quantumBit.printDensityMatrix(0,0));
            Assert.AreEqual("0,354", quantumBit.printDensityMatrix(0,1));
            Assert.AreEqual("0,354", quantumBit.printDensityMatrix(1,0));
            Assert.AreEqual("0,146", quantumBit.printDensityMatrix(1,1));
        }

        [Test]
        public void theta_45_phi_45_Tests(){
            quantumBit = new Qubit(45,45);
            Assert.AreEqual("0,854", quantumBit.printDensityMatrix(0,0));
            Assert.AreEqual("0,25 - 0,25i", quantumBit.printDensityMatrix(0,1));
            Assert.AreEqual("0,25 + 0,25i", quantumBit.printDensityMatrix(1,0));
            Assert.AreEqual("0,146", quantumBit.printDensityMatrix(1,1));
        }

        [Test]
        public void theta_45_phi_90_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 45;
            quantumBit.phiAngle = 90;
            Assert.AreEqual("0,854", quantumBit.printDensityMatrix(0,0));
            Assert.AreEqual("0 - 0,354", quantumBit.printDensityMatrix(0,1));
            Assert.AreEqual("0 + 0,354", quantumBit.printDensityMatrix(1,0));
            Assert.AreEqual("0,146", quantumBit.printDensityMatrix(1,1));
        }

        [Test]
        public void theta_45_phi_180_Tests(){
            quantumBit = new Qubit(45,180);
            Assert.AreEqual("0,854", quantumBit.printDensityMatrix(0,0));
            Assert.AreEqual("- 0,354", quantumBit.printDensityMatrix(0,1));
            Assert.AreEqual("- 0,354", quantumBit.printDensityMatrix(1,0));
            Assert.AreEqual("0,146", quantumBit.printDensityMatrix(1,1));
        }

        [Test]
        public void theta_45_phi_270_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 45;
            quantumBit.phiAngle = 270;
            Assert.AreEqual("0,854", quantumBit.printDensityMatrix(0,0));
            Assert.AreEqual("0 + 0,354i", quantumBit.printDensityMatrix(0,1));
            Assert.AreEqual("0 - 0,354i", quantumBit.printDensityMatrix(1,0));
            Assert.AreEqual("0,146", quantumBit.printDensityMatrix(1,1));
        }

        [Test]
        public void theta_45_phi_359_Tests(){
            quantumBit = new Qubit(45,359);
            Assert.AreEqual("0,854", quantumBit.printDensityMatrix(0,0));
            Assert.AreEqual("0,354 + 0,006i", quantumBit.printDensityMatrix(0,1));
            Assert.AreEqual("0,354 - 0,006i", quantumBit.printDensityMatrix(1,0));
            Assert.AreEqual("0,146", quantumBit.printDensityMatrix(1,1));
        }

        [Test]
        public void theta_45_phi_360_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 45;
            quantumBit.phiAngle = 360;
            Assert.AreEqual("0,854", quantumBit.printDensityMatrix(0,0));
            Assert.AreEqual("0,354", quantumBit.printDensityMatrix(0,1));
            Assert.AreEqual("0,354", quantumBit.printDensityMatrix(1,0));
            Assert.AreEqual("0,146", quantumBit.printDensityMatrix(1,1));
        }
        #endregion

        #region theta_60
        [Test]
        public void theta_60_phi_0_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 60;
            quantumBit.phiAngle = 0;
            Assert.AreEqual("0,75", quantumBit.printDensityMatrix(0,0));
            Assert.AreEqual("0,433", quantumBit.printDensityMatrix(0,1));
            Assert.AreEqual("0,433", quantumBit.printDensityMatrix(1,0));
            Assert.AreEqual("0,25", quantumBit.printDensityMatrix(1,1));
        }

        [Test]
        public void theta_60_phi_45_Tests(){
            quantumBit = new Qubit(60,45);
            Assert.AreEqual("0,75", quantumBit.printDensityMatrix(0,0));
            Assert.AreEqual("0,306 - 0,306i", quantumBit.printDensityMatrix(0,1));
            Assert.AreEqual("0,306 + 0,306i", quantumBit.printDensityMatrix(1,0));
            Assert.AreEqual("0,25", quantumBit.printDensityMatrix(1,1));
        }

        [Test]
        public void theta_60_phi_90_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 60;
            quantumBit.phiAngle = 90;
            Assert.AreEqual("0,75", quantumBit.printDensityMatrix(0,0));
            Assert.AreEqual("- 0,433i", quantumBit.printDensityMatrix(0,1));
            Assert.AreEqual("0,433i", quantumBit.printDensityMatrix(1,0));
            Assert.AreEqual("0,25", quantumBit.printDensityMatrix(1,1));
        }

        [Test]
        public void theta_60_phi_180_Tests(){
            quantumBit = new Qubit(60,180);
            Assert.AreEqual("0,75", quantumBit.printDensityMatrix(0,0));
            Assert.AreEqual("- 0,433", quantumBit.printDensityMatrix(0,1));
            Assert.AreEqual("- 0,433", quantumBit.printDensityMatrix(1,0));
            Assert.AreEqual("0,25", quantumBit.printDensityMatrix(1,1));
        }

        [Test]
        public void theta_60_phi_270_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 60;
            quantumBit.phiAngle = 270;
            Assert.AreEqual("0,75", quantumBit.printDensityMatrix(0,0));
            Assert.AreEqual("0,433i", quantumBit.printDensityMatrix(0,1));
            Assert.AreEqual("- 0,433i", quantumBit.printDensityMatrix(1,0));
            Assert.AreEqual("0,25", quantumBit.printDensityMatrix(1,1));
        }

        [Test]
        public void theta_60_phi_359_Tests(){
            quantumBit = new Qubit(60,359);
            Assert.AreEqual("0,75", quantumBit.printDensityMatrix(0,0));
            Assert.AreEqual("0,433 + 0,008i", quantumBit.printDensityMatrix(0,1));
            Assert.AreEqual("0,433 - 0,008i", quantumBit.printDensityMatrix(1,0));
            Assert.AreEqual("0,25", quantumBit.printDensityMatrix(1,1));
        }

        [Test]
        public void theta_60_phi_360_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 60;
            quantumBit.phiAngle = 360;
            Assert.AreEqual("0,75", quantumBit.printDensityMatrix(0,0));
            Assert.AreEqual("0,433", quantumBit.printDensityMatrix(0,1));
            Assert.AreEqual("0,433", quantumBit.printDensityMatrix(1,0));
            Assert.AreEqual("0,25", quantumBit.printDensityMatrix(1,1));
        }
        #endregion

        #region theta_90
        [Test]
        public void theta_90_phi_0_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 90;
            quantumBit.phiAngle = 0;
            Assert.AreEqual("0,5", quantumBit.printDensityMatrix(0,0));
            Assert.AreEqual("0,5", quantumBit.printDensityMatrix(0,1));
            Assert.AreEqual("0,5", quantumBit.printDensityMatrix(1,0));
            Assert.AreEqual("0,5", quantumBit.printDensityMatrix(1,1));
        }

        [Test]
        public void theta_90_phi_45_Tests(){
            quantumBit = new Qubit(90,45);
            Assert.AreEqual("0,5", quantumBit.printDensityMatrix(0,0));
            Assert.AreEqual("0,354 - 0,354i", quantumBit.printDensityMatrix(0,1));
            Assert.AreEqual("0,354 + 0,354i", quantumBit.printDensityMatrix(1,0));
            Assert.AreEqual("0,5", quantumBit.printDensityMatrix(1,1));
        }

        [Test]
        public void theta_90_phi_90_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 90;
            quantumBit.phiAngle = 90;
            Assert.AreEqual("0,5", quantumBit.printDensityMatrix(0,0));
            Assert.AreEqual("- 0,5i", quantumBit.printDensityMatrix(0,1));
            Assert.AreEqual("0,5i", quantumBit.printDensityMatrix(1,0));
            Assert.AreEqual("0,5", quantumBit.printDensityMatrix(1,1));
        }

        [Test]
        public void theta_90_phi_180_Tests(){
            quantumBit = new Qubit(90,180);
            Assert.AreEqual("0,5", quantumBit.printDensityMatrix(0,0));
            Assert.AreEqual("- 0,5", quantumBit.printDensityMatrix(0,1));
            Assert.AreEqual("- 0,5", quantumBit.printDensityMatrix(1,0));
            Assert.AreEqual("0,5", quantumBit.printDensityMatrix(1,1));
        }

        [Test]
        public void theta_90_phi_270_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 90;
            quantumBit.phiAngle = 270;
            Assert.AreEqual("0,5", quantumBit.printDensityMatrix(0,0));
            Assert.AreEqual("0,5i", quantumBit.printDensityMatrix(0,1));
            Assert.AreEqual("- 0,5i", quantumBit.printDensityMatrix(1,0));
            Assert.AreEqual("0,5", quantumBit.printDensityMatrix(1,1));
        }

        [Test]
        public void theta_90_phi_359_Tests(){
            quantumBit = new Qubit(90,359);
            Assert.AreEqual("0,5", quantumBit.printDensityMatrix(0,0));
            Assert.AreEqual("0,5 + 0,009i", quantumBit.printDensityMatrix(0,1));
            Assert.AreEqual("0,5 - 0,009", quantumBit.printDensityMatrix(1,0));
            Assert.AreEqual("0,5", quantumBit.printDensityMatrix(1,1));
        }

        [Test]
        public void theta_90_phi_360_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 90;
            quantumBit.phiAngle = 360;
            Assert.AreEqual("0,5", quantumBit.printDensityMatrix(0,0));
            Assert.AreEqual("0,5", quantumBit.printDensityMatrix(0,1));
            Assert.AreEqual("0,5", quantumBit.printDensityMatrix(1,0));
            Assert.AreEqual("0,5", quantumBit.printDensityMatrix(1,1));
        }
        #endregion

        #region theta_120
        [Test]
        public void theta_120_phi_0_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 120;
            quantumBit.phiAngle = 0;
            Assert.AreEqual("0,25", quantumBit.printDensityMatrix(0,0));
            Assert.AreEqual("0,433", quantumBit.printDensityMatrix(0,1));
            Assert.AreEqual("0,433", quantumBit.printDensityMatrix(1,0));
            Assert.AreEqual("0,75", quantumBit.printDensityMatrix(1,1));
        }

        [Test]
        public void theta_120_phi_45_Tests(){
            quantumBit = new Qubit(120,45);
            Assert.AreEqual("0,25", quantumBit.printDensityMatrix(0,0));
            Assert.AreEqual("0,306 - 0,306i", quantumBit.printDensityMatrix(0,1));
            Assert.AreEqual("0,306 + 0,306i", quantumBit.printDensityMatrix(1,0));
            Assert.AreEqual("0,75", quantumBit.printDensityMatrix(1,1));
        }

        [Test]
        public void theta_120_phi_90_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 120;
            quantumBit.phiAngle = 90;
            Assert.AreEqual("0,25", quantumBit.printDensityMatrix(0,0));
            Assert.AreEqual("- 0,357i", quantumBit.printDensityMatrix(0,1));
            Assert.AreEqual("0,357i", quantumBit.printDensityMatrix(1,0));
            Assert.AreEqual("0,75", quantumBit.printDensityMatrix(1,1));
        }

        [Test]
        public void theta_120_phi_180_Tests(){
            quantumBit = new Qubit(120,180);
            Assert.AreEqual("0,25", quantumBit.printDensityMatrix(0,0));
            Assert.AreEqual("- 0,433", quantumBit.printDensityMatrix(0,1));
            Assert.AreEqual("- 0,433", quantumBit.printDensityMatrix(1,0));
            Assert.AreEqual("0,75", quantumBit.printDensityMatrix(1,1));
        }

        [Test]
        public void theta_120_phi_270_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 120;
            quantumBit.phiAngle = 270;
            Assert.AreEqual("0,25", quantumBit.printDensityMatrix(0,0));
            Assert.AreEqual("0,433i", quantumBit.printDensityMatrix(0,1));
            Assert.AreEqual("- 0,433i", quantumBit.printDensityMatrix(1,0));
            Assert.AreEqual("0,75", quantumBit.printDensityMatrix(1,1));
        }

        [Test]
        public void theta_120_phi_359_Tests(){
            quantumBit = new Qubit(120,359);
            Assert.AreEqual("0,25", quantumBit.printDensityMatrix(0,0));
            Assert.AreEqual("0,433 + 0,008i", quantumBit.printDensityMatrix(0,1));
            Assert.AreEqual("0,433 - 0,008i", quantumBit.printDensityMatrix(1,0));
            Assert.AreEqual("0,75", quantumBit.printDensityMatrix(1,1));
        }

        [Test]
        public void theta_120_phi_360_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 120;
            quantumBit.phiAngle = 360;
            Assert.AreEqual("0,25", quantumBit.printDensityMatrix(0,0));
            Assert.AreEqual("0,433", quantumBit.printDensityMatrix(0,1));
            Assert.AreEqual("0,433", quantumBit.printDensityMatrix(1,0));
            Assert.AreEqual("0,75", quantumBit.printDensityMatrix(1,1));
        }
        #endregion

        #region theta_180
        [Test]
        public void theta_180_phi_0_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 180;
            quantumBit.phiAngle = 0;
            Assert.AreEqual("0", quantumBit.printDensityMatrix(0,0));
            Assert.AreEqual("0", quantumBit.printDensityMatrix(0,1));
            Assert.AreEqual("0", quantumBit.printDensityMatrix(1,0));
            Assert.AreEqual("1", quantumBit.printDensityMatrix(1,1));
        }

        [Test]
        public void theta_180_phi_45_Tests(){
            quantumBit = new Qubit(180,45);
            Assert.AreEqual("0", quantumBit.printDensityMatrix(0,0));
            Assert.AreEqual("0", quantumBit.printDensityMatrix(0,1));
            Assert.AreEqual("0", quantumBit.printDensityMatrix(1,0));
            Assert.AreEqual("1", quantumBit.printDensityMatrix(1,1));
        }

        [Test]
        public void theta_180_phi_90_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 180;
            quantumBit.phiAngle = 90;
            Assert.AreEqual("0", quantumBit.printDensityMatrix(0,0));
            Assert.AreEqual("0", quantumBit.printDensityMatrix(0,1));
            Assert.AreEqual("0", quantumBit.printDensityMatrix(1,0));
            Assert.AreEqual("1", quantumBit.printDensityMatrix(1,1));
        }

        [Test]
        public void theta_180_phi_180_Tests(){
            quantumBit = new Qubit(180,180);
            Assert.AreEqual("0", quantumBit.printDensityMatrix(0,0));
            Assert.AreEqual("0", quantumBit.printDensityMatrix(0,1));
            Assert.AreEqual("0", quantumBit.printDensityMatrix(1,0));
            Assert.AreEqual("1", quantumBit.printDensityMatrix(1,1));
        }

        [Test]
        public void theta_180_phi_270_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 180;
            quantumBit.phiAngle = 270;
            Assert.AreEqual("0", quantumBit.printDensityMatrix(0,0));
            Assert.AreEqual("0", quantumBit.printDensityMatrix(0,1));
            Assert.AreEqual("0", quantumBit.printDensityMatrix(1,0));
            Assert.AreEqual("1", quantumBit.printDensityMatrix(1,1));
        }

        [Test]
        public void theta_180_phi_359_Tests(){
            quantumBit = new Qubit(180,359);
            Assert.AreEqual("0", quantumBit.printDensityMatrix(0,0));
            Assert.AreEqual("0", quantumBit.printDensityMatrix(0,1));
            Assert.AreEqual("0", quantumBit.printDensityMatrix(1,0));
            Assert.AreEqual("1", quantumBit.printDensityMatrix(1,1));
        }

        [Test]
        public void theta_180_phi_360_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 180;
            quantumBit.phiAngle = 360;
            Assert.AreEqual("0", quantumBit.printDensityMatrix(0,0));
            Assert.AreEqual("0", quantumBit.printDensityMatrix(0,1));
            Assert.AreEqual("0", quantumBit.printDensityMatrix(1,0));
            Assert.AreEqual("1", quantumBit.printDensityMatrix(1,1));
        }
        #endregion
    }
}
