using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerInfo : MonoBehaviour
{
    private int health;
    public Text textHealth;


    // Start is called before the first frame update
    void Start()
    {
        health = 100;
    }

    void Update()
    {
        display(health);
    }


    public void hurt(int damage)
    {
        health -= damage;
        if (health == 0)
        {
            Debug.Log("THE GAME HAS ENDED");
            SceneManager.LoadScene(2);
            

        }
    }
    public void display(int health)
    {
        textHealth.text = health.ToString();
    }
}
