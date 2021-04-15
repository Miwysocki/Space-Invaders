using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class WeaponTemplate : IWeapon
{
    public GameObject missilePrefab;

    public int DAMAGE;

    public void Shoot(Transform shooter, bool isEnemyShooter)
    {
        if (isEnemyShooter)
        {
            GameObject missile = GameObject.Instantiate(missilePrefab, shooter.transform.position + new Vector3(0, -0.8f, 0), shooter.transform.rotation);
            missile.GetComponent<MissileControl>().SetMissileDamage(DAMAGE);
            missile.GetComponent<MissileControl>().SetShooter(isEnemyShooter);
        }
        else
        {
            GameObject missile = GameObject.Instantiate(missilePrefab, shooter.transform.position + new Vector3(0, 0.8f, 0), shooter.transform.rotation);
            missile.GetComponent<MissileControl>().SetMissileDamage(DAMAGE);
            missile.GetComponent<MissileControl>().SetShooter(isEnemyShooter);
        }
        
    }
}
