using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SolarFlarController : MonoBehaviour
{
    public GameObject image;
    public GameObject text;

    private bool _sunFlare;
    private float _currentTime;
    private float _spawnTime;
    
    // Start is called before the first frame update
    void Start()
    {
        _sunFlare = true;
        _spawnTime = Random.Range(1, 100);
    }

    // Update is called once per frame
    void Update()
    {
        if (_sunFlare)
        {
            text.SetActive(true);
            
            new WaitForSeconds(10);
            image.GetComponent<Image>().color = new Color(255, 255, 0 , 255);
            text.SetActive(false);

            new WaitForSeconds(10);
            image.GetComponent<Image>().color = new Color(255, 255, 0 , 0);
            _sunFlare = false;
        }

        _currentTime += Time.deltaTime;

        if (_currentTime >= _spawnTime)
        {
            _sunFlare = true;
        }

    }
}
