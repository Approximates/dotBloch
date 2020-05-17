using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEditor;

public class CameraScript : MonoBehaviour
{
    void Start()
    {
      double cameraAspectRatio =  gameObject.GetComponent<Camera>().aspect;
      cameraAspectRatio = Math.Round(cameraAspectRatio,2);

  if (cameraAspectRatio == 1.6) //16:10
    {
        gameObject.GetComponent<Camera>().transform.Rotate(0,-2,0);
    }else if(cameraAspectRatio == 1.33) //4:3
    {
        gameObject.GetComponent<Camera>().transform.Rotate(0,2,0);
        gameObject.GetComponent<Camera>().orthographicSize = 2.32f;
    }else if (cameraAspectRatio == 1.25) //5:4
    {
         gameObject.GetComponent<Camera>().orthographicSize = 2.75f;
         gameObject.GetComponent<Camera>().transform.Rotate(0,4,0);
    }else if (cameraAspectRatio == 1.5) //3:2
    {
        gameObject.GetComponent<Camera>().transform.Rotate(0,2,0);
        gameObject.GetComponent<Camera>().orthographicSize = 2.12f;
    }
}

    // Update is called once per frame
    void Update()
    {
        
    }
}
