using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//abstract builder
abstract class EnemyBuilder 
{
    protected Enemy enemy;
    public Enemy Enemy { get { return enemy; } }

    public void CreateNewEnemy() { enemy = new Enemy(); }
    public abstract void SetSpeed(Difficulty difficulty);
    public abstract void SetTimeToMove();
    public abstract void SetHealth(Difficulty difficulty);
    public abstract void SetBody();
}

//concrete builders
class BasiceEnemyBuilder : EnemyBuilder
{
    public GameObject basicBody;

  

    public override void SetBody()
    {

        basicBody = Resources.Load("RedOrb") as GameObject;
        enemy.Body = basicBody;
    }
   
    public override void SetHealth(Difficulty difficulty)
    {
        enemy.Health = difficulty.ScaleHP(20);
    }

    public override void SetSpeed(Difficulty difficulty) { enemy.Speed = 0.25f; }

    public override void SetTimeToMove()
    {
        enemy.TimeToMove = 0.5f;
    }

}

class FasterEnemyBuilder : EnemyBuilder
{
    
    GameObject fasterBody;
    public override void SetBody()
    {
        fasterBody = Resources.Load("FastEnemy") as GameObject;
        enemy.Body = fasterBody;
    }
    

    public override void SetHealth(Difficulty difficulty)
    {
        enemy.Health = difficulty.ScaleHP(10);
    }

    public override void SetSpeed(Difficulty difficulty) { enemy.Speed = 0.50f; }

    public override void SetTimeToMove()
    {
        enemy.TimeToMove = 0.5f;
    }

}

class TankEnemyBuilder : EnemyBuilder
{
    GameObject tankBody;
    public override void SetBody()
    {
        tankBody = Resources.Load("TankEnemy") as GameObject;
        enemy.Body = tankBody;
    }
  
    public override void SetHealth(Difficulty difficulty)
    {
        enemy.Health = difficulty.ScaleHP(30);
    }
    
    public override void SetSpeed(Difficulty difficulty) { enemy.Speed = 0.25f; }

    public override void SetTimeToMove()
    {
        enemy.TimeToMove = 0.5f;
    }

}

/** "Director" */
 class Director
{
    private EnemyBuilder enemyBuilder;

    public EnemyBuilder EnemyBuilder
    {
        get { return enemyBuilder; }
        set { enemyBuilder = value; }
    }
    public Enemy Enemy { get { return enemyBuilder.Enemy; } }


    public void ConstructEnemy(Difficulty difficulty)
    {
        enemyBuilder.CreateNewEnemy();
        enemyBuilder.SetSpeed( difficulty);
        enemyBuilder.SetTimeToMove();
        enemyBuilder.SetHealth( difficulty);
        enemyBuilder.SetBody();
    }
}