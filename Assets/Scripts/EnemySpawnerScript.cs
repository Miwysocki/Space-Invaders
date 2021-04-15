using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnemySpawnerScript : MonoBehaviour
{
    public GameObject text;
    public GameObject bonus;
    public static int presentEnemies=-1;
    Difficulty difficulty;
    bool invoked = false;
    int level = 1;
    private  void BuildRowOfEnemies(Director director, int y)
    {
        director.ConstructEnemy(difficulty);
        int x = -8 ;
        
        for ( x =0; x < 15; x +=2) {
            
            GameObject g= Instantiate(director.Enemy.Body, new Vector2(x, y), Quaternion.identity);
            
            Enemy newComp = g.GetComponent<Enemy>() ;

            newComp.Health = director.Enemy.Health;
        }
        
    }

    private void BuildEnemy(Director director,int x, int y) 
    {
        director.ConstructEnemy(difficulty);
        director.Enemy.Body.AddComponent<EnemyConstantMovement>();
        GameObject g = Instantiate(director.Enemy.Body, new Vector2(x, y), Quaternion.identity);

        Enemy newComp = g.GetComponent<Enemy>();

        newComp.Health = director.Enemy.Health;
    }

    void Start()
    {
        difficulty = new Easy();
        text.SetActive(false);
            Level2();
    }

    void Update()
    {
        if (presentEnemies == 0 && !invoked) 
        {
            text.SetActive(true);
            level++;
            if (level == 6) level = 5;
            switch (level)
            {
                case 2:
                    Invoke("Level3", 3);
                    break;
                case 3:

                    Invoke("Level4", 3);
                    break;
                case 4:

                    Invoke("LevelRandom", 3);
                    break;
                case 5:
                    Invoke("LevelRandom", 3);
                    break;
                default:
                    break;
            }
            invoked = true;
        }
    }

    void Level1() 
    {
        Director director = new Director();
        director.EnemyBuilder = new BasiceEnemyBuilder();
        int y = 9;
        BuildRowOfEnemies(director, y);
        y -= 2;
        BuildRowOfEnemies(director, y);
        presentEnemies = 16;
    }



    void Level2()
    {
        PlayerState.score += 1000;
        text.SetActive(false);
        presentEnemies = 10;
        invoked = false;
        Director director = new Director();
        director.EnemyBuilder = new BasiceEnemyBuilder();
        int y = 9;
        BuildRowOfEnemies(director, y);
        y -= 2;
        director.EnemyBuilder = new FasterEnemyBuilder();
        BuildEnemy(director, 5, 6);
        BuildEnemy(director, 3, 6);
    }

    void Level3() 
    {
        difficulty = new Normal();
        PlayerState.score += 2000;
        text.SetActive(false);
        presentEnemies = 24;
        invoked = false;
        Director director = new Director();
        director.EnemyBuilder = new BasiceEnemyBuilder();
        int y = 9;
        BuildRowOfEnemies(director, y);
        y -= 2;
        director.EnemyBuilder = new FasterEnemyBuilder();
        BuildRowOfEnemies(director, y);
        y -= 2;
        director.EnemyBuilder = new TankEnemyBuilder();
        BuildRowOfEnemies(director, y);
    }

    void Level4()
    {
        PlayerState.score += 3000;
        text.SetActive(false);
        presentEnemies = 11;
        invoked = false;
        Director director = new Director();
        director.EnemyBuilder = new TankEnemyBuilder();
        int y = 9;
        BuildRowOfEnemies(director, y);
        y -= 2;
        director.EnemyBuilder = new FasterEnemyBuilder();
        BuildEnemy(director, 5, 9);
        BuildEnemy(director, 0, 6);
        BuildEnemy(director, 3, 9);
    }

    void LevelRandom() 
    {
        difficulty = new Hard();
        PlayerState.score += 500;
        text.SetActive(false);
        presentEnemies = 10;
        invoked = false;
        Director director = new Director();
        director.EnemyBuilder = new FasterEnemyBuilder();

        System.Random rnd = new System.Random(); 
        int random = rnd.Next(1, 4);
        if(random == 1) director.EnemyBuilder = new FasterEnemyBuilder();
        if (random == 2) director.EnemyBuilder = new BasiceEnemyBuilder();
        if (random == 3) director.EnemyBuilder = new TankEnemyBuilder();

        int y = 9;
        BuildRowOfEnemies(director, y);

        presentEnemies = 8;

        random = rnd.Next(1, 4);
        for(int i = 0; i< random;i++)
         {
            int randomX = rnd.Next(1, 5);
            int randomY = rnd.Next(6, 9);
            BuildEnemy(director, randomX, randomY);
            presentEnemies++;
               }

         int randX = rnd.Next(5, 9);
         int randY = rnd.Next(3, 9);
        Instantiate(bonus, new Vector2(randX, randY), Quaternion.identity);

        invoked = false;
    }


    /*
        director.EnemyBuilder = new FasterEnemyBuilder();
        BuildRowOfEnemies(director, y);
        y -= 2;

        director.EnemyBuilder = new TankEnemyBuilder();
        BuildRowOfEnemies(director, y);
     */
}
