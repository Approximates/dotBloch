﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitPanel : MonoBehaviour
{
    public GameObject ExitPanel;

    public void ExitButtonYes_Click()
    {
        Application.Quit();
    }

    public void ExitButtonNo_Click()
    {
        ExitPanel.SetActive(false);
    }
}
