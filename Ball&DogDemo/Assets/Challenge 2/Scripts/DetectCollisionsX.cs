﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{

    private void Start()
    {
        
    }
    private void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
