using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPos : MonoBehaviour
{

    Transform target;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("ship").GetComponent<Transform>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(-5, 0, 0);
    }
}

