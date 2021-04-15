using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBonusDecorator : BonusDecorator
{
    public HealthBonusDecorator(IBonus bonus) : base(bonus) { }

    public override void AddBonus()
    {
        base.AddBonus();
        PlayerState.health += 100;
    }
}
