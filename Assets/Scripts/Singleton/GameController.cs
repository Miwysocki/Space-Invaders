using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class GameController
{
    IGameScene scene;

    private static GameController _instance;
    public static GameController Instance
    {
        get
        {
            if (_instance == null) _instance = new GameController();
            return _instance;
        }
        private set { }
    }

    public List<int> highscores { get; private set; }

    private GameController() 
    {
        highscores = new List<int>();
    }

    
    public void SetState(IGameScene gameScene)
    {
        scene = gameScene;
    }

    public void HandleState()
    {
        scene.SetScene();
    }

    public void AddHighScore(int value)
    {
        highscores.Add(value);

        highscores.Sort();
        highscores.Reverse();

        if (highscores.Count > 10)
        {
            highscores.Remove(highscores.Last());
        }
        
    }
}

