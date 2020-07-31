using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class runCopiedToClipboardAnimation : MonoBehaviour
{
    public void displayCopiedLabel()
    {
        Debug.Log("Uruchomilem animacje!");
        Animator animation = gameObject.GetComponent<Animator>();
        Debug.Log("Stan animatora: " + animation);

        bool isAnimationRunning = animation.GetBool("isOpened");
        animation.SetBool("isOpened", !isAnimationRunning);
        Debug.Log("Animacja zakonczona!");
    }
}
