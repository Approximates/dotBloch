using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Numerics;

public class Qubit 
{
    public float phiAngle;
    public Complex zero;
    public Complex one;
    public Complex add;
    public Complex mul;

    public Qubit(float phiAngle)
    {
        this.phiAngle = phiAngle;
        zero = new Complex(3.1, 2.5);
        one = new Complex(2.2, 3.3);
        add = new Complex();
        mul = new Complex();
        add = Complex.Add(one, zero);
        mul = Complex.Multiply(one, zero);

    }
}
