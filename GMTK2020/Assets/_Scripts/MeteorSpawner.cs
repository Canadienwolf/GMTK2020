using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;
using Random = UnityEngine.Random;

public class MeteorSpawner : MonoBehaviour
{
    public GameObject meteor;
    
    //---------------------------------------------------------------------------------------------------------------------------------
    
    private float _min = 1f;
    private float _max = 2f;
    
    private float _currentTime;
    private float _spawnTime;

    private Vector3 _final;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        _currentTime += Time.deltaTime;

        if (_currentTime >= _spawnTime)
        {
            SpawnObject();
            _spawnTime = Random.Range(_min, _max);
            _currentTime = _min;
        }
    }

    void SpawnObject()
    {
        _final = Camera.main.ViewportToWorldPoint(new Vector3(Random.Range(0f, 1f), 1, (10)));
        Instantiate(meteor, _final, Quaternion.identity);
    }
}
