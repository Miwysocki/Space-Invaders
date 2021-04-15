using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyConstantMovement : MonoBehaviour
{
    float timer = 0.0f;
    float speed = 0.30f;
    bool goDown = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer < 5) {
             transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
            transform.position += new Vector3(0, -0.20f, 0) * Time.deltaTime;

            if (transform.position.x < 0.3) transform.Translate(new Vector3(0.25f, 0, 0));
            if (transform.position.x > 17.5) transform.Translate(new Vector3(-0.25f, 0, 0));
        }

        if (timer > 10) { speed = -speed; timer = 0; }





    }
}
