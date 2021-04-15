using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountingDeaths : MonoBehaviour
{
    private void OnDestroy()
    {
            EnemySpawnerScript.presentEnemies--;
        PlayerState.score += 10;
    }
}
