using UnityEngine;
using UnityEngine.UI;

public class SetAngleWithButton : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject recesiver;
    public double angle_to_send;

    public Text label;

    public string method_to_update;
    public void send_angle(){
        recesiver.SendMessage(method_to_update,angle_to_send);
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
