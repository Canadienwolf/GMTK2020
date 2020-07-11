using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static Action Die;

    void OnEnable()
    {
        Die += Died;
    }

    void OnDisable()
    {
        Die -= Died;
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
