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
        framesPerSecond.displayValue = (fps/frameExecution).ToString();
        oneFrameExecuteTime.displayValue = frameExecution.ToString() + "ms";
    }
}
