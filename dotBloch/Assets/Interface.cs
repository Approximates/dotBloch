using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interface : MonoBehaviour
{
    public GameObject ExitPanel;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ExitButtonYes_Click()
    {
        Application.Quit();
    }

    public void ExitButtonNo_Click()
    {
        ExitPanel.SetActive(false);
    }

}
