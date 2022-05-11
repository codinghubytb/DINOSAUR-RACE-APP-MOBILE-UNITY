using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int nbScore = 0;
    private bool valueUpParameters = true;
    private int valueScore;
    public Text txtScore;

    public static void RestartScore()
    {
        nbScore = 0;
    }
    void Update()
    {
        txtScore.text = nbScore.ToString();
        if (nbScore == valueScore)
            valueUpParameters = false;
        else
            valueUpParameters = true;
        LevelScore();
    }

    public void LevelScore()
    {
        if (valueUpParameters)
        {
            if (nbScore % 10 == 0)
            {
                Obstacle.XSpeed += 0.1f;
                Obstacle.xmin += 2;
                Obstacle.xmax += 2;
                valueScore = nbScore;
            }
        }
        
    }
}
