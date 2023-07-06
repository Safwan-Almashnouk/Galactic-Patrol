using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazarBeam : MonoBehaviour
{
    private Rigidbody obj;
    private float delay = 4f;
    void Start()
    {
        obj = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        obj.velocity= new Vector3(30, 0 , 0);
        Destroy(gameObject, delay);
    }

    private void OnTriggerEnter(Collider other)
    {
        if  (other.gameObject.CompareTag("Bullet"))
        {
            Destroy(other.gameObject);
        }
    }
}
