using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBonusDecorator : BonusDecorator
{
    // Start is called before the first frame update
    public SpeedBonusDecorator(IBonus bonus) : base(bonus) { }

    public override void AddBonus()
    {
        base.AddBonus();
        PlayerState.movementSpeed += 1;
    }
}
