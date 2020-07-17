using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class copiedTextPrompt : MonoBehaviour
{
    private float timer;
    private Image sprite;
    private Text message;
    private float timeOfFrameExecution;

    void Start(){
        sprite = GameObject.Find("CopyToClipboard").GetComponent<Image>();
        message = GameObject.Find("copied_message").GetComponent<Text>();
        Debug.Log("sprite: " + sprite);
        Debug.Log("message: " + message);
        sprite.enabled = false;
        message.enabled = false;
    }

    void Update(){
        //if(sprite.IsActive())
            timeOfFrameExecution = Time.deltaTime;
    }
    public void displayCopiedLabel(){
        Debug.Log("Odebralem przesylke");

        timer = 1.0f;
        sprite.enabled = true;
        message.enabled = true;

        //while(timer>0){
          //  timer -= timeOfFrameExecution;
            //byte transparency = Convert.ToByte(255 * timer);
            //sprite.color = new Color32(255,255,255,transparency);
            //message.color = new Color32(255,255,255,transparency);
        //}

        //sprite.enabled = false;
        //message.enabled = false;
    }
}
