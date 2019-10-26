using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintBlochSettings 
{
    private bool _printSpaces;
    private int _decimalSpaces; 

    private DecimalSeparator _decimalSeparator;

    private ImaginaryUnit _imaginaryUnit;
    public enum DecimalSeparator {
        dot, comma
    }

    public enum ImaginaryUnit{
        i, I, j, J
    }

    public PrintBlochSettings(bool printSpaces, int decimalSpaces, 
    DecimalSeparator decimalSeparator, ImaginaryUnit imaginaryUnit){
        
        this._printSpaces = printSpaces;
        this._decimalSpaces = decimalSpaces;
        this._decimalSeparator = decimalSeparator;
        this._imaginaryUnit = imaginaryUnit;
    }
    public bool printSpaces{
        get { return _printSpaces; }
        set { _printSpaces = value; }
    }
    public int decimalSpaces{
        get { return _decimalSpaces; }
        set { _decimalSpaces = value; }
    } 
    public DecimalSeparator decimalSeparator{
        get { return _decimalSeparator; }
        set { _decimalSeparator = value; }
    }
    public ImaginaryUnit imaginaryUnit{
        get { return _imaginaryUnit; }
        set { _imaginaryUnit = value; }
    }
}
