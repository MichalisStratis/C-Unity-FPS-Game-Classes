using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PresentScore : MonoBehaviour
{
   
    public Text score;
    public Text bestscore;

    void Update()
    {
        getscore();
    }
    public void getscore()
    {
        score.text = CheckALLenemies.points.ToString();
        bestscore.text= CheckALLenemies.highscore.ToString();

    } 
    
}
