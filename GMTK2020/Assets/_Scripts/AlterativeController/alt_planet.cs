using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alt_planet : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<alt_player>().CurrentPlanet(transform);
        }
    }
}
