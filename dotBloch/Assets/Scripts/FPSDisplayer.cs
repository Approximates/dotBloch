using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class FPSDisplayer : MonoBehaviour
{
    FPSCounter fps;
    [SerializeField]
    public Text framesPerSecond;
    [SerializeField]
    public Text oneFrameExecuteTime;
    void Start()
    {
        fps = new FPSCounter();
        fps.countValuesToDisplay(Time.deltaTime);
        updateLabels();
    }
    void Update()
    {   
        if(fps.oneSecondLeft(Time.deltaTime))
        {
           fps.countValuesToDisplay(Time.deltaTime);
           updateLabels();
        } 
    }
    void updateLabels()
    {
        framesPerSecond.text = fps.framesPerSecond.displayValue;
        framesPerSecond.color = fps.framesPerSecond.displayColor;
        oneFrameExecuteTime.text = fps.oneFrameExecuteTime.displayValue;
        oneFrameExecuteTime.color = fps.oneFrameExecuteTime.displayColor;
    }
}
