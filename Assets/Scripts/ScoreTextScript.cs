using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTextScript : MonoBehaviour
{
    public Text ScoreText;

    private void Start()
    {
        ScoreText = GetComponent<Text>();
    }

    void Update()
    {
        ScoreText.text = "Score:" + PlayerState.score.ToString();
    }
}
