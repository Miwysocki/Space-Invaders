using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponGreen : WeaponTemplate
{
    public WeaponGreen()
    {
        DAMAGE = 20;
        missilePrefab = Resources.Load("MissileGreen") as GameObject;
    }
}
