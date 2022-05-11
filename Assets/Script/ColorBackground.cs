using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorBackground : MonoBehaviour
{
    private int nbColor = 0;
    private int value = 1;
    void Update()
    {
        Camera.main.backgroundColor = new Color(nbColor/255, nbColor/255, nbColor/255,1);
        print(Camera.main.backgroundColor);
        if (nbColor >= 255)
            value = -1;
        else if (nbColor <= 0)
            value = 1;
        nbColor += value;
    }
}
