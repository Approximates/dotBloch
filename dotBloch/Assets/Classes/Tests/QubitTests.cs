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
        public void HelloWorldTest()
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
            Assert.AreEqual(quantumBit.printBlochVector(3),"|Ψ> = 1 |0> + 0 |1>");

            quantumBit.phiAngle = 45;
            Assert.AreEqual(quantumBit.printBlochVector(3),"|Ψ> = 1 |0> + 0 |1>");

            quantumBit.phiAngle = 90;
            Assert.AreEqual(quantumBit.printBlochVector(3),"|Ψ> = 1 |0> + 0 |1>");

            quantumBit.phiAngle = 180;
            Assert.AreEqual(quantumBit.printBlochVector(3),"|Ψ> = 1 |0> + 0 |1>");

            quantumBit.phiAngle = 270;
            Assert.AreEqual(quantumBit.printBlochVector(3),"|Ψ> = 1 |0> + 0 |1>");
        }

        public void printBlochVector_theta30_Tests()
        {
            quantumBit.thetaAngle = 30;

            quantumBit.phiAngle = 0;
            Assert.AreEqual("|Ψ> = 0,966 |0> + 0,259 |1>", quantumBit.printBlochVector(3));

            quantumBit.phiAngle = 45;
            Assert.AreEqual("|Ψ> = 0,966 |0> + 0,183+0,183i |1>", quantumBit.printBlochVector(3));

            quantumBit.phiAngle = 90;
            Assert.AreEqual("|Ψ> = 0,966 |0> + 0,259i |1>", quantumBit.printBlochVector(3));

            quantumBit.phiAngle = 180;
            Assert.AreEqual("|Ψ> = 0,966 |0> - 0,259 |1>", quantumBit.printBlochVector(3));

            quantumBit.phiAngle = 270;
            Assert.AreEqual("|Ψ> = 0,966 |0> - 0,259i |1>", quantumBit.printBlochVector(3));
        }

        public void printBlochVector_theta45_Tests()
        {
            quantumBit.thetaAngle = 45;

            quantumBit.phiAngle = 0;
            Assert.AreEqual("Ψ> = 0,924|0> + 0,383 |1>", quantumBit.printBlochVector(3));

            quantumBit.phiAngle = 45;
            Assert.AreEqual("Ψ> = 0,924|0> + 0,271+0,271i |1>", quantumBit.printBlochVector(3));

            quantumBit.phiAngle = 90;
            Assert.AreEqual("|Ψ> = 0,924|0> + 0,383i |1>", quantumBit.printBlochVector(3));

            quantumBit.phiAngle = 180;
            Assert.AreEqual("|Ψ> = 0,924|0> - 0,383 |1>", quantumBit.printBlochVector(3));

            quantumBit.phiAngle = 270;
            Assert.AreEqual("|Ψ> = 0,924|0> - 0,383i |1>", quantumBit.printBlochVector(3));
        }

        public void printBlochVector_theta60_Tests()
        {
            quantumBit.thetaAngle = 60;

            quantumBit.phiAngle = 0;
            Assert.AreEqual("Ψ> = 0,866 |0> + 0,5 |1>", quantumBit.printBlochVector(3));

            quantumBit.phiAngle = 45;
            Assert.AreEqual("Ψ> = 0,866 |0> + 0,354+0,354i |1>", quantumBit.printBlochVector(3));

            quantumBit.phiAngle = 90;
            Assert.AreEqual("Ψ> = 0,866 |0> + 0,5i |1>", quantumBit.printBlochVector(3));

            quantumBit.phiAngle = 180;
            Assert.AreEqual("Ψ> = 0,866 |0> - 0,5 |1>", quantumBit.printBlochVector(3));

            quantumBit.phiAngle = 270;
            Assert.AreEqual("Ψ> = 0,866 |0> - 0,5i |1>", quantumBit.printBlochVector(3));
        }

        public void printBlochVector_theta90_Tests()
        {
            quantumBit.thetaAngle = 90;

            quantumBit.phiAngle = 0;
            Assert.AreEqual("Ψ> = 0,707 |0> + 0,707 |1>", quantumBit.printBlochVector(3));

            quantumBit.phiAngle = 45;
            Assert.AreEqual("Ψ> = 0,707 |0> + 0,5+0,5i |1>", quantumBit.printBlochVector(3));

            quantumBit.phiAngle = 90;
            Assert.AreEqual("Ψ> = 0,707|0> + 0,707i |1>", quantumBit.printBlochVector(3));

            quantumBit.phiAngle = 180;
            Assert.AreEqual("Ψ> = 0,707 |0> - 0,707 |1>", quantumBit.printBlochVector(3));

            quantumBit.phiAngle = 270;
            Assert.AreEqual("Ψ> = 0,707 |0> + 0,707i |1>", quantumBit.printBlochVector(3));
        }

        public void printBlochVector_theta120_Tests(){
            quantumBit.thetaAngle = 120;

            quantumBit.phiAngle = 0;
            Assert.AreEqual("Ψ> = 0,5 |0> + 0,866 |1>", quantumBit.printBlochVector(3));

            quantumBit.phiAngle = 45;
            Assert.AreEqual("Ψ> = 0,5 |0> + 0,612+0,612i |1>", quantumBit.printBlochVector(3));

            quantumBit.phiAngle = 90;
            Assert.AreEqual("Ψ> = 0,5 |0> + 0,866i |1>", quantumBit.printBlochVector(3));

            quantumBit.phiAngle = 180;
            Assert.AreEqual("Ψ> = 0,5 |0> - 0,866 |1>", quantumBit.printBlochVector(3));

            quantumBit.phiAngle = 270;
            Assert.AreEqual("Ψ> = 0,5|0> + 0,866 |1>", quantumBit.printBlochVector(3));
        }

        public void printBlochVector_theta180_Tests()
        {
            quantumBit.thetaAngle = 180;

            quantumBit.phiAngle = 0;
            Assert.AreEqual("|Ψ> = 0|0> + 1 |1>", quantumBit.printBlochVector(3));

            quantumBit.phiAngle = 45;
            Assert.AreEqual("Ψ> = 0|0> + 0,707+0,707i |1>", quantumBit.printBlochVector(3));

            quantumBit.phiAngle = 90;
            Assert.AreEqual("|Ψ> = 0|0> + i |1>", quantumBit.printBlochVector(3));

            quantumBit.phiAngle = 180;
            Assert.AreEqual("|Ψ> = 0|0> - 1 |1>", quantumBit.printBlochVector(3));

            quantumBit.phiAngle = 270;
            Assert.AreEqual("|Ψ> = 0|0> - i |1>", quantumBit.printBlochVector(3));
        }
        public void printBlochVectorInvalidArgument()
        {
            /*
                -10	15	#VALUE!
                86	-23	#VALUE!
                183	270	#VALUE!
                20	380	#VALUE!
             */
        }
        public void printBlochVector_decimalCharacters_Tests()
        {
            /*
                180	0	|Ψ> =   0|0> + 1 |1>
                180	45	|Ψ> =   0|0> + 0,707+0,707i |1>
                180	90	|Ψ> =   0|0> + i |1>
                180	180	|Ψ> =   0|0> - 1 |1>
                180	270	|Ψ> =   0|0> - i |1>
             */
        }

        

        public void printBlochVector_decimalPlaces_Tests()
        {
            /*
                Sprawdzić miejsca po przecinkach!
             */
        }

        public void printBlochVectorImaginaryUnit()
        {
            /* Liczby zespolone */
        }

        public void printBlochVector_nullpointer_Tests()
        {
            /*
                nulle jako argumenty
             */
        }

        private void printBlochVector_handlingInvalidData_Tests()
        {

        }
    }
}
