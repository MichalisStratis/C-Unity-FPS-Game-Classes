using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bullet : MonoBehaviour
{
    public float speed = 100f;
    public int damage = 10;
    
    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerInfo player = other.GetComponent<PlayerInfo>();
        if (player != null)
        {
            player.hurt(damage);

        }
        Destroy(this.gameObject);
    }
}

