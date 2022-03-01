using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject chocolate;
    public GameObject vegetable;
    public GameObject powerup;
    private float ySpawn = 13.0f;
    private float xSpawnRange = 12.0f;
    private float zSpawn = -3.0f;

    private float chocolateSpawnTime = 2.0f;
    private float vegetableSpawnTime = 3.0f;
    private float powerupSpawnTime = 7.0f;
    private float startDelay = 1.0f;

    void Start()
    {
       InvokeRepeating("SpawnChocolate", startDelay, chocolateSpawnTime);
       InvokeRepeating("SpawnVegetable", startDelay, vegetableSpawnTime);
       InvokeRepeating("SpawnPowerup", startDelay, powerupSpawnTime);
    }


    void Update()
    {
        
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

    void SpawnPowerup() 
    {
        float randomX = Random.Range(-xSpawnRange, xSpawnRange);
        Vector3 spawnPos = new Vector3(randomX, ySpawn, zSpawn);

        Instantiate(powerup, spawnPos, powerup.gameObject.transform.rotation);
    }
}
