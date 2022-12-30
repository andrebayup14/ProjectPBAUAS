using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
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
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game Quit");
    }
}

