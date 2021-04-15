using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            if (transform.position.y < 9.7)
                transform.position += new Vector3(0, PlayerState.movementSpeed, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            if (transform.position.y > 0.3)
                transform.position += new Vector3(0, -PlayerState.movementSpeed, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            if(transform.position.x > 0.3)
                transform.position += new Vector3(-PlayerState.movementSpeed, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (transform.position.x < 17.5)
                transform.position += new Vector3(PlayerState.movementSpeed, 0, 0) * Time.deltaTime;
        }
    }
}
