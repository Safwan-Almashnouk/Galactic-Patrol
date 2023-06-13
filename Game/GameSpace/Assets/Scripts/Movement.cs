using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
    
{
<<<<<<< HEAD
    [SerializeField] float speed;
   
    private Rigidbody obj;
=======
    
   
    private Rigidbody obj;
    public GameObject camera; 
    public float rotate = 250f;
    public float speed= 10;
    Vector3 cameraPos;
    public float endDes = 7;
    public float endDesFr = 7;
    public float endDesBk = 3;
    public float RotPos = 35;
    public float RotSpeed = 10;
>>>>>>> SafwanBranch


    private void Start()
    {
        obj = GetComponent<Rigidbody>();
    }
    public void Update()
    {
<<<<<<< HEAD

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

=======
        Vector3 newPosition = transform.localPosition;
        obj.velocity= new Vector3 (-5, 0, 0 );
        cameraPos = new Vector3(obj.velocity.x * Time.deltaTime + camera.transform.position.x, camera.transform.position.y, camera.transform.position.z);
        camera.transform.position = cameraPos;

        Vector3 slashSpeed = Vector3.zero;
        Vector3 rotation = new Vector3(0,transform.localEulerAngles.y, transform.localEulerAngles.z);

        if (Input.GetKey(KeyCode.A)) 
        {
            slashSpeed.z -= speed;
           rotation.z += RotSpeed * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.D)) 
        {
            slashSpeed.z += speed;
           rotation.z += -RotSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            slashSpeed.x += speed;
        }
        if (Input.GetKey(KeyCode.W))
        {
            slashSpeed.x -= speed;
        }
        
        
        //Rotation 
        if (rotation.z > RotPos && rotation.z < 180)
         {
            
            rotation.z = RotPos;
             
         }
         if(rotation.z < 360-RotPos && rotation.z > 180)
         {
             rotation.z = -RotPos;
             
         }

        
        transform.localEulerAngles = rotation;
        
        //Movmenet 
        slashSpeed.Normalize();
        slashSpeed *= speed * Time.deltaTime;
        newPosition += slashSpeed;


        if (newPosition.x <= cameraPos.x - endDesBk)
        {
            newPosition.x = cameraPos.x - endDesBk;
        }
        if (newPosition.x >= cameraPos.x + endDesFr)
        {
            newPosition.x = (cameraPos.x + endDesFr);
        }
        if (newPosition.z <= -endDes)
        {
            newPosition.z = -endDes;
        }
        if (newPosition.z >= endDes)
        {
            newPosition.z = endDes;
        }

        transform.localPosition = newPosition;
>>>>>>> SafwanBranch
    }

    public void movment()
    {
<<<<<<< HEAD
       
        
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


=======
        //Vector3 newPosition = transform.position;
       
>>>>>>> SafwanBranch
    }
}
