using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelController : MonoBehaviour
{
    public float currentFuel = 100;
    public float reductionSpeed = 10;
    public float fillSpeed = 20;
    public alt_player player;
    public Slider slider;

    private void Update()
    {
        ChangeFuel();
        slider.value = currentFuel;
    }

    void ChangeFuel()
    {
        if (player.inOrbit)
        {
            currentFuel = Mathf.MoveTowards(currentFuel, 100, Time.deltaTime * fillSpeed);
        }
        else
        {
            currentFuel = Mathf.MoveTowards(currentFuel, 0, Time.deltaTime * reductionSpeed);
        }

        if (currentFuel <= 0.01f)
        {
            player.enabled = false;
            GameManager.Kill();
        }
    }
}
