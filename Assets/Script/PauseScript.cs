using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseScript : MonoBehaviour
{
    public GameObject panelPause;
    public GameObject panelDisplayGame;

    public static float XSpeedObstacleStop;

    public void Start()
    {
        
    }

    public void Continue()
    {
        panelPause.SetActive(false);
        panelDisplayGame.SetActive(true);
        Obstacle.XSpeed = XSpeedObstacleStop;
    }

    public void Restart()
    {
        GameOverScript.Restart();
    }

    public void MainMenu()
    {
        GameOverScript.MainMenu();
    }

    
}
