using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusDecorator :  IBonus
{
    //base decorator
    private IBonus _bonus;

    public BonusDecorator(IBonus bonus)
    {
        _bonus = bonus;
    }

    public virtual void AddBonus()
    {
        _bonus.AddBonus();
    }
}
