using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBonus : MonoBehaviour
{
    IBonus bonus, speedDecorator;
    void Start()
    {
        bonus = new ScoreBonus();
        speedDecorator = new SpeedBonusDecorator(bonus);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Debug.Log(PlayerState.score);
            speedDecorator.AddBonus();
            Destroy(this.gameObject);
        }
    }
}
