using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderScript : MonoBehaviour
{
<<<<<<< HEAD
    private Rigidbody obj;

    // Start is called before the first frame update
=======
  
    public float pushStrength; 
    // Start is called before the first frame update
    private Rigidbody obj;

>>>>>>> SafwanBranch
    void Start()
    {
        obj = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        obj.velocity = new Vector3(-5, 0, 0);
    }

<<<<<<< HEAD
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Meteor(Clone)")
        {
            Destroy(collision.gameObject);
        }
    }
=======

    
    private void OnTriggerStay(Collider other)
    {

        if (other.gameObject.name == "Meteor(Clone)")
        {
            Destroy(other.gameObject);
        }
        else if (other.gameObject.name == "ship")
        {
            other.transform.position = new Vector3(transform.position.x + pushStrength, other.transform.position.y, other.transform.position.z);
        }
    }

>>>>>>> SafwanBranch
}