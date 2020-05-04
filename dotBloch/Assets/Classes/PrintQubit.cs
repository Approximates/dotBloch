﻿using System;
using System.Numerics;
using UnityEngine;
using static PrintBlochSettings;

public class PrintQubit
{
    private string print_one_for_bloch_vector(Complex[] quantumValue, PrintBlochSettings conditions){
        string result = string.Empty;

        result += this.quantum_value(quantumValue[1],conditions); 

        if(plus_is_needed_for_(result)) 
            add_plus(ref result);

        result += Constants.symbol.quantum_one;

        return result;
    }    

    private void add_plus(ref string argument){
        string result = Constants.math.plus_with_space + argument;
        argument = result;
    }

    private PrintBlochSettings set_printing_rules(ref PrintBlochSettings custom_settings){
        if(not_added(custom_settings)) 
            return default_settings.printing_blochspere(); 
        else
            return custom_settings;
    }

    public string bloch_vector(Complex[] quantumValue,PrintBlochSettings printingSettings = null) 
    {
        string result = string.Empty;
        PrintBlochSettings conditions;

        if(not_added(printingSettings))
            conditions = default_settings.printing_blochspere();
        else
            conditions = printingSettings;

        result += Constants.symbol.bloch_sphere + this.quantum_value(quantumValue[0],conditions) + Constants.symbol.quantum_zero + this.print_one_for_bloch_vector(quantumValue, conditions);

        if(conditions.printSpaces==false)
            result = result.Replace(Constants.character.space, string.Empty);
        
        return result;
    }

    private bool not_added(PrintBlochSettings settings){
        return settings == null ? true : false;
    }

    public string percent_value(bool is_zero,double value, PrintBlochSettings printingSettings = null)
    {
        string result = String.Empty;
        PrintBlochSettings printing_rules = set_printing_rules(ref printingSettings);

        Debug.Log("Printing rules: " + printing_rules);

        if(is_zero)
            result += Constants.quantum_probability.zero_label;
        else
            result += Constants.quantum_probability.one_label;

        value *= 100;
        value = Math.Round(value,printing_rules.decimalSpaces);
        result += value.ToString();

        result += Constants.character.percent;

        result = remove_spaces_if_needed(result,printing_rules.printSpaces);
        Debug.Log("Decimal separator: " + printing_rules.decimalSeparator);
        result = set_decimal_separator(result,printing_rules.decimalSeparator);
        return result;
    }



    public string quantum_value(Complex number,PrintBlochSettings printingSettings = null){
        string result = String.Empty;
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
        result += print_imaginary_number(imaginary_number,printing_rules);
        return result;
    }

    private string print_real_and_imaginary_numers(double real_number, double imaginary_number, PrintBlochSettings printing_rules){
        string result = string.Empty;
        result += print_number(real_number,printing_rules) + print_decimal_character(imaginary_number,printing_rules) + print_imaginary_number(imaginary_number,printing_rules);
        return result;
    }

    private string add_imaginary_unit(ImaginaryUnit imaginaryUnit){
        return imaginaryUnit.ToString();
    }

    private string set_decimal_separator(string argument, DecimalSeparator separator){
        if(separator == DecimalSeparator.dot){
            if(argument.Contains(Constants.character.comma))
                replace_comma_with_dot(ref argument);
        }
        else {
            if(argument.Contains(Constants.character.dot))
                replace_dot_with_comma(ref argument);
        }
        return argument;
    }

    private void replace_dot_with_comma(ref string argument){
        string result = argument.Replace(Constants.character.dot,Constants.character.comma);
        argument = result;
    }

    private void replace_comma_with_dot(ref string argument){
        string result = argument.Replace(Constants.character.comma,Constants.character.dot);
        argument = result;
    }

    private string remove_spaces_if_needed(string argument, bool keepSpaces){
        if(keepSpaces==false)
            argument = remove_spaces(argument);

        return argument;
    }

    private string remove_spaces(string argument){
        return argument.Replace(Constants.character.space, string.Empty);
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
            add_minus_to_(ref result); 
        
        result += Math.Abs(rounded_number).ToString(decimalSpaces);

        return result;
    }

    private void add_minus_to_(ref string argument){
        string result = Constants.math.minus_with_space + argument;
        argument = result;
    }

    private string print_imaginary_number(double number,PrintBlochSettings printingSettings = null){
        string result = string.Empty;
        PrintBlochSettings printing_rules = set_printing_rules(ref printingSettings);
        string decimalSpaces = this.set_number_rounding(printing_rules);

        double rounded_number = Math.Round(number,printing_rules.decimalSpaces);

        if(rounded_number<0)
            add_minus_to_(ref result); 

        if(!(rounded_number==1 || rounded_number==-1)){
            result += Math.Abs(rounded_number).ToString(decimalSpaces);
        }

        result += add_imaginary_unit(printing_rules.imaginaryUnit);
        return result;
    }

    private string set_number_rounding(PrintBlochSettings settings){
        if(settings.endingZeros == true)
            return Constants.character.rounding_header+settings.decimalSpaces.ToString();
        else
            return String.Empty;
    }

    private string print_decimal_character(double number,PrintBlochSettings printingSettings = null){
        string result = Constants.character.space;
        if(number >= 0)
            result += Constants.math.plus_with_space;

        return result;
    }
    private bool plus_is_needed_for_(string argument){
        if(!argument[0].ToString().Equals(Constants.math.minus))
            return true;
        else
            return false;
    }
}
