using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static Action Die;
    public Transform player;
    public int score;

    private float furthestDist;

    void OnEnable()
    {
        Die += Died;
    }

    void OnDisable()
    {
        Die -= Died;
    }

    private void Update()
    {
        
    }


    public static void Kill()
    {
        Die.Invoke();
    }

    void Died()
    {
        print("died");
    }
}
