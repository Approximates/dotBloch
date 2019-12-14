public class PrintBlochSettings 
{
    private bool _printSpaces;

    private bool _trailingZeros;
    private int _decimalSpaces; 

    private DecimalSeparator _decimalSeparator;

    private ImaginaryUnit _imaginaryUnit;
    public enum DecimalSeparator {
        dot, comma
    }

    public enum ImaginaryUnit{
        i, I, j, J
    }

    public PrintBlochSettings(bool printSpaces, bool trailingZeros, int decimalSpaces, 
    DecimalSeparator decimalSeparator, ImaginaryUnit imaginaryUnit){
        
        this._printSpaces = printSpaces;
        this._trailingZeros = trailingZeros;
        this._decimalSpaces = decimalSpaces;
        this._decimalSeparator = decimalSeparator;
        this._imaginaryUnit = imaginaryUnit;
    }
    public bool printSpaces{
        get { return _printSpaces; }
        set { _printSpaces = value; }
    }

    public bool endingZeros{
        get { return _trailingZeros; }
        set { _trailingZeros = value; }
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
