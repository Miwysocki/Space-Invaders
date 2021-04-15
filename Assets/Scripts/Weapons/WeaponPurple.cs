using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPurple : WeaponTemplate
{
    public WeaponPurple()
    {
        DAMAGE = 40;
        missilePrefab = Resources.Load("MissilePurple") as GameObject;
    }
}
