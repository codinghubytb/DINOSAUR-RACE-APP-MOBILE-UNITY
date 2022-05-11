using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMove : MonoBehaviour
{
    public float XSpeed;

    void Update()
    {
        transform.position = new Vector2(transform.position.x - XSpeed, transform.position.y);
        if (transform.position.x < -25)
            transform.position = new Vector2(30, transform.position.y);
    }
}
