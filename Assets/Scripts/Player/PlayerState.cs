using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerState : MonoBehaviour
{
    public TextMeshProUGUI asd;

    private static int _score;
    public static int score
    {
        get
        {
            return _score;
        }
        set
        {
            _score = value;
            UpdateCanvasScore();
        }
    }

    public static int _health;
    public static int health
    {
        get
        {
            return _health;
        }
        set
        {
            _health = value;
            UpdateCanvasHP();
        }
    }

    public static int movementSpeed;

    public GameObject[] missilePrefab;
    public static IWeapon weapon;

    public void Start()
    {
        score = 0;
        health = 100;
        movementSpeed = 5;
        weapon = new WeaponBlue();
    }

    public void TookDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Destroy(gameObject);
            GameController gc = GameController.Instance;
            gc.AddHighScore(score);
            gc.SetState(new MenuScene());
            gc.HandleState();
        }
    }

    private static void UpdateCanvasHP()
    {
        TextMeshProUGUI tmp = null;
        GameObject go = GameObject.FindGameObjectWithTag("HP");
        if (go != null) tmp = go.GetComponent<TextMeshProUGUI>();
        if (tmp != null) tmp.text = string.Format("Health: {0}", health);
    }
    
    private static void UpdateCanvasScore()
    {
        TextMeshProUGUI tmp = null;
        GameObject go = GameObject.FindGameObjectWithTag("SCORE");
        if (go != null) tmp = go.GetComponent<TextMeshProUGUI>();
        if (tmp != null) tmp.text = string.Format("Score: {0}", score);
    }
}
