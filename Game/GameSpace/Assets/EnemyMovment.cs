using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class EnemyMovment : MonoBehaviour
{

    Collider enemy, Frontwall;
    private Rigidbody rb;
    private float speed = 4f;
    
    public GameObject target;

    private void Start()
    {

        target = GameObject.Find("ship");
        enemy = gameObject.GetComponent<Collider>();
        rb = GetComponent<Rigidbody>();
        
        




    }
    public void Update()
    {
        if (target.transform.position.z < transform.position.z - 0.5)
        {

            rb.velocity = new Vector3(rb.velocity.x, 0, -speed);
        }
        else if (target.transform.position.z > transform.position.z + 0.5)
        {

            rb.velocity = new Vector3(rb.velocity.x, 0, speed);
        }
        else
        {
            rb.velocity = new Vector3(rb.velocity.x, 0, 0);
        }


        rb.velocity = new Vector3(-5, 0, rb.velocity.z);
        
    }
    

}
