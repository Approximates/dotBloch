using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxEdit : MonoBehaviour {

    public Material black;
    public Material starsDefault;
    public Material starsLightBlue;
    public Material starsRed;

    // Use this for initialization
    void Start () {

        ChangeSkybox(starsLightBlue);

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ChangeSkybox(Material skybox)
    {
        RenderSettings.skybox = skybox;
    }

}
