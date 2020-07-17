using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class copiedTextPrompt : MonoBehaviour
{
    private float timer;
    private Image sprite;
    private Text message;

    void Start(){
        sprite = GameObject.Find("CopyToClipboard").GetComponent<Image>();
        message = GameObject.Find("copied_message").GetComponent<Text>();
        Debug.Log("sprite: " + sprite);
        Debug.Log("message: " + message);
        sprite.enabled = false;
        message.enabled = false;

    }

    void Update(){
        sprite.enabled = true;
        message.enabled = true;
    }
    public void displayCopiedLabel(){
        Debug.Log("Odebralem przesylke");
        timer = 1.0f;

        gameObject.GetComponent("Image");

        while(timer>0){

        }
    }
}
