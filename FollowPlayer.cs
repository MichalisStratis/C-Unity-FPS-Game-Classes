using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform FirstPerson;

    void LateUpdate()
    {
        Vector3 newpos = FirstPerson.position;
        newpos.y = transform.position.y;
        transform.position = newpos;

        transform.rotation = Quaternion.Euler(90f, FirstPerson.eulerAngles.y, 0f);
    }
}
