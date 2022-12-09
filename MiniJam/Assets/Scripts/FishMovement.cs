using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMovement : MonoBehaviour
{
    [SerializeField] float speed;
    GameLogic _GameLogic;
    // Start is called before the first frame update
    void Start()
    {
        //getting a variable from the GameLogic script
        GameObject gL = GameObject.Find("GameManager");
        _GameLogic = gL.GetComponent<GameLogic>();
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
        if(transform.position.z <= -10)
        {
            GameObject.Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("+1 score");
            _GameLogic.score++;
        }
    }
}
