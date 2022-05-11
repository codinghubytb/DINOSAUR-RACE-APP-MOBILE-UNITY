using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour
{
    public Text txtScore;
    public AudioSource audioSource;

    public AudioClip clip;

    public void Start()
    {
        audioSource.clip = clip;
        txtScore.text = "Score : " + Score.nbScore.ToString();
        Score.RestartScore();
    }

    public static void Restart()
    {
        RestartGame();
        Score.RestartScore();
        SceneManager.LoadScene("Game Scene");
    }

    public static void MainMenu()
    {
        RestartGame();
        Score.RestartScore();
        SceneManager.LoadScene("Main Scene");
    }

    public static void RestartGame()
    {
        Obstacle.XSpeed = 0.5f;
        Obstacle.xmin = 20;
        Obstacle.xmax = 40;
    }
}
