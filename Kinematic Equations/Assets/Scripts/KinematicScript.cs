using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KinematicScript : MonoBehaviour
{
  public float initialVelocity;
  public float Acceleration;

  private float currentVelocity;
  public Timer TimerScript;

  private void Start()
  {
    currentVelocity = initialVelocity;
  }

  private void FixedUpdate()
  {
    if (Time.fixedTime < TimerScript.predictedTime)
    {

      currentVelocity += Acceleration * Time.fixedDeltaTime;
      transform.Translate(Vector3.right*currentVelocity*Time.fixedDeltaTime);
      
    }
    
  }
}
