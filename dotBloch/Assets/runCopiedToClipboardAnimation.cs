using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class runCopiedToClipboardAnimation : MonoBehaviour
{
    public void displayCopiedLabel()
    {
        Animator animation = gameObject.GetComponent<Animator>();
        animation.Play("copyToClipboard");
    }
}
