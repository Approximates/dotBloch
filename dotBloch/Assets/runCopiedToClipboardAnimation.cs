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

        animation.Play("copyToClipboard");
        Debug.Log("Animacja zakonczona!");
    }
}
