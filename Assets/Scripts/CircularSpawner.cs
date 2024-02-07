using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircularSpawner : MonoBehaviour
{
    public GameObject circularEnemyPrefab;
    public float spawnInterval = 2f;




    void Start()
    {
        StartCoroutine(SpawnCircularEnemy());
    }

    IEnumerator SpawnCircularEnemy()
    {
        while (true)
        {
            // Randomize the radius within the specified range (2, 8)
            int radius = Random.Range(2, 7);
            float speed = Random.Range(0.3f, 1f); // Upper bound is exclusive in Random.Range

            // Spawn CircularEnemyPrefab
            GameObject enemy = Instantiate(circularEnemyPrefab, transform.position, Quaternion.identity);
            enemy.transform.SetParent(GameObject.Find("CircularHolder").transform);
            // Access the CircularMovement2D component and set the radius
            CircularMovement2D circularMovement = enemy.GetComponent<CircularMovement2D>();
            if (circularMovement != null)
            {
                circularMovement.radius = Random.Range(2, 7);
                circularMovement.speed = Random.Range(0.3f, 1f);
            }

            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
