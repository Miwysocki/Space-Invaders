using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponRed : WeaponTemplate
{
    public WeaponRed()
    {
        DAMAGE = 50;
        missilePrefab = Resources.Load("MissileRed") as GameObject;
    }
}
