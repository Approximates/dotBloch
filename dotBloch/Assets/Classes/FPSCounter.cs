using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEditor;
public class FPSCounter 
{

    public FPSCounter()
    {
        Debug.Log("is working");
    }

   public bool oneSecondLeft(float deltaTime)
   {
       Debug.Log(deltaTime);
       return true;
   }
}
