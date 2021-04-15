using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    void Update()
    {
        Shooting();
    }

    private void Shooting()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayerState.weapon.Shoot(transform, false);
        }
    }
}
