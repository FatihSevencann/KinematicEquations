using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public double predictedTime;
    public KinematicScript Player1;
    public KinematicScript Player2;
    
    
    void Start()
    {
        CalculateTime();
    }

    private void CalculateTime()
    {   float h = Player2.transform.position.x - Player1.transform.position.x;
        float a = Player2.Acceleration - Player1.Acceleration;
        float b = 2 * (Player2.initialVelocity - Player1.initialVelocity);
        float c = h * 2;

        predictedTime = (-b - Mathf.Sqrt(b * b - 4 * a * c) ) /(2*a);
        Debug.Log("Period :"+predictedTime);





    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
