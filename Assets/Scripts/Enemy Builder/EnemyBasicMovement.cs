using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBasicMovement : MonoBehaviour
{
    private Enemy e;

  
    float timer = 0;
    int numOfMovements = 0;
    float timeToMove = 0.6f;
    float speed = 0.20f;
    // Start is called before the first frame update
    void Start()
    {
      //  e = GetComponent<Enemy>();
     //   this.speed = e.Speed;
    }

    // Update is called once per frame
    void Update()
    {
        //  transform.position += new Vector3(3, 0, 0) * Time.deltaTime;
        if (transform.position.y < 0) { PlayerState.health = 0 ; }
            //move down 
            if (numOfMovements == 10)
        {
            transform.Translate(new Vector3(0, -0.5f, 0));
            numOfMovements = -1;
            speed = -speed;
            timer = 0;
        }

        //move sideway
        timer += Time.deltaTime;
        if (timer > timeToMove && numOfMovements < 14)
        {  
                transform.Translate(new Vector3(speed, 0, 0));
                if(transform.position.x < 0.3) transform.Translate(new Vector3(0.25f, 0, 0));
                if (transform.position.x >17.5) transform.Translate(new Vector3(-0.25f, 0, 0));
                 timer = 0;
                 numOfMovements++;
            
        }
    }
}
