using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish_Spawn : MonoBehaviour
{
    public Transform[] SpawnPoints;
    public GameObject FishPrefab;
    public GameObject EnemyFishPrefab;

    //public float repeatRate;
    //These 2 varaiables used for varying spawnrates
    [SerializeField] float minInclusive;
    [SerializeField] float maxInclusive;
    public float time;
    private Vector3 randomSpawnPoint;// used to spawn at random point in x axis
    
    private void Start()
    {
        InvokeRepeating("SpawnFish", time, Random.Range(minInclusive, maxInclusive));
    }

    private void Update()
    {
        //repeatRate = Random.Range(0.6f, 5f);
        randomSpawnPoint = new Vector3(Random.Range(-2f, 2f), -0.672f, 6.727f);
    }

    void SpawnFish()
    {
        int fishType = Random.Range(0, 5);
        
        if(fishType == 0)
        {
            Instantiate(EnemyFishPrefab, randomSpawnPoint, Quaternion.identity);
        }
        else
        {
            Instantiate(FishPrefab, randomSpawnPoint, Quaternion.identity);
        }
    }
}

