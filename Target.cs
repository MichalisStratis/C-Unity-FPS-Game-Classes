using UnityEngine;
using UnityEngine.SceneManagement;


public class Target : MonoBehaviour
{
    public float health = 50f;
    
    public bool alive;
    public float speed = 10f;
    public float obstaclerange = 5f;
    public float current;

    public GameObject bulletprefab;
    public GameObject bullet;


    private void Start()
    {
        alive = true;
    }

    public void Update()
    {
        
        if (alive)
            
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
        
        }
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        if(Physics.SphereCast(ray,5f,out hit))
        {
            GameObject hitobject = hit.transform.gameObject;
            if (hitobject.GetComponent<PlayerInfo>())
            {
                if (bullet == null)
                {
                    bullet = Instantiate(bulletprefab) as GameObject;
                    bullet.transform.position = transform.TransformPoint(Vector3.forward * 5f);
                    bullet.transform.rotation = transform.rotation;

                
                }
                
            }
            else if (hit.distance < obstaclerange || hitobject.GetComponent<PlayerInfo>())
            {
                float angle = Random.Range(-110, 110);
                transform.Rotate(0, angle, 0);
            }
        }
    }
    public void takedamage(float amount)
    {
        current = health;
        health -= amount;
        if (health < current)
        {
            float angle = Random.Range(-110, 110);
            transform.Rotate(0, angle, 0);
        }
        if (health <= 0f)
        {
            die();
           
        }
    }
    void die()
    {
        Destroy(gameObject);
        
    }

    
}
