using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bit
{
    private bool _value;

    public Bit(bool state){
        this._value = state;
    }

    public void NotGate(){
        this._value = !this._value;
    }

    public void setOne(){
        this._value = true;
    }

    public void setZero(){
        this._value = false;
    }
}
