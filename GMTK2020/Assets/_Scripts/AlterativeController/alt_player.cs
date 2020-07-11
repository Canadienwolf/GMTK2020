using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alt_player : MonoBehaviour
{
    public float forwardSpeed = 40f;
    public float rotSpeed = 10f;
    public Camera cam;

    [HideInInspector] public bool gravity;

    Transform currentPlanet;
    Vector3 targetDir = new Vector3();
    bool clockwise;
    Vector3 camOffset = new Vector3(0, 0, -10);
    public bool inOrbit;

    private void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * forwardSpeed);
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, transform.eulerAngles.z));
        cam.transform.position = transform.position + camOffset;
        inOrbit = currentPlanet != null ? true : false;

        if (gravity && Input.GetKeyDown("space"))
        {
            gravity = false;
        }

        if (gravity && currentPlanet != null)
        {
            if (clockwise)
            {
                targetDir = (currentPlanet.position + transform.TransformDirection(Vector3.up * -5)) - (transform.position);
            }
            else
            {
                targetDir = (transform.position) - (currentPlanet.position + transform.TransformDirection(Vector3.up * -5));
            }

            transform.right = Vector3.MoveTowards(transform.right, targetDir, Time.deltaTime * rotSpeed);
        }
    }

    public void CurrentPlanet(Transform planet)
    {
        currentPlanet = planet;
        gravity = true;

        Vector3 dir = transform.InverseTransformDirection(transform.position - currentPlanet.position);
        clockwise = dir.x < 0 ? true : false;
    }

    public void RemovePlanet(Transform planet)
    {
        if (currentPlanet == planet)
        {
            currentPlanet = null;
            gravity = false;
        }
    }
}
