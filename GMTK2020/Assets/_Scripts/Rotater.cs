﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour
{
    public float rotSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * -rotSpeed * Time.deltaTime);
    }
}
