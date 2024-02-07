using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStart : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject asteroidSpawner;
    public GameObject waveSpawner;
    public GameObject circularSpawner;
    void Awake()
    {
        if (PlayerPrefs.GetInt("Asteroid", 0) == 1)
        {
            asteroidSpawner.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Wave", 0) == 1)
        {
            waveSpawner.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Revolver", 0) == 1)
        {
            circularSpawner.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
