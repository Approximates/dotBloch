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
    // Start is called before the first frame update
    void Start()
    {
        fps = new FPSCounter();
        framesPerSecond.text = "Jacek";
        framesPerSecond.color = new Color32(255,0,0,255);
        oneFrameExecuteTime.text = "Marcin";
         oneFrameExecuteTime.color = new Color32(255,255,0,255);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
