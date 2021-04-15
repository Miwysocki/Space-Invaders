using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemyShooting : MonoBehaviour
{
    private readonly float shootChance = 1.2f; // chance = (1/shootchance) * 100%
    private readonly float shootTryInterval = 1; // 1 = 1s;
    private float timetracker = 0;
    private IWeapon weapon;
    int randomnumber;
    private void Start()
    {
      //  weapon = new WeaponGreen();
    }
    
    void LateUpdate()
    {
        Shooting();
    }

    public void Shooting()
    {
        if (Time.time > timetracker + shootTryInterval)
        {
            if ((Random.Range(0, 100) * shootChance) <= 100) 
                weapon.Shoot(transform, true);
            timetracker = Time.time;
        }
    }

    public void SetWeapon(IWeapon _weapon)
    {
        weapon = _weapon;
    }

}
