using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighscoreManager : MonoBehaviour
{
    public GameObject prefab;
    private GameController gameController;
    void Start()
    {
        gameController = GameController.Instance;
        GameObject go = GameObject.FindGameObjectWithTag("Highscore");
        GameObject holder;
        for (int i=0; i<gameController.highscores.Count; i++)
        {
            holder = Instantiate(prefab, go.transform);
            var comps = holder.GetComponentsInChildren<TextMeshProUGUI>();
            comps[0].text = (i+1).ToString() + ". ";
            comps[1].text = gameController.highscores[i].ToString();
        }
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
