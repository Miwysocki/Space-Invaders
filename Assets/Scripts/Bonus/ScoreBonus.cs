using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBonus : IBonus
{
    //concrete implementation
    public void AddBonus()
    {
        PlayerState.score += 10;
    }
}

