using UnityEngine;

public class MissileControl : MonoBehaviour
{
    public int missileSpeed = 3;
    public int timeTillDetroy = 2;

    private float instantiateTime;
    private int damage; //Damage of player in moment of shooting
    private bool isEnemyShooter;

    private void Start()
    {
        instantiateTime = Time.time;
    }

    void Update()
    {
        if (isEnemyShooter)
        {
            transform.position += new Vector3(0, -missileSpeed, 0) * Time.deltaTime;
            if (Time.time >= instantiateTime + timeTillDetroy) Destroy(gameObject);
        }
        else
        {
            transform.position += new Vector3(0, missileSpeed, 0) * Time.deltaTime;
            if (Time.time >= instantiateTime + timeTillDetroy) Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (isEnemyShooter)
        {
            if (collision.gameObject.CompareTag("Enemy"))
            {
                Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
            }
            else if (collision.gameObject.CompareTag("Player"))
            {
                collision.gameObject.GetComponent<PlayerState>().TookDamage(damage);
                Destroy(gameObject);
            }
        }
        else
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
            }
            else if (collision.gameObject.CompareTag("Enemy"))
            {
                collision.gameObject.GetComponent<Enemy>().TookDamage(damage);
                Destroy(gameObject);
            }
        }
    }

    public void SetShooter(bool _iEnemyShooter)
    {
        isEnemyShooter = _iEnemyShooter;
    }

    public void SetMissileDamage(int _damage)
    {
        damage = _damage;
    }
}
