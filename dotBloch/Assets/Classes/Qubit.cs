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

        this.updateZero();
        this.updateOne();
        
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

            /*Debug.Log("Theta setter:" + this.thetaAngle + "\n");
            Debug.Log("Phi setter:" + value + "\n");

            Debug.Log("cos(ϕ) " + Math.Cos(DegreeToRadian(value)) + "\n");
            Debug.Log("sin(ϕ) " + Math.Sin(DegreeToRadian(value)) + "\n");
            Debug.Log("3) sin(ϕ) " + Math.Round(Math.Sin(DegreeToRadian(value))) + "\n");

            Debug.Log("180 stopni: " + DegreeToRadian(180) + "\n");


            Debug.Log("sin(Θ/2) " + Math.Sin(DegreeToRadian(this.thetaAngle)/2) + "\n");*/

            this.updateOne();
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
            this.updateZero();
            this.updateOne();
        }
    }

    private void updateZero(){
        this.zeroValue = new Complex(Math.Cos(DegreeToRadian(this.thetaAngle)/2),0);
    }

    private void updateOne(){
        double cos_phi_ = Math.Cos(DegreeToRadian(this.phiAngle));
        // Debug.Log("cos_phi_: " + cos_phi_ + "\n");
        double sin_theta_div_2_ = Math.Sin(DegreeToRadian(this.thetaAngle)/2);
        // Debug.Log("sin_theta_div_2_: " + sin_theta_div_2_ + "\n");
        double sin_phi = Math.Sin(DegreeToRadian(this.phiAngle));
        // Debug.Log("sin_phi" + sin_phi + "\n");
        
        
        
        this.oneValue = new Complex(cos_phi_*sin_theta_div_2_,sin_phi*sin_theta_div_2_);
        // Debug.Log("Real calculation: " + cos_phi_*sin_theta_div_2_ + "\n");
        // Debug.Log("Imaginary calculation: " + sin_phi*sin_theta_div_2_ + "\n");
        // Debug.Log("Konstruktor |1>: " + this.oneValue + "\n");
    }

    private double DegreeToRadian(double angle, int? decimalSpaces = null)
    {
        return Math.PI * angle / 180.0;
    }
#endregion
    public string printBlochVector(PrintBlochSettings printingSettings = null) 
    {
        string result = "";
        PrintBlochSettings conditions;

        Debug.Log("|0>: " + this.zeroValue + "\n");
        Debug.Log("|1>: " + this.oneValue + "\n");

        if(printingSettings==null)
            conditions = this.printSettings;
        else
            conditions = printingSettings;

        result += "|" + "\u03A8".ToString() + "> = " + this.printZeroValue(conditions) + " |0> " + this.printOneValue(true, conditions) + " |1>";

        if(conditions.printSpaces==false){
            result = result.Replace(" ", string.Empty);
        }
        
        return result;
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
    public string printOneValue(bool leadingPlus,PrintBlochSettings printingSettings = null) {
        string result = "";

        // Debug.Log("Imaginary: " + oneValue.Imaginary + "\n");
        // Debug.Log("Real: "+oneValue.Real + "\n");

        PrintBlochSettings conditions;

        if(printingSettings==null)
            conditions = this.printSettings;
        else
            conditions = printingSettings;

        string decimalCondition = "";
        if(conditions.endingZeros == true){
            decimalCondition = "N"+conditions.decimalSpaces.ToString();
        }
            
       double real_number = Math.Round(oneValue.Real,conditions.decimalSpaces);
       double imaginary_number = Math.Round(oneValue.Imaginary,conditions.decimalSpaces);

        // Debug.Log("Theta: " + this.thetaAngle + "\n");
        // Debug.Log("Phi: " + this.phiAngle + "\n");
        
        // Debug.Log("Real rounded: " + real_number+"\n");
        // Debug.Log("Imaginary numer: " + imaginary_number+"\n");

        if(real_number==0){
            if(imaginary_number==0){
                // print only Real

                if(leadingPlus){
                    result += "+ ";
                }

                result += real_number.ToString(decimalCondition);  
            }
            else
            {
                // print only imaginary
                if(leadingPlus && imaginary_number >= 0)
                    result += "+ ";

                if(imaginary_number<0)
                     result += "- ";   
                
                if(Math.Abs(imaginary_number)!=1)
                    result += Math.Abs(imaginary_number).ToString(decimalCondition);

                result += conditions.imaginaryUnit.ToString();
            }
        }
        else{
            if(imaginary_number==0){
                // only Real
                if(leadingPlus && real_number >= 0){
                    result += "+ ";
                }
                
                if(real_number<0) 
                    result += "- ";

                result += Math.Abs(real_number).ToString(decimalCondition);
            }
            else
            {
                // real AND imaginary
                if(leadingPlus){
                    result += "+ ";
                }
                
                result += real_number.ToString(decimalCondition);
                
                result += " ";

                if(imaginary_number > 0){
                    result += "+ ";
                }
                else if(imaginary_number < 0 ){
                    result += "- ";
                }

                result += Math.Abs(imaginary_number).ToString(decimalCondition);

                result += conditions.imaginaryUnit.ToString();
            }
        }

        if(conditions.decimalSeparator == DecimalSeparator.comma)
            result = result.Replace(".",",");

        if(conditions.printSpaces==false){
            result = result.Replace(" ", string.Empty);
        }

        return result;
    }
}
