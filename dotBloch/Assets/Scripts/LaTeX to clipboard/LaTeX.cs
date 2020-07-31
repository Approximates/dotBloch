using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LaTeX : MonoBehaviour
{
    private string result;

    private void showCopiedPrompt(){
        GameObject.Find("copiedToClipboard").SendMessage("displayCopiedLabel");
    }

    
    public void copyTheBlochVector()
    {
        result = GameObject.Find("blochVector").GetComponent<Text>().text;
        StaticMethods.copyToClipboard(result);
        StaticMethods.coptyToWebGLLogs(result);
        showCopiedPrompt();
    }

    public void copyZeroProbability()
    {
        result = GameObject.Find("text_zero_probability").GetComponent<Text>().text;
        StaticMethods.copyToClipboard(result);
        StaticMethods.coptyToWebGLLogs(result);
        showCopiedPrompt();
    }

    public void copyOneProbability()
    {
        result = GameObject.Find("text_one_probability").GetComponent<Text>().text;
        StaticMethods.copyToClipboard(result);
        StaticMethods.coptyToWebGLLogs(result);
        showCopiedPrompt();
    }

    public void copyDensityMatrix00()
    {
        result = GameObject.Find("Value[0][0]").GetComponent<Text>().text;
        StaticMethods.copyToClipboard(result);
        StaticMethods.coptyToWebGLLogs(result);
        showCopiedPrompt();
    }

    public void copyDensityMatrix01()
    {
        result = GameObject.Find("Value[0][1]").GetComponent<Text>().text;
        StaticMethods.copyToClipboard(result);
        StaticMethods.coptyToWebGLLogs(result);
        showCopiedPrompt();
    }

    public void copyDensityMatrix10()
    {
        result = GameObject.Find("Value[1][0]").GetComponent<Text>().text;
        StaticMethods.copyToClipboard(result);
        StaticMethods.coptyToWebGLLogs(result);
        showCopiedPrompt();
    }

    public void copyDensityMatrix11()
    {
        result = GameObject.Find("Value[1][1]").GetComponent<Text>().text;
        StaticMethods.copyToClipboard(result);
        StaticMethods.coptyToWebGLLogs(result);
        showCopiedPrompt();
    }

    public void copyZeroAndOneFormula()
    {
        result = string.Empty;
        result = Constants.latex.zeroAndOneFormula_1;
        result += GameObject.Find("quantumOne").GetComponent<Text>().text;
        result += Constants.latex.zeroAndOneFormula_2;
        result += GameObject.Find("quantumZero").GetComponent<Text>().text;
        result += Constants.latex.zeroAndOneFormula_3;
        
        StaticMethods.copyToClipboard(result);
        StaticMethods.coptyToWebGLLogs(result);
        showCopiedPrompt();
    }

    public void copyDensityMatrixFormulas(){
        result = Constants.latex.densityMatrixFormula;
        StaticMethods.copyToClipboard(result);
        StaticMethods.coptyToWebGLLogs(result);
        showCopiedPrompt();
    }

    public void copyDensityMatrixWhole(){
        result = Constants.latex.densityMatrixWhole_0;
        result += Constants.latex.densityMatrixWhole_1;
        result += GameObject.Find("Value[0][0]").GetComponent<Text>().text;
        result += Constants.latex.densityMatrixWhole_2;
        result += GameObject.Find("Value[0][1]").GetComponent<Text>().text;
        result += Constants.latex.densityMatrixWhole_3;
        result += GameObject.Find("Value[1][0]").GetComponent<Text>().text;
        result += Constants.latex.densityMatrixWhole_4;
        result += GameObject.Find("Value[1][1]").GetComponent<Text>().text;
        result += Constants.latex.densityMatrixWhole_5;
        StaticMethods.copyToClipboard(result);
        StaticMethods.coptyToWebGLLogs(result);
        showCopiedPrompt();
    }

    public void copyDensityMatrixValues(){
        result = string.Empty;
        result = Constants.latex.densityMatrixWhole_0;
        result += GameObject.Find("Value[0][0]").GetComponent<Text>().text;
        result += Constants.latex.densityMatrixWhole_2;
        result += GameObject.Find("Value[0][1]").GetComponent<Text>().text;
        result += Constants.latex.densityMatrixWhole_3;
        result += GameObject.Find("Value[1][0]").GetComponent<Text>().text;
        result += Constants.latex.densityMatrixWhole_4;
        result += GameObject.Find("Value[1][1]").GetComponent<Text>().text;
        result += Constants.latex.densityMatrixWhole_5;
        StaticMethods.copyToClipboard(result);
        StaticMethods.coptyToWebGLLogs(result);
        showCopiedPrompt();
    }

    public void copyQuantumZeroValue(){
        result = GameObject.Find("quantumZero").GetComponent<Text>().text;
        StaticMethods.copyToClipboard(result);
        StaticMethods.coptyToWebGLLogs(result);
        showCopiedPrompt();
    }
    public void copyQuantumOneValue(){
        result = GameObject.Find("quantumOne").GetComponent<Text>().text;
        StaticMethods.copyToClipboard(result);
        StaticMethods.coptyToWebGLLogs(result);
        showCopiedPrompt();
    }

    public void copyThetaAngle(){
        result = string.Empty;
        result += Constants.latex.theta;
        result += Constants.math.space_equal;
        result += GameObject.Find("thetaDisplayValue").GetComponent<Text>().text;
        result += Constants.latex.degree;
        StaticMethods.copyToClipboard(result);
        StaticMethods.coptyToWebGLLogs(result);
        showCopiedPrompt();
    }

    public void copyPhiAngle(){
        result = string.Empty;
        result += Constants.latex.phi;
        result += Constants.math.space_equal;
        result += GameObject.Find("phiDisplayValue").GetComponent<Text>().text;
        result += Constants.latex.degree;
        StaticMethods.copyToClipboard(result);
        StaticMethods.coptyToWebGLLogs(result);
        showCopiedPrompt();
    }
}
