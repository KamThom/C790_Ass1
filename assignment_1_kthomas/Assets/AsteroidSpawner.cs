using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public GameObject asteroidPrefab;  
    public int asteroidCount = 10;  
    public float spawnRadius = 50f;  // radius around player 

    void Start()
    {
        SpawnAsteroids();
    }

    void SpawnAsteroids()
    {
        for (int i = 0; i < asteroidCount; i++)
        {
            Vector3 randomPosition = Random.insideUnitSphere * spawnRadius;
            GameObject asteroid = Instantiate(asteroidPrefab, randomPosition, Random.rotation);
            asteroid.transform.parent = transform;
        }
    }
}
