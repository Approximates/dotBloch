using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LaTeX : MonoBehaviour
{
    public void copyTheBlochVector()
    {
        
        string result = GameObject.Find("blochVector").GetComponent<Text>().text;
        StaticMethods.copyToClipboard(result);
        Debug.Log("copied: " + result);
    }
}
