using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public CharacterController controler;

    public float speed = 12f;
    public float gravity = -9.81f;
    Vector3 velocity;

    public Transform gcheck;
    public float gdistance = 0.4f;
    public LayerMask gmask;

    bool isg;

    public float jheight = 10f;


    // Update is called once per frame
    void Update()
    {
        isg = Physics.CheckSphere(gcheck.position, gdistance, gmask);

        if(isg && velocity.y<0)
        {
            velocity.y = -2f;
        }
        float x = Input.GetAxis("Horizontal");

        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controler.Move(move * speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isg)
        {
            velocity.y = Mathf.Sqrt(jheight * -2 * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controler.Move(velocity * Time.deltaTime);



    }
}
