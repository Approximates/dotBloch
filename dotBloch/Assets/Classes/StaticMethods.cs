using System;
using UnityEngine;
using UnityEngine.UI;
using RDG;

public class StaticMethods
{
    
    public static double degree_to_radian(double angle, int? decimalSpaces = null){
        return Math.PI * angle / 180.0;
    }

    public static void copyToClipboard(string toCopy)
    {
        TextEditor editor = new TextEditor
        {
            text = toCopy
        };
        editor.SelectAll();
        editor.Copy();
        RDG.Vibration.Vibrate(50);
    }

    public static void coptyToWebGLLogs(string toCopy)
    {
        if(Application.platform == RuntimePlatform.WebGLPlayer)
            Debug.Log(toCopy);
    }
}

