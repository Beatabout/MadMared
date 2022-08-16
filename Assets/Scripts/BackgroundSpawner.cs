using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSpawner : MonoBehaviour
{
    [Header("Clouds")]
    [SerializeField] GameObject cloudsPrefab;
    [SerializeField] float cloudsMinSpawnDelay = 3f;
    [SerializeField] float cloudsMaxSpawnDelay = 9f;
    [SerializeField] Transform cloudsSpawnPoint;

    [Header("Mountings")]
    [SerializeField] GameObject mountainPrefab;
    [SerializeField] float mountainMinSpawnDelay = 10f;
    [SerializeField] float mountainMaxSpawnDelay = 35f;
    [SerializeField] Transform mountainSpawnPoint;

    void Start()
    {
        StartCoroutine("SpawnClouds");
        StartCoroutine("SpawnMountains");
    }

    IEnumerator SpawnClouds(){
        while(true){
            float positionX = cloudsSpawnPoint.position.x;
            float positionY = Random.Range(cloudsSpawnPoint.position.y -2f, cloudsSpawnPoint.position.y + 2f);

            yield return new WaitForSeconds(Random.Range(cloudsMinSpawnDelay, cloudsMaxSpawnDelay));
            Instantiate(cloudsPrefab, new Vector3(positionX, positionY, 0), Quaternion.identity);
        }
    }

    IEnumerator SpawnMountains(){
        while(true){
            yield return new WaitForSeconds(Random.Range(mountainMinSpawnDelay, mountainMaxSpawnDelay));
            Instantiate(mountainPrefab, mountainSpawnPoint.position, Quaternion.identity);
        }
    }
}
