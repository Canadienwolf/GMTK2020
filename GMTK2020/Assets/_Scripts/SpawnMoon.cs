using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMoon : MonoBehaviour
{
    public GameObject moon;
    [Range(0, 100)]
    public float spawnChance = 0;
    public float spawnOffset = 10;

    void Start()
    {
        bool isSpawning = Random.Range(0, 100) < spawnChance ? true : false;

        if (isSpawning)
        {
            Instantiate(moon, transform.position + Vector3.right * spawnOffset, Quaternion.identity);
            transform.rotation = Quaternion.Euler(0, 0, Random.Range(0, 360));
        }


    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position + Vector3.right * spawnOffset, 1);
    }
}
