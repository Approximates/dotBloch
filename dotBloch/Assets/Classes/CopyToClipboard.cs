using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using RDG;

public class CopyToClipboard : MonoBehaviour
{
    public GameObject text;
    public void CopyTextToClipboard()
    {
        
        string txt = text.GetComponentInChildren<Text>().text;

        TextEditor editor = new TextEditor
        {
            text = txt
        };
        editor.SelectAll();
        editor.Copy();
        RDG.Vibration.Vibrate(50);
    }
}
