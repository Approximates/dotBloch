using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetPhiWithButton : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject recesiver;
    public double angle_to_send;

    public Text label;
    public void send_angle(){
        recesiver.SendMessage("set_phi_angle",angle_to_send);
    }

    public void highlightLabel()
    {
        Debug.Log("Podświetlenie");
        this.label.color = Color.red;
    }

    public void unhighligthLabel()
    {
        Debug.Log("Gaszenie");
        this.label.color = Color.white;
    }
}
