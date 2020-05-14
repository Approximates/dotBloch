using NUnit.Framework;
using UnityEngine;
namespace Tests
{
    public class FPSCounterTests
    {
        FPSCounter fps;
        FPSCounter fpsExpected;
        // A Test behaves as an ordinary method
        [Test]
        public void nUnit_Test()
        {
            Assert.AreEqual(true, true);
            Assert.AreEqual(null, null);
        }
        [Test]
        public void equalTo23FPS_Test()
        {
            fps = new FPSCounter();
            fpsExpected = new FPSCounter();

            fps.countValuesToDisplay(0.0435f);

            fpsExpected.framesPerSecond.displayValue = "23 FPS";
            fpsExpected.framesPerSecond.displayColor = new Color32(204,51,0,255);
            fpsExpected.oneFrameExecuteTime.displayValue = "44 ms";

            Assert.AreEqual(fpsExpected.framesPerSecond.displayValue,fps.framesPerSecond.displayValue);
            Assert.AreEqual(fpsExpected.framesPerSecond.displayColor,fps.framesPerSecond.displayColor);
            Assert.AreEqual(fpsExpected.oneFrameExecuteTime.displayValue,fps.oneFrameExecuteTime.displayValue);
        }
        [Test]
        public void equalTo24FPS_Test()
        {
            fpsExpected = new FPSCounter();

            fps.countValuesToDisplay(0.0416f);

            fpsExpected.framesPerSecond.displayValue = "24 FPS";
            fpsExpected.framesPerSecond.displayColor = new Color32(255,102,0,255);
            fpsExpected.oneFrameExecuteTime.displayValue = "42 ms";

            Assert.AreEqual(fpsExpected.framesPerSecond.displayValue,fps.framesPerSecond.displayValue);
            Assert.AreEqual(fpsExpected.framesPerSecond.displayColor,fps.framesPerSecond.displayColor);
            Assert.AreEqual(fpsExpected.oneFrameExecuteTime.displayValue,fps.oneFrameExecuteTime.displayValue);     
       }

       [Test]
       public void equalTo30FPS_Test()
       {
            fpsExpected = new FPSCounter();

            fps.countValuesToDisplay(0.0333f);

            fpsExpected.framesPerSecond.displayValue = "30 FPS";
            fpsExpected.framesPerSecond.displayColor = new Color32(255,102,0,255);
            fpsExpected.oneFrameExecuteTime.displayValue = "33 ms";

            Assert.AreEqual(fpsExpected.framesPerSecond.displayValue,fps.framesPerSecond.displayValue);
            Assert.AreEqual(fpsExpected.framesPerSecond.displayColor,fps.framesPerSecond.displayColor);
            Assert.AreEqual(fpsExpected.oneFrameExecuteTime.displayValue,fps.oneFrameExecuteTime.displayValue);
       }

        [Test]
        public void equalTo31FPS_Test()
       {
            fpsExpected = new FPSCounter();

            fps.countValuesToDisplay(0.0326f);

            fpsExpected.framesPerSecond.displayValue = "31 FPS";
            fpsExpected.framesPerSecond.displayColor = new Color32(255,255,0,255);
            fpsExpected.oneFrameExecuteTime.displayValue = "33 ms";

            Assert.AreEqual(fpsExpected.framesPerSecond.displayValue,fps.framesPerSecond.displayValue);
            Assert.AreEqual(fpsExpected.framesPerSecond.displayColor,fps.framesPerSecond.displayColor);
            Assert.AreEqual(fpsExpected.oneFrameExecuteTime.displayValue,fps.oneFrameExecuteTime.displayValue);
       }  

        [Test]
        public void equalTo48FPS_Test()
       {
            fpsExpected = new FPSCounter();

            fps.countValuesToDisplay(0.0208f);

            fpsExpected.framesPerSecond.displayValue = "48 FPS";
            fpsExpected.framesPerSecond.displayColor = new Color32(255,255,0,255);
            fpsExpected.oneFrameExecuteTime.displayValue = "21 ms";

            Assert.AreEqual(fpsExpected.framesPerSecond.displayValue,fps.framesPerSecond.displayValue);
            Assert.AreEqual(fpsExpected.framesPerSecond.displayColor,fps.framesPerSecond.displayColor);
            Assert.AreEqual(fpsExpected.oneFrameExecuteTime.displayValue,fps.oneFrameExecuteTime.displayValue);
       }  

        [Test]
        public void equalTo49FPS_Test()
       {
            fpsExpected = new FPSCounter();

            fps.countValuesToDisplay(0.0204f);

            fpsExpected.framesPerSecond.displayValue = "49 FPS";
            fpsExpected.framesPerSecond.displayColor = new Color32(0,153,0,255);
            fpsExpected.oneFrameExecuteTime.displayValue = "20 ms";

            Assert.AreEqual(fpsExpected.framesPerSecond.displayValue,fps.framesPerSecond.displayValue);
            Assert.AreEqual(fpsExpected.framesPerSecond.displayColor,fps.framesPerSecond.displayColor);
            Assert.AreEqual(fpsExpected.oneFrameExecuteTime.displayValue,fps.oneFrameExecuteTime.displayValue);
       }  

         [Test]
        public void equalTo60FPS_Test()
       {
            fpsExpected = new FPSCounter();

            fps.countValuesToDisplay(0.0166f);

            fpsExpected.framesPerSecond.displayValue = "60 FPS";
            fpsExpected.framesPerSecond.displayColor = new Color32(0,153,0,255);
            fpsExpected.oneFrameExecuteTime.displayValue = "17 ms";

            Assert.AreEqual(fpsExpected.framesPerSecond.displayValue,fps.framesPerSecond.displayValue);
            Assert.AreEqual(fpsExpected.framesPerSecond.displayColor,fps.framesPerSecond.displayColor);
            Assert.AreEqual(fpsExpected.oneFrameExecuteTime.displayValue,fps.oneFrameExecuteTime.displayValue);
       } 

         [Test]
        public void equalTo61FPS_Test()
       {
            fpsExpected = new FPSCounter();

            fps.countValuesToDisplay(0.0164f);

            fpsExpected.framesPerSecond.displayValue = "61 FPS";
            fpsExpected.framesPerSecond.displayColor = new Color32(0,204,0,255);
            fpsExpected.oneFrameExecuteTime.displayValue = "16 ms";

            Assert.AreEqual(fpsExpected.framesPerSecond.displayValue,fps.framesPerSecond.displayValue);
            Assert.AreEqual(fpsExpected.framesPerSecond.displayColor,fps.framesPerSecond.displayColor);
            Assert.AreEqual(fpsExpected.oneFrameExecuteTime.displayValue,fps.oneFrameExecuteTime.displayValue);
       } 
    }
}
