﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWheel : MonoBehaviour
{
  
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0f, 0f, 1000f) * Time.deltaTime); 
    }
}