using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodAndTrapSpawner : MonoBehaviour
{
    [SerializeField] Transform[] spawnPoint;

    [SerializeField] GameObject foodPrefab;
    [SerializeField] GameObject trapPrefab;

    [SerializeField] float spawnDelay = 1.5f;
    [SerializeField] [Range(0,100)] float foodCnance = 20;

    float timer = 0f;
    float randomChance;
    int randomPoint;

    void Update()
    {
        SpawnRandomObject();
    }

    private void SpawnRandomObject()
    {
        timer += Time.deltaTime;
        randomChance = Random.Range(0, 100);
        randomPoint = Random.Range(0, spawnPoint.Length);
        
        if (timer >= spawnDelay)
        {
            if(randomChance <= foodCnance){
                Instantiate(foodPrefab, spawnPoint[randomPoint].position, Quaternion.identity);
            } else {
                Instantiate(trapPrefab, spawnPoint[randomPoint].position, Quaternion.identity);
            }
            timer = 0f;
        }
 
    }
}
