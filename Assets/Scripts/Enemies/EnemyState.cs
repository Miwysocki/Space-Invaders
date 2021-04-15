using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyState : MonoBehaviour
{
    private int Health
    {
        get
        {
            return _health;
        }
        set
        {
            _health = value;
            IsEnemyStillAlive();
        }
    }
    private int _health;
    private int MS;
    private IWeapon _weapon;
    private IWeapon Weapon
    {
        get
        {
            return _weapon;
        }
        set
        {
            _weapon = value;
            ChangeWeaponInShootingScript();
        }
    }

    private void Start()
    {
        Health = 1;
        Weapon = new WeaponGreen();
    }

    public void TookDamage(int dmgTaken)
    {
        Health -= dmgTaken;
    }

    private void IsEnemyStillAlive()
    {
        if (Health <= 0)
        {
            Destroy(transform.gameObject);
        }
    }

    private void ChangeWeaponInShootingScript()
    {
        gameObject.GetComponent<EnemyShooting>().SetWeapon(Weapon);
    }
}
