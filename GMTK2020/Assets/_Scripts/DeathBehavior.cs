using System.Collections;
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
        Time.timeScale = 1;
    }

    void Died()
    {
        Invoke("ActivateDeathMenu", 1);
    }

    void ActivateDeathMenu()
    {
        menu.SetActive(true);
        Time.timeScale = 0;
    }
}
