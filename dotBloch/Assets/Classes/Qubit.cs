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
        if(anglesAreValid(thetaAngle,phiAngle)){
            this._thetaAngle = thetaAngle;
            this._phiAngle = phiAngle;

            this.updateZero();
            this.updateOne();
        
            printSettings = new PrintBlochSettings(true,false,3,PrintBlochSettings.DecimalSeparator.comma,PrintBlochSettings.ImaginaryUnit.i);
        }
        else
        {
            throw new ArgumentException("Value of theta or phi angle is wrong");
            Debug.Log("Value of theta or phi angle is wrong");
        }
    }

    private bool anglesAreValid(double theta, double phi){
        if(thetaIsValid(this.thetaAngle) && phiIsValid(this.phiAngle))
            return true;
        else 
            return false;
    }

    private bool phiIsValid(double angle){
        if(angle >=0 && angle<=360)
            return true;
        else
            return false;
    }

    private bool thetaIsValid(double angle){
        if(angle >=0 && angle<=180)
            return true;
        else
            return false;
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
            if(phiIsValid(value)){
                _phiAngle = value;
                this.updateOne();
            }
            else{
                Debug.Log("Value of theta or phi angle is wrong");
            }
            /*Debug.Log("Theta setter:" + this.thetaAngle + "\n");
            Debug.Log("Phi setter:" + value + "\n");

            Debug.Log("cos(ϕ) " + Math.Cos(DegreeToRadian(value)) + "\n");
            Debug.Log("sin(ϕ) " + Math.Sin(DegreeToRadian(value)) + "\n");
            Debug.Log("3) sin(ϕ) " + Math.Round(Math.Sin(DegreeToRadian(value))) + "\n");

            Debug.Log("180 stopni: " + DegreeToRadian(180) + "\n");


            Debug.Log("sin(Θ/2) " + Math.Sin(DegreeToRadian(this.thetaAngle)/2) + "\n");*/
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
            Debug.Log("theta value przed: " + value);
            if(thetaIsValid(value)){
                Debug.Log("theta value po: " + value);
                _thetaAngle = value;
                this.updateZero();
                this.updateOne();
            }
            
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

        result += "|" + "\u03A8".ToString() + "> = " + this.printZeroValue(conditions) + " |0> " + this.printOneValue(conditions) + " |1>";

        if(conditions.printSpaces==false){
            result = result.Replace(" ", string.Empty);
        }
        
        return result;
    }

    public string printZeroValue(PrintBlochSettings printingSettings = null) 
    {
        return print(zeroValue,printingSettings);
        // string result = "";
        // PrintBlochSettings conditions;

        // if(printingSettings==null)
        //     conditions = this.printSettings;
        // else
        //     conditions = printingSettings;
        
        // string decimalCondition = "";

        // if(conditions.endingZeros == true)
        //     decimalCondition = "N"+conditions.decimalSpaces.ToString();

        // result = (Math.Round(zeroValue.Real,conditions.decimalSpaces)).ToString(decimalCondition);

        // if(conditions.decimalSeparator == DecimalSeparator.comma)
        //     result = result.Replace(".",",");


        // return result;
    }

    private PrintBlochSettings set_printing_rules(ref PrintBlochSettings printingSettings){
        if(printingSettings==null) // metoda
            return this.printSettings; // metoda set_default_printing_condition();
        else
            return printingSettings; // metoda??? put_given_printing_condition();
    }

    private string print(Complex number,PrintBlochSettings printingSettings = null){
        string result = "";
        PrintBlochSettings printing_rules = set_printing_rules(ref printingSettings);

        double real_number = Math.Round(number.Real,printing_rules.decimalSpaces);
        double imaginary_number = Math.Round(number.Imaginary,printing_rules.decimalSpaces);

        if(number_not_zero(real_number)){
            if(number_not_zero(imaginary_number)){
                result += print_number(real_number,printing_rules) + print_decimal_character(imaginary_number,printing_rules) + print_number(imaginary_number,printing_rules);
                // print real and imaginary
                result += add_imaginary_unit(printing_rules.imaginaryUnit);
            }
            else{
                //imaginary zero
                result += print_number(real_number,printing_rules);
            }
        }
        else{
            if(imaginary_number==0){
                // print only real, 0
                result += print_number(real_number,printing_rules);

            }
            else{
                //print only imaginary
                result += print_number(imaginary_number,printing_rules);
                result += add_imaginary_unit(printing_rules.imaginaryUnit);
            }
        }

        result = remove_spaces_if_needed(result,printing_rules.printSpaces);
        result = set_decimal_separator(result,printing_rules.decimalSeparator);

        return result;
    }

    private string add_imaginary_unit(ImaginaryUnit imaginaryUnit){
        return imaginaryUnit.ToString();
    }

    private string set_decimal_separator(string argument, DecimalSeparator separator){

        if(separator == DecimalSeparator.comma)
            argument = argument.Replace(".",",");
            
        return argument;
    }

    private string remove_spaces_if_needed(string argument, bool keep_spaces){
        if(keep_spaces==false)
            argument = remove_spaces(argument);

        return argument;
    }

    private string remove_spaces(string argument){
        return argument.Replace(" ", string.Empty);
    }

    private bool number_is_zero(double number){
        return number == 0 ? true : false;
    }
    private bool number_not_zero(double number){
        if(number > 0 || number < 0)
            return true;
        else
            return false;
    }

    private string print_number(double number,PrintBlochSettings printingSettings = null){
        string result = string.Empty;
        PrintBlochSettings printing_rules = set_printing_rules(ref printingSettings);
        string decimalSpaces = this.set_number_rounding(printing_rules);

        double rounded_number = Math.Round(number,printing_rules.decimalSpaces);

        if(rounded_number<0)
            result += "- ";
        
        result += Math.Abs(rounded_number).ToString(decimalSpaces);

        return result;
    }

    // private string printImaginary(Complex number,PrintBlochSettings printingSettings = null){
    //     PrintBlochSettings conditions = setConditions(ref printingSettings);
    //     string decimalSpaces = this.setRounding(conditions);

    //     double imaginary_number = Math.Round(number.Real,conditions.decimalSpaces);

    //     return imaginary_number.ToString(decimalSpaces);
    // }

    private string set_number_rounding(PrintBlochSettings settings){
        if(settings.endingZeros == true)
            return "N"+settings.decimalSpaces.ToString();
        else
            return String.Empty;
    }

    private string print_decimal_character(double number,PrintBlochSettings printingSettings = null){
        string result = " ";
        if(number >= 0)
            result += "+ ";

        return result;
    }
    public string printOneValue(PrintBlochSettings printingSettings = null) {
        return print(oneValue,printingSettings);


        // Debug.Log("Imaginary: " + oneValue.Imaginary + "\n");
        // Debug.Log("Real: "+oneValue.Real + "\n");

    //     PrintBlochSettings conditions;

    //     if(printingSettings==null)
    //         conditions = this.printSettings;
    //     else
    //         conditions = printingSettings;

    //     string decimalCondition = "";
    //     if(conditions.endingZeros == true){
    //         decimalCondition = "N"+conditions.decimalSpaces.ToString();
    //     }
            
    //    double real_number = Math.Round(oneValue.Real,conditions.decimalSpaces);
    //    double imaginary_number = Math.Round(oneValue.Imaginary,conditions.decimalSpaces);

    //     // Debug.Log("Theta: " + this.thetaAngle + "\n");
    //     // Debug.Log("Phi: " + this.phiAngle + "\n");
        
    //     // Debug.Log("Real rounded: " + real_number+"\n");
    //     // Debug.Log("Imaginary numer: " + imaginary_number+"\n");

    //     if(real_number==0){
    //         if(imaginary_number==0){
    //             // print only Real

    //             if(leadingPlus){
    //                 result += "+ ";
    //             }

    //             result += real_number.ToString(decimalCondition);  
    //         }
    //         else
    //         {
    //             // print only imaginary
    //             if(leadingPlus && imaginary_number >= 0)
    //                 result += "+ ";

    //             if(imaginary_number<0)
    //                  result += "- ";   
                
    //             if(Math.Abs(imaginary_number)!=1)
    //                 result += Math.Abs(imaginary_number).ToString(decimalCondition);

    //             result += conditions.imaginaryUnit.ToString();
    //         }
    //     }
    //     else{
    //         if(imaginary_number==0){
    //             // only Real
    //             if(leadingPlus && real_number >= 0){
    //                 result += "+ ";
    //             }
                
    //             if(real_number<0) 
    //                 result += "- ";

    //             result += Math.Abs(real_number).ToString(decimalCondition);
    //         }
    //         else
    //         {
    //             // real AND imaginary
    //             if(leadingPlus && real_number>=0){
    //                 result += "+ ";
    //             }
                
    //             if(real_number<0)
    //             {
    //                 result += "- ";
    //             }
    //             result += Math.Abs(real_number).ToString(decimalCondition);
                
    //             result += " ";

    //             if(imaginary_number > 0){
    //                 result += "+ ";
    //             }
    //             else if(imaginary_number < 0 ){
    //                 result += "- ";
    //             }

    //             result += Math.Abs(imaginary_number).ToString(decimalCondition);

    //             result += conditions.imaginaryUnit.ToString();
    //         }
    //     }

    //     if(conditions.decimalSeparator == DecimalSeparator.comma)
    //         result = result.Replace(".",",");

    //     if(conditions.printSpaces==false){
    //         result = result.Replace(" ", string.Empty);
    //     }

    //    return result;
    }
}
