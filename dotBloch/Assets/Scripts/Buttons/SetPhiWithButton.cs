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
        this.label.color = Color.green;
    }

    public void unhighligthLabel()
    {
        this.label.color = Color.white;
    }
}
