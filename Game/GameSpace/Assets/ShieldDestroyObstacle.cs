using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldDestroyObstacle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Meteor"))
        {
            Debug.Log("shield");
            Destroy(collision.gameObject);
        }
    }
}
