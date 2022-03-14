using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject chocolate;
    public GameObject vegetable;
    public GameObject candy;
    private float ySpawn = 13.0f;
    private float xSpawnRange = 7.0f;
    private float zSpawn = -3.0f;

    private float chocolateSpawnTime = 3.0f;
    private float vegetableSpawnTime = 4.0f;
    private float candySpawnTime = 7.0f;
    private float startDelay = 1.0f;

    // GameManager controls when objects start and stop spawning
    public void StartSpawning() 
    {
        InvokeRepeating("SpawnChocolate", startDelay, chocolateSpawnTime);
        InvokeRepeating("SpawnVegetable", startDelay, vegetableSpawnTime);
        InvokeRepeating("SpawnCandy", startDelay, candySpawnTime);
    }

    public void StopSpawning()
    {
        CancelInvoke();
    }

    void SpawnChocolate() 
    {
        float randomX = Random.Range(-xSpawnRange, xSpawnRange);
        Vector3 spawnPos = new Vector3(randomX, ySpawn, zSpawn);

        Instantiate(chocolate, spawnPos, chocolate.gameObject.transform.rotation);
    }

    void SpawnVegetable() 
    {
        float randomX = Random.Range(-xSpawnRange, xSpawnRange);
        Vector3 spawnPos = new Vector3(randomX, ySpawn, zSpawn);

        Instantiate(vegetable, spawnPos, vegetable.gameObject.transform.rotation);
    }

    void SpawnCandy() 
    {
        float randomX = Random.Range(-xSpawnRange, xSpawnRange);
        Vector3 spawnPos = new Vector3(randomX, ySpawn, zSpawn);

        Instantiate(candy, spawnPos, candy.gameObject.transform.rotation);
    }
}
