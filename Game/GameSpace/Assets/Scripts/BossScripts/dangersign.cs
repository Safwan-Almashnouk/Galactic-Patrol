using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dangersign : MonoBehaviour
{
    public Rigidbody obj;
    
    private float delay= 0.5f;

    void Start()
    {
        obj = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        obj.velocity= new Vector3(-5, 0, 0 );
        Destroy(gameObject, delay);
    }
}
