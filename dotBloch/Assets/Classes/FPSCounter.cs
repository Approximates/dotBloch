using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEditor;
public class FPSCounter 
{
    public FPSLabel framesPerSecond;
    public FPSLabel oneFrameExecuteTime;
    private float oneSecond;
    public FPSCounter()
    {
        framesPerSecond = new FPSLabel();
        oneFrameExecuteTime = new FPSLabel();
        this.oneSecond = 1;
    }

    public void countValuesToDisplay(float deltaTime)
    {
        float fps = 1; 
        framesPerSecond.displayValue = Math.Round((fps/deltaTime),0).ToString() + " FPS";
        framesPerSecond.displayColor = new Color32(255,0,0,255); 
        oneFrameExecuteTime.displayValue = Math.Round((deltaTime*1000),0).ToString() + "ms";
        oneFrameExecuteTime.displayColor = new Color32(255,255,0,255); 
    }

   public bool oneSecondLeft(float deltaTime)
   {
       this.oneSecond -= deltaTime;

       if(this.oneSecond <=0)
        { 
            this.oneSecond = 1;
            return true;
        }else return false;
   }
}
