using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMovement : MonoBehaviour
{
    [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MoveForward();
        Delete();
    }
    void MoveForward()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }
    void Delete()
    {
        if (transform.position.z <= -10)
        {
            GameObject.Destroy(gameObject);
        }
    }
}
