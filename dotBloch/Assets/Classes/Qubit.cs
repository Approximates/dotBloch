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
        if(angles_are_valid(thetaAngle,phiAngle)){
            this._thetaAngle = thetaAngle;
            this._phiAngle = phiAngle;

            this.update_quantum_zero_value();
            this.update_quantum_one_value();
        
            printSettings = new PrintBlochSettings(true,false,3,PrintBlochSettings.DecimalSeparator.comma,PrintBlochSettings.ImaginaryUnit.i);
        }
        else
        {
            throw new ArgumentException("Value of theta or phi angle is wrong");
            Debug.Log("Value of theta or phi angle is wrong");
        }
    }

    private bool angles_are_valid(double thetaAngle, double phiAngle){
        if(theta_is_valid(thetaAngle) && phi_angle_is_valid(phiAngle))
            return true;
        else 
            return false;
    }

    private bool phi_angle_is_valid(double angle){
        if(angle >=0 && angle<=360)
            return true;
        else
            return false;
    }

    private bool theta_is_valid(double angle){
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
            if(phi_angle_is_valid(value)){
                _phiAngle = value;
                this.update_quantum_one_value();
            }
            else{
                Debug.Log("Value of theta or phi angle is wrong");
            }
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
            if(theta_is_valid(value)){
                _thetaAngle = value;
                this.update_quantum_zero_value();
                this.update_quantum_one_value();
            }
        }
    }

    private void update_quantum_zero_value(){
        this.zeroValue = new Complex(Math.Cos(degree_to_radian(this.thetaAngle)/2),0);
    }

    private void update_quantum_one_value(){
        double cos_phi_ = Math.Cos(degree_to_radian(this.phiAngle));
        double sin_theta_div_2_ = Math.Sin(degree_to_radian(this.thetaAngle)/2);
        double sin_phi = Math.Sin(degree_to_radian(this.phiAngle));

        this.oneValue = new Complex(cos_phi_*sin_theta_div_2_,sin_phi*sin_theta_div_2_);
    }

    private double degree_to_radian(double angle, int? decimalSpaces = null){
        return Math.PI * angle / 180.0;
    }
#endregion
    public string print_bloch_vector(PrintBlochSettings printingSettings = null) 
    {
        string result = "";
        PrintBlochSettings conditions;

        Debug.Log("|0>: " + this.zeroValue + "\n");
        Debug.Log("|1>: " + this.oneValue + "\n");

        if(printingSettings==null)
            conditions = this.printSettings;
        else
            conditions = printingSettings;

        result += "|" + "\u03A8".ToString() + "> = " + this.print_zero_value(conditions) + " |0> " + this.print_one_value(conditions) + " |1>";

        if(conditions.printSpaces==false){
            result = result.Replace(" ", string.Empty);
        }
        
        return result;
    }

    public string print_zero_value(PrintBlochSettings printingSettings = null) 
    {
        return print(zeroValue,printingSettings);
    }

    public string print_one_value(PrintBlochSettings printingSettings = null) {
        return print(oneValue,printingSettings);
    }

    private PrintBlochSettings set_printing_rules(ref PrintBlochSettings printingSettings){
        if(custom_settings_added(printingSettings)) 
            return this.printSettings; 
        else
            return printingSettings;
    }

    private bool custom_settings_added(PrintBlochSettings settings){
        return settings == null ? true : false;
    }

    private string print(Complex number,PrintBlochSettings printingSettings = null){
        string result = "";
        PrintBlochSettings printing_rules = set_printing_rules(ref printingSettings);

        double real_number = Math.Round(number.Real,printing_rules.decimalSpaces);
        double imaginary_number = Math.Round(number.Imaginary,printing_rules.decimalSpaces);

        if(number_not_zero(real_number)){
            if(number_not_zero(imaginary_number))
                result += print_real_and_imaginary_numers(real_number,imaginary_number,printing_rules);
            else
                result += print_only_real_number(real_number,printing_rules);
        }
        else{
            if(imaginary_number==0)
                result += print_only_real_number(real_number,printing_rules);
            else
                result += print_only_imaginary_number(imaginary_number,printing_rules);
        }

        result = remove_spaces_if_needed(result,printing_rules.printSpaces);
        result = set_decimal_separator(result,printing_rules.decimalSeparator);

        return result;
    }

    private string print_only_real_number(double real_number, PrintBlochSettings printing_rules){
        string result = string.Empty;
        result += print_number(real_number,printing_rules);
        return result;
    }

    private string print_only_imaginary_number(double imaginary_number, PrintBlochSettings printing_rules){
        string result = string.Empty;
        result += print_number(imaginary_number,printing_rules);
        result += add_imaginary_unit(printing_rules.imaginaryUnit);
        return result;
    }

    private string print_real_and_imaginary_numers(double real_number, double imaginary_number, PrintBlochSettings printing_rules){
        string result = string.Empty;
        result += print_number(real_number,printing_rules) + print_decimal_character(imaginary_number,printing_rules) + print_number(imaginary_number,printing_rules);
        result += add_imaginary_unit(printing_rules.imaginaryUnit);
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

    private string remove_spaces_if_needed(string argument, bool keepSpaces){
        if(keepSpaces==false)
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
            result += "- "; //add_minus_to_result
        
        result += Math.Abs(rounded_number).ToString(decimalSpaces);

        return result;
    }

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
}
