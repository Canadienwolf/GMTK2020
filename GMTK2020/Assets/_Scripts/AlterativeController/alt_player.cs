using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alt_player : MonoBehaviour
{
    public bool gravity;
    public float forwardSpeed = 10f;

    Transform currentPlanet;

    private void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * forwardSpeed);

        if (gravity && Input.GetKeyDown("space"))
        {
            gravity = false;
        }

        if (gravity && currentPlanet != null)
        {
            print(transform.position - currentPlanet.position);
            gravity = false;
            //transform.right = Vector3.MoveTowards(transform.right, transform.position - currentPlanet.position + new Vector3(0, 0, 10), Time.deltaTime * 100);
        }
    }

    public void CurrentPlanet(Transform planet)
    {
        currentPlanet = planet;
        gravity = true;
    }
}
