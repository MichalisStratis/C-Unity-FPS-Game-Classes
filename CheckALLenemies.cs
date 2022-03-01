using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CheckALLenemies : MonoBehaviour
{
    public int enemies;
    public Text textScore;
    public static int highscore;
    public Text highscoreText;

    public int current=14;
    public static int points;
    void Start()
    {
        points = 0;
    }
    void Awake()
    {
        highscore = PlayerPrefs.GetInt("highscore");
    }
    void Update()
    {
        display(points);
        enemies = transform.childCount;
        if (enemies<current)
        {
            current--; 
            points += 5;
            
        }

        if (points > highscore)
        {
            highscore = points;
            PlayerPrefs.SetInt("highscore", highscore);
            Debug.Log(highscore);
        }
        if (enemies < 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }


 
    }

    public void display(int health)
    {
        textScore.text = points.ToString();
    }
}
