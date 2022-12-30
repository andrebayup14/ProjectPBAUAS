using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ButtonStart : MonoBehaviour
{
    public GameObject panelLevel;

    public void OpenLevelSetup()
    {
        panelLevel.SetActive(true);
    }

    public void CloseLevelSetup()
    {
        panelLevel.SetActive(false);
    }
}
