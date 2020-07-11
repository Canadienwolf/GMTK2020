﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathBehavior : MonoBehaviour
{
    public GameObject menu;

    void OnEnable()
    {
        GameManager.Die += Died;
    }

    void OnDisable()
    {
        GameManager.Die -= Died;
    }

    void Died()
    {
        menu.SetActive(true);
    }
}