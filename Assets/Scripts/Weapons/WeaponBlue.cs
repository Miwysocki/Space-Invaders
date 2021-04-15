using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponBlue : WeaponTemplate
{
    public WeaponBlue()
    {
        DAMAGE = 10;
        missilePrefab = Resources.Load("MissileBlue") as GameObject;
    }
}
