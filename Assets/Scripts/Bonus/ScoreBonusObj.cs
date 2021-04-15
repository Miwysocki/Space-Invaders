using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBonusObj : MonoBehaviour
{
    IBonus bonus;
    void Start()
    {
        bonus = new ScoreBonus();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Debug.Log(PlayerState.score);
            bonus.AddBonus();
            Destroy(this.gameObject);
        }
    }

}