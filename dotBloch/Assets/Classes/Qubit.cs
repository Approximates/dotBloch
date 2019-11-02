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
        
        printSettings = new PrintBlochSettings(true,false,3,PrintBlochSettings.DecimalSeparator.comma,PrintBlochSettings.ImaginaryUnit.i);
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

    public string printZeroValue(PrintBlochSettings printingSettings = null) 
    {
        string result = "";
        PrintBlochSettings conditions;

        if(printingSettings==null)
            conditions = this.printSettings;
        else
            conditions = printingSettings;
        
        string decimalCondition = "";

        if(conditions.endingZeros == true)
            decimalCondition = "N"+conditions.decimalSpaces.ToString();

        result = (Math.Round(zeroValue.Real,conditions.decimalSpaces)).ToString(decimalCondition);

        if(conditions.decimalSeparator == DecimalSeparator.comma)
            result = result.Replace(".",",");


        return result;
    }
    public string printOneValue(bool leadingPlus,PrintBlochSettings printSettings = null) => throw new NotImplementedException();
}
