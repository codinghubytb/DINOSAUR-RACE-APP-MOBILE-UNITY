using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public GameObject Obstacle1;
    public GameObject Obstacle2;
    public GameObject Obstacle3;
    public GameObject Sprike1;

    public GameObject Player;

    private GameObject[] TabObstacle;
    private GameObject[] InstantiateObstacle;


    public float XPos = 20;
    public float XSpace = 10;

    public static float xmin = 20;
    public static float xmax = 40;

    public static float XSpeed = 0.5f;

    void Start()
    {
        TabObstacle = new GameObject[] { Obstacle1, Obstacle2, Obstacle3, Sprike1};
        InstantiateObstacle = new GameObject[TabObstacle.Length];

        InitialiseObstacle();
    }


    void Update()
    {
        ObstacleMove();
        ChangePositionObstacle();
    }

    public void InitialiseObstacle()
    {
        for (int i = 0; i < TabObstacle.Length; i++)
        {
            GameObject obstacle = Instantiate(TabObstacle[i]);
            InstantiateObstacle[i] = obstacle;
        }
        for (int i = 0; i < InstantiateObstacle.Length; i++)
        {
            InstantiateObstacle[i].transform.position = new Vector2(XPos, TabObstacle[i].transform.position.y);
            XPos += XSpace;
        }
    }

    public void ObstacleMove()
    {
        for (int i = 0; i < InstantiateObstacle.Length; i++)
        {
            InstantiateObstacle[i].transform.position = 
                new Vector2(InstantiateObstacle[i].transform.position.x - XSpeed, TabObstacle[i].transform.position.y);
        }
    }

    public void ChangePositionObstacle()
    {
        for(int i=0; i<InstantiateObstacle.Length; i++)
        {
            if (InstantiateObstacle[i].transform.position.x < -15)
            {
                DestroyObstacle(InstantiateObstacle[i]);
                UpScore();
                CreateObstacle(i);
            }
        }
    }

    public void DestroyObstacle(GameObject obstacle)
    {
        Destroy(obstacle);
    }

    public void CreateObstacle(int value)
    {
        float x;
        int ValueObstacleRandom = Random.Range(0, TabObstacle.Length);
        InstantiateObstacle[value] = Instantiate(TabObstacle[ValueObstacleRandom]);
        if (value - 1 < 0)
            x = InstantiateObstacle[3].transform.position.x + Random.Range(xmin, xmax);
        else
            x = InstantiateObstacle[value - 1].transform.position.x + Random.Range(xmin, xmax);
        InstantiateObstacle[value].transform.position = new Vector2(x, TabObstacle[ValueObstacleRandom].transform.position.y);
    }

    public void UpScore()
    {
        Score.nbScore++;
    }

}
