using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorMovment : MonoBehaviour

    
{
    public float speed = 30f;
    public void Update()
    {
        transform.position += transform.right * speed * Time.deltaTime;
    }
}
