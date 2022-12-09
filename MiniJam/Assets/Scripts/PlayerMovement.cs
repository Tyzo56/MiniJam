using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float borderX = 1.8f;

    private float horizontalAxis;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= -borderX)
        {
            transform.position = new Vector3(-borderX, transform.position.y, transform.position.z);
        }
        if (transform.position.x >= borderX)
        {
            transform.position = new Vector3(borderX, transform.position.y, transform.position.z);
        }

        horizontalAxis = Input.GetAxisRaw("Horizontal");

        Movement();
    }
    void Movement()
    {
        Vector3 moveDirection = new Vector3(horizontalAxis * speed * Time.deltaTime, 0, 0);
        transform.Translate(moveDirection);
    }
}
