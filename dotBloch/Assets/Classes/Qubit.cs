using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Numerics;
using System;
using static PrintBlochSettings;

public class Qubit 
{
    private double _phiAngle;
    private double _thetaAngle;
    private Complex zeroValue;
    private Complex oneValue;

    public PrintBlochSettings printSettings;

    public Qubit(double thetaAngle, double phiAngle)
    {
        this._thetaAngle = thetaAngle;
        this._phiAngle = phiAngle;
        
        printSettings = new PrintBlochSettings(true,3,PrintBlochSettings.DecimalSeparator.comma,PrintBlochSettings.ImaginaryUnit.i);
    }

#region geters_and_setters
    public double phiAngle
    {
        get 
        {
            return _phiAngle;
        }
        set
        {
            //add validators
            _phiAngle = value;
        }
    }

    public double thetaAngle
    {
        get
        {
            return _thetaAngle;
        }
        set
        {
            //add validators
            _thetaAngle = value;
            zeroValue = new Complex(Math.Cos(DegreeToRadian(value)/2),0);
        }
    }

    private double DegreeToRadian(double angle)
    {
        return Math.PI * angle / 180.0;
    }
#endregion
    public string printBlochVector(PrintBlochSettings printSettings = null) 
    {
        throw new NotImplementedException();
    }

    public string printZeroValue(DecimalSeparator? decimalSeparator = null, PrintBlochSettings printingSettings = null) 
    { 
        string result = "";

        if(printingSettings==null){  // no custom settings
            result = (Math.Round(zeroValue.Real,this.printSettings.decimalSpaces)).ToString();
        }
        else{
            result = (Math.Round(zeroValue.Real,printingSettings.decimalSpaces)).ToString();
        }

        return result;
    }
    public string printOneValue(bool leadingPlus,PrintBlochSettings printSettings = null) => throw new NotImplementedException();
}
