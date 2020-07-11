using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject[] planets;
    public float difficultyInterval = 10;

    private int difficultyCounter = 3;
    private int intervalCounter;
    Vector3 spawnPos = new Vector3();
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        SpawnPlanet();
        SpawnPlanet();
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            if (Vector3.Distance(player.transform.position, spawnPos) < 300)
                SpawnPlanet();
        }
    }

    void SpawnPlanet()
    {
        GameObject obj = Instantiate(planets[Random.Range(0, difficultyCounter)], spawnPos, Quaternion.identity);
        if (intervalCounter == difficultyInterval)
        {
            difficultyCounter++;
            intervalCounter = 0;
        }
        else
        {
            intervalCounter++;
        }

        spawnPos.x = 0;
        spawnPos += new Vector3(Random.Range(-40, 40), Random.Range(70, 80), 0);
    }
}
