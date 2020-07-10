using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlanetGravity : MonoBehaviour
{
    public float mass;
    [Range(1, 10)]
    public float pullRestistance;
    public float speed;
    public Vector3 startVel;

    PlanetMass[] planets;
    [HideInInspector] public Vector3 currentVel;

    private void Awake()
    {
        planets = FindObjectsOfType<PlanetMass>();
        currentVel = startVel;
    }

    private void FixedUpdate()
    {
        for (int i = 0; i < planets.Length; i++)
        {
            if (planets[i] != this)
            {
                float sqaureDist = (planets[i].GetComponent<Rigidbody>().position - GetComponent<Rigidbody>().position).sqrMagnitude;
                Vector3 forceDir = (planets[i].GetComponent<Rigidbody>().position - GetComponent<Rigidbody>().position).normalized;
                Vector3 force = forceDir * planets[i].mass / pullRestistance;
                Vector3 acceleration = force / mass;
                currentVel += acceleration * Time.fixedDeltaTime * speed / 10;
            }
        }

        GetComponent<Rigidbody>().position += currentVel * Time.fixedDeltaTime * speed / 10;
    }

    public Vector3 ClosestPlanetPos()
    {
        Vector3 closestV3 = new Vector3();
        float closestDist = 0;

        for (int i = 0; i < planets.Length; i++)
        {
            if (planets[i] != this)
            {
                if (Vector3.Distance(planets[i].transform.position, transform.position) < closestDist || closestDist == 0)
                {
                    closestDist = Vector3.Distance(planets[i].transform.position, transform.position);
                    closestV3 = planets[i].transform.position;
                }
            }
        }

        return closestV3;
    }
}
