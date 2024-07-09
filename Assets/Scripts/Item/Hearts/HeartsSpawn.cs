using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartsSpawn : MonoBehaviour
{
    public GameObject heartsPrefap;
    public float timer;
    public float spawnInterval = 5;

    void Update()
    {
        if (Moving.isStart)
        {
            float randomX = spawnInterval;
            timer += Time.deltaTime;
            if (timer >= randomX)
            {
                SpawnHearts();
                timer = 0;
                randomX = 0;
            }
            if (randomX == 0)
            {
                spawnInterval = Random.Range(7f, 15f);
            }
        }
    }   


    void SpawnHearts()
    {
        float randomX = Random.Range(-8f, 8f);
        Vector3 spawnPoint = new Vector3(randomX, 6f, 0f);
        Instantiate(heartsPrefap, spawnPoint, Quaternion.identity);
    }
}