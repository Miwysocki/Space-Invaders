using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsManager : MonoBehaviour
{
    private GameController gameController;
    void Start()
    {
        gameController = GameController.Instance;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            gameController.SetState(new MenuScene());
            gameController.HandleState();
        }
    }
}
