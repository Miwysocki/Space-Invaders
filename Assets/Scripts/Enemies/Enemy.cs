using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    //to z e
    float timer = 0;
    int numOfMovements = 0;
    float timeToMove;
    float speed;
    int health;
    GameObject body;




    public float Speed { get { return speed; } set { speed = value; } }
    public float TimeToMove { get { return timeToMove; } set { timeToMove = value; } }
   // public int Health { get { return health; } set { health = value; } }
    public GameObject Body { get { return body; } set { body = value; } }
    /// <summary>
    /// /////
    /// </summary>
     public int Health
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
    public IWeapon Weapon
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
        //Health = 1;
      //  enemy = GetComponent<Enemy>();
    //   Health   =  enemy.Health;
        Weapon = new WeaponBlue();
    }

    public void TookDamage(int dmgTaken)
    {
       // Debug.LogWarning(Health);
      //  Debug.LogWarning(dmgTaken);
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
