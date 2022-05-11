using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainSceneScript : MonoBehaviour
{
    public GameObject panelSettings;
    public void StartGame()
    {
        SceneManager.LoadScene("Game Scene");
    }

    public void Settings()
    {
        panelSettings.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }


}

