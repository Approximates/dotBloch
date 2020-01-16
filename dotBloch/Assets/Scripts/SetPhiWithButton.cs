using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPhiWithButton : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject recesiver;
    public double angle_to_send;
    public void send_angle(){
        recesiver.SendMessage("set_phi_angle",angle_to_send);
        Debug.Log("Wysłałem: " + angle_to_send);
    }
}
