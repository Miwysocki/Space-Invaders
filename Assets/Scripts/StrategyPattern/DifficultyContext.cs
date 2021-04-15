using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyContext
{
    Difficulty difficulty;


    public DifficultyContext()
    {
         SetStrategy(new Easy());
    }

    public void SetStrategy(Difficulty _difficulty)
    {
        difficulty = _difficulty;
    }
}
