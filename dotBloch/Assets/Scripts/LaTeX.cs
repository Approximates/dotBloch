using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LaTeX : MonoBehaviour
{
    private string result;
    public void copyTheBlochVector()
    {
        result = GameObject.Find("blochVector").GetComponent<Text>().text;
        StaticMethods.copyToClipboard(result);
        Debug.Log("copied: " + result);
    }

    public void copyZeroProbability()
    {
        result = GameObject.Find("text_zero_probability").GetComponent<Text>().text;
        StaticMethods.copyToClipboard(result);
        Debug.Log("copied: " + result);
    }

    public void copyOneProbability()
    {
        result = GameObject.Find("text_one_probability").GetComponent<Text>().text;
        StaticMethods.copyToClipboard(result);
        Debug.Log("copied: " + result);
    }
}
