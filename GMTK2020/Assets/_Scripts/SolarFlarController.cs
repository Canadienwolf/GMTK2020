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
            StartCoroutine(SunFlare());
            _spawnTime = Random.Range(40, 100);
        }
    }

    IEnumerator SunFlare()
    {
        print("it ran");
        text.SetActive(true);
        
        yield return new WaitForSeconds(5);
        print("100");
        image.GetComponent<Image>().color = new Color32(255, 255, 0 , 100);
        
        
        yield return new WaitForSeconds(5);
        print("255");
        image.GetComponent<Image>().color = new Color32(255, 255, 0 , 255);
        print("snuffy stuff");
        text.SetActive(false);
        print("it ran");

        yield return new WaitForSeconds(2);
        image.GetComponent<Image>().color = new Color32(255, 255, 0 , 0);

        yield return null;
    }
}
