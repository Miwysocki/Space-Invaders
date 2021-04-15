using UnityEngine;

public interface IWeapon
{
    void Shoot(Transform shooter, bool isEnemyShooter);
}
