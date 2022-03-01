using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    
    public static float time = 120.0f;
    public int timerInt;
    public Text texttime;
    void Start()
    {
        time = 120.0f;
    }
    void Update()
    {
       
        time -= Time.deltaTime;
        
        display(time);

        if (time <= 0.0f)
        {
            timerEnded();
        }
    }
    public void display(float time)
    {
        
        texttime.text = Math.Round(time).ToString();
    }
    void timerEnded()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
    }
}
