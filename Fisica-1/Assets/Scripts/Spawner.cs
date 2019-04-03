using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject asteroid;
    [SerializeField] GameObject bomb;
    [SerializeField] float spawnTime;

    void Start()
    {
        InvokeRepeating("SpawnAsteroids", spawnTime, spawnTime);
        //InvokeRepeating("SpawnBombs", spawnTime, spawnTime);
    }

    void SpawnAsteroids()
    {
        float randomPos = Random.Range(-5.0f, 5.0f);
        Vector3 pos = new Vector3(8.0f, randomPos, 0);

        Instantiate(asteroid, pos, Quaternion.identity);
    }

    void SpawnBombs()
    {
        float randomPos = Random.Range(-6.0f, 6.0f);
        Vector3 pos = new Vector3(randomPos, -2.0f, 0);

        Instantiate(bomb, pos, Quaternion.identity);
    }
}
