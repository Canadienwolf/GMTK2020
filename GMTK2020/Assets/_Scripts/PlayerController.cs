using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlanetGravity))]
public class PlayerController : MonoBehaviour
{
    public float rotateSpeed = 10f;
    public float thrustPower = 10f;
    public Camera cam;
    public float camSpeed = 30f;
    public float camOffset = 10;

    private PlanetGravity pg;

    private void Start()
    {
        pg = GetComponent<PlanetGravity>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, Input.GetAxis("Horizontal") * -rotateSpeed * Time.deltaTime, Space.World);
        if (Input.GetKey("space"))
        {
            Vector3 forceDir = transform.TransformDirection(Vector3.up);
            pg.currentVel += forceDir * thrustPower * Time.deltaTime;
        }

        cam.transform.position = Vector3.MoveTowards(cam.transform.position, pg.ClosestPlanetPos() + new Vector3(0, 0, -camOffset), Time.deltaTime * camSpeed);
    }
}
