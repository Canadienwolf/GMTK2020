using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SolarFlarController : MonoBehaviour
{
    public GameObject image;
    public GameObject text;

    private float _currentTime;
    private float _spawnTime;
    
    // Start is called before the first frame update
    void Start()
    {
        text.SetActive(false);
        _spawnTime = Random.Range(1, 10);
    }

    // Update is called once per frame
    void Update()
    {
        _currentTime += Time.deltaTime;

        if (_currentTime >= _spawnTime)
        {
            
            _spawnTime = 0;
            _currentTime = 0;
            StartCoroutine(SunFlare());
            _spawnTime = Random.Range(1, 10);
        }
    }

    IEnumerator SunFlare()
    {
        print("it ran");
        text.SetActive(true);
        
            
        new WaitForSeconds(50);
        image.GetComponent<Image>().color = new Color(255, 255, 0 , 255);
        print("snuffy stuff");
        text.SetActive(false);
        print("it ran");

        new WaitForSeconds(10);
        image.GetComponent<Image>().color = new Color(255, 255, 0 , 0);

        yield return null;
    }
}
