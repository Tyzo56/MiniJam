using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish_Spawn : MonoBehaviour
{
   public Transform[] SpawnPoints;
   public GameObject FishPrefab;

    [SerializeField] float repeatRate;
    private void Start()
    {
        InvokeRepeating("SpawnFish", 2f, repeatRate);
    }

    private void Update()
    {
        
    }

    void SpawnFish()
    {
        Instantiate(FishPrefab, SpawnPoints[Random.Range(0,4)].transform.position, Quaternion.identity);
    }
}
