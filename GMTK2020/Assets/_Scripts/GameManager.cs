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
    public Text bestScoreTxt;
    
    private int score = 0;
    private float furthestDist;
    private int bestScore;

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
        bestScore = PlayerPrefs.GetInt("Score");
        bestScore = bestScore < score ? score : bestScore;
        PlayerPrefs.SetInt("Score", bestScore);
        bestScoreTxt.text = "Best Score: " + bestScore;
    }
}
