using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AGUN : MonoBehaviour
{
    public float range = 100f;
    public float damage = 10f;
    public Camera fpscam;
    public GameObject impactE;
    public float impactf = 30f;
    public float firerate = 15f;
    private float nexttimetoshoot = 0f;
    AudioSource sound;
    public ParticleSystem boom;

    void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time >= nexttimetoshoot)
        {
            sound.Play();
            nexttimetoshoot = Time.time + 1f / firerate;
            shoot();

        }
    }
    void shoot()
    {
        boom.Play();
        RaycastHit hit;
        if (Physics.Raycast(fpscam.transform.position, fpscam.transform.forward, out hit, range))
        {

            Debug.Log((hit.transform.name));
            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.takedamage(damage);
            }
            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * impactf);
            }
            GameObject impactgo = Instantiate(impactE, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(impactgo, 2f);

        }
    }
}
