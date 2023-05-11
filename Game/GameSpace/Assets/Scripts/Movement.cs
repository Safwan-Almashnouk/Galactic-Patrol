using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
    
{
    [SerializeField] float speed;

    public void Update()
    {
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
       
        
            if (transform.position.z >= -11 )
            {

            }
            else
            {
                Vector3 newPosition = new Vector3(transform.position.x, transform.position.y, -11f);
                transform.position = newPosition;
            }

            if (transform.position.z <= 0.80)
            {

            }
            else
            {
                Vector3 newPosition = new Vector3(transform.position.x, transform.position.y, 0.80f);
                transform.position = newPosition;
            }


    }
}
