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
        double fpsRatio = Math.Round((fps/deltaTime),0);
        if (fpsRatio <=23)
           setLabelAsRed();
        else if (fpsRatio >=24 && fpsRatio <=30)
           setLabelAsOrange();
        else if (fpsRatio >=31 && fpsRatio <=48)
           setLabelAsYellow();
        else if (fpsRatio >=49 && fpsRatio <=60)
           setLabelAsGreen();
        else setLabelAsLightGreen();
        
        framesPerSecond.displayValue = fpsRatio.ToString() + " FPS";
        oneFrameExecuteTime.displayValue = Math.Round((deltaTime*1000),0).ToString() + " ms";
        oneFrameExecuteTime.displayColor = new Color32(255,255,255,255); 
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

   private void setLabelAsRed()
   {
        this.framesPerSecond.displayColor = new Color32(204,51,0,255);
   } 

    private void setLabelAsOrange()
   {
        this.framesPerSecond.displayColor = new Color32(255,102,0,255);
   }

    private void setLabelAsYellow()
   {
        this.framesPerSecond.displayColor = new Color32(255,255,0,255);
   }

    private void setLabelAsGreen()
   {
        this.framesPerSecond.displayColor = new Color32(0,153,0,255);
   }
    private void setLabelAsLightGreen()
   {
        this.framesPerSecond.displayColor = new Color32(0,204,0,255);
   }
}