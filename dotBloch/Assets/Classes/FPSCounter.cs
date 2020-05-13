using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEditor;
public class FPSCounter 
{
    public FPSLabel framesPerSecond;
    public FPSLabel oneFrameExecuteTime;

    public FPSCounter()
    {
        framesPerSecond = new FPSLabel();
        oneFrameExecuteTime = new FPSLabel();
    }

    public void countValuesToDisplay(float frameExecution)
    {
        float fps = 1; 
        framesPerSecond.displayValue = Math.Round((fps/frameExecution),0).ToString();
        framesPerSecond.displayColor = new Color32(255,0,0,255); 
        oneFrameExecuteTime.displayValue = Math.Round((frameExecution*1000),0).ToString() + "ms";
        oneFrameExecuteTime.displayColor = new Color32(255,255,0,255); 

    }
}
