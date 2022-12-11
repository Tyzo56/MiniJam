using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMovement : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MoveForward();
    }
    void MoveForward()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
        if(transform.position.z < -15)
        {
            GameObject.Destroy(gameObject);
        }
    }
}
