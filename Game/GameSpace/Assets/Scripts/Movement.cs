using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
    
{
    [SerializeField] float speed;
   
    private Rigidbody obj;


    private void Start()
    {
        obj = GetComponent<Rigidbody>();
    }
    public void Update()
    {

       obj.velocity= new Vector3 (-5, 0, 0 );
        
        if (Input.GetKey(KeyCode.A)) 
        { 
            transform.position += new Vector3(0, 0, -10 ) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D)) 
        {
            transform.position += new Vector3(0, 0, 10 ) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            
            transform.position += new Vector3(10,0,0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(-10, 0, 0) * Time.deltaTime;
        }

        movment();

    }

    public void movment()
    {
       
        
            if (transform.position.z >= -7 )
            {

            }
            else
            {
                Vector3 newPosition = new Vector3(transform.position.x, transform.position.y, -7f);
                transform.position = newPosition;
            }

            if (transform.position.z <= 7)
            {

            }
            else
            {
                Vector3 newPosition = new Vector3(transform.position.x, transform.position.y, 7);
                transform.position = newPosition;
            }


    }
}
