using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBonus : MonoBehaviour
{

    IBonus bonus, healthDecorator;
    void Start()
    {
         bonus = new ScoreBonus();
         healthDecorator = new HealthBonusDecorator(bonus);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
           // Debug.Log(PlayerState.score);
            healthDecorator.AddBonus();
            Destroy(this.gameObject);
        }
    }
}
