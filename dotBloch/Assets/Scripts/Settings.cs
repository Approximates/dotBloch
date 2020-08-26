using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public GameObject settingsPanel;
    public Text languageText;

    void Start()
    {
        languageText.text = Application.systemLanguage.ToString();
    }
    public void ToggleSettingsPanel()
    {
        settingsPanel.SetActive(!settingsPanel.active);
    }
}
