using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameSceneScript : MonoBehaviour
{
    public GameObject panelPause;
    public GameObject panelDisplayGame;
    public Text txtScore;

    public void Pause()
    {
        panelPause.SetActive(true);
        panelDisplayGame.SetActive(false); 
        txtScore.text = "SCORE : " + Score.nbScore.ToString();
        PauseScript.XSpeedObstacleStop = Obstacle.XSpeed;
        Obstacle.XSpeed = 0;
    }
}
