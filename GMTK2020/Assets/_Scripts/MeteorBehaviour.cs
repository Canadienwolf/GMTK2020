using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorBehaviour : MonoBehaviour
{
    public float speed;

    private GameObject player;
    private float step;
    private Vector3 lastPlayerDir;
    
    // Start is called before the first frame update
    void Start()
    {
       player = GameObject.FindWithTag("Player");
       lastPlayerDir = player.transform.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(lastPlayerDir * Time.deltaTime * speed);
    }

    private void OnCollisionEnter(Collision other)
    {
        print("I have collided");
        Destroy(gameObject);
    }
}
