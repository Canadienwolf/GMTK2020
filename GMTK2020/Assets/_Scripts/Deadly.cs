using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deadly : MonoBehaviour
{
    public bool selfDestruct;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            GameManager.Kill();
        }

        if (selfDestruct)
        {
            Destroy(gameObject);
        }

    }
}
