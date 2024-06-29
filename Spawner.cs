using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform topBorder;
    public Transform botBorder;
    public GameObject enemyPrefabe;
    public float spawnIntervalMax = 2;
    public float spawnIntervalMin = 1;
    public float spawnTimer = 0;

    public void Spawn()
    {
        Vector2 posSpawn = new Vector2(gameObject.transform.position.x, Random.Range(botBorder.position.y, topBorder.position.y));
        Instantiate(enemyPrefabe, posSpawn, Quaternion.identity);
    }

    public void Update()
    {
        if (spawnTimer <= 0)
        {
            Spawn();
            spawnTimer = Random.Range(spawnIntervalMin, spawnIntervalMax);
        }
        else
        {
            spawnTimer -= Time.deltaTime;
        }
    }
}
