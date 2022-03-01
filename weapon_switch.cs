using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon_switch : MonoBehaviour
{

    public int currentweapon = 0;
    public static float timerallow;
    
   
    void Start()
    {
        currentWp();

    }

    
    void Update()
    {
        timerallow = Timer.time;
        int previousWp = currentweapon;
        if(timerallow<60 && Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            if (currentweapon >= transform.childCount - 1)
                currentweapon = 0;
            else 
                currentweapon++;
        }

        if (timerallow < 60 && Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            if (currentweapon <= 0)
                currentweapon = transform.childCount-1;

            else
                currentweapon--;
        }

     
        if (previousWp != currentweapon)
        {
            currentWp();

        }

    }

    void currentWp()
    {
        int i = 0;
        foreach (Transform weapon in transform)
        {
            if (i == currentweapon)
                weapon.gameObject.SetActive(true);
            else
                weapon.gameObject.SetActive(false);
            i++;
        
        }
    }
}
