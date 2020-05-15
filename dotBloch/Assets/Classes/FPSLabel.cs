using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSLabel 
{
  string _displayValue;
  Color32 _displayColor;

  public string displayValue
  {
    get { return _displayValue; }
    set { _displayValue = value; }
  }

  public Color32 displayColor
  {
    get { return _displayColor; }
    set { _displayColor = value; }
  }

}
