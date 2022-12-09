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
        Instantiate(FishPrefab, SpawnPoints[0].transform.position, Quaternion.identity);
    }
}
