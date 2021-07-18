using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsBackgroundDropdown : MonoBehaviour
{
    public Dropdown backgroundDropdown;
    public Camera camera;
    public Image panel;  

    public void ChangeColor()
    {
        if(backgroundDropdown.value == 0)
        {
            camera.backgroundColor = new Color(0.02745098f, 0.07843138f, 0.1803922f, 255);
            panel.color = new Color(0.04313726f, 0.1058824f, 0.2352941f, 243);
        }
        else if (backgroundDropdown.value == 1)
        {
            camera.backgroundColor = new Color(0.1333333f, 0, 0.01568628f, 255);
            panel.color = new Color(0.085f, 0, 0, 243);
        }
    }
}
