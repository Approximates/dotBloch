using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEditor;
public class FPSCounter 
{

    public void countValuesToDisplay(float oneFrameTimeExecution)
    {
        Debug.Log(oneFrameTimeExecution);
    }

   public string printMiliseconds()
   {

       return "0";
   }
   public string printFrames()
   {

       return "1";  
   }
}
