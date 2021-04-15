using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    private GameController gameController;

    void Start()
    {
        gameController = GameController.Instance;
    }


    public void OnClickPlay()
    {
        gameController.SetState(new GameplayScene());
        gameController.HandleState();
    }

    public void OnClickHighscores()
    {
        gameController.SetState(new HighscoreScene());
        gameController.HandleState();
    }

    public void OnClickCredits()
    {
        gameController.SetState(new CreditsScene());
        gameController.HandleState();
    }
    
    public void OnClickExit()
    {
        Application.Quit();
    }

    
}
