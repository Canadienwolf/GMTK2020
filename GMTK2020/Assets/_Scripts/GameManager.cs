using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static Action Die;
    public Transform player;
    public Text scoreTxt;
    
    private int score = 0;
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
        if (score < player.position.y)
        {
            score = (int)player.position.y;
        }

        scoreTxt.text = "Score: " + score;
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
