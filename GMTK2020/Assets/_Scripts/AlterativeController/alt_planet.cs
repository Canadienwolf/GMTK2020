using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alt_planet : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<alt_player>()?.CurrentPlanet(transform);
    }

    private void OnTriggerExit(Collider other)
    {
        other.GetComponent<alt_player>()?.RemovePlanet(transform);
    }
}
