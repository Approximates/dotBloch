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

    public void copyDensityMatrix00()
    {
        result = GameObject.Find("Value[0][0]").GetComponent<Text>().text;
        StaticMethods.copyToClipboard(result);
        Debug.Log("copied: " + result);
    }

    public void copyDensityMatrix01()
    {
        result = GameObject.Find("Value[0][1]").GetComponent<Text>().text;
        StaticMethods.copyToClipboard(result);
        Debug.Log("copied: " + result);
    }

    public void copyDensityMatrix10()
    {
        result = GameObject.Find("Value[1][0]").GetComponent<Text>().text;
        StaticMethods.copyToClipboard(result);
        Debug.Log("copied: " + result);
    }

    public void copyDensityMatrix11()
    {
        result = GameObject.Find("Value[1][1]").GetComponent<Text>().text;
        StaticMethods.copyToClipboard(result);
        Debug.Log("copied: " + result);
    }
}
