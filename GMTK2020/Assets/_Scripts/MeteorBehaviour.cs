using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorBehaviour : MonoBehaviour
{
    public float speed;

    public float timeToDeath;

    private GameObject player;
    private float step;
    private Vector3 lastPlayerDir;
    
    // Start is called before the first frame update
    void Start()
    {
       player = GameObject.FindWithTag("Player");
       lastPlayerDir = player.transform.position - transform.position;
       timeToDeath = 20000;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(lastPlayerDir * Time.deltaTime * speed);

        timeToDeath--;
        
        if (timeToDeath == 0)
        { 
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        print("I have collided");
        Destroy(gameObject);
    }
}
