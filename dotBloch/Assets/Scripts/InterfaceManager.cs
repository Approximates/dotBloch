using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEditor;

public class InterfaceManager : MonoBehaviour
{
    public Text milisecondsLabel;
    public Text fpsLabel;
    public FPSCounter fps;
    // Start is called before the first frame update
    void Start()
    {
        fps = new FPSCounter();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
