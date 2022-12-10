using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteOnCollision : MonoBehaviour
{
    private GameManager GM;

    private void Start()
    {
        GameObject go = GameObject.Find("GameManager");
        GM = go.GetComponent<GameManager>();
    }
    private void OnTriggerEnter(Collider other)
    { 
        GM.score++;
        Debug.Log("destroy fish");
        GameObject.Destroy(gameObject);
    }
}
