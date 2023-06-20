using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour

{


    private Rigidbody obj;
    public GameObject camera;
    public float rotate = 250f;
    public float speed = 10;
    Vector3 cameraPos;
    public float endDes = 7;
    public float endDesFr = 12;
    public float endDesBk = 7;
    public float RotPos = 35;
    public float RotSpeed = 10;
    public float InputX;



    private void Start()
    {
        obj = GetComponent<Rigidbody>();
    }
    public void Update()
    {
        InputX = Input.GetAxisRaw("Horizontal");

        Vector3 newPosition = transform.localPosition;
        //Quaternion ogpos = transform.localRotation(0, 0, 0);
        obj.velocity = new Vector3(-5, 0, 0);
        cameraPos = new Vector3(obj.velocity.x * Time.deltaTime + camera.transform.position.x, camera.transform.position.y, camera.transform.position.z);
        camera.transform.position = cameraPos;

        Vector3 slashSpeed = Vector3.zero;
        Vector3 rotation = new Vector3(0, transform.localEulerAngles.y, transform.localEulerAngles.z);


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

        if (InputX == 0)
        {
            if (RotPos > 0)
            {
                rotation.z -= RotSpeed * Time.deltaTime;
            }
            if (RotPos < 0)
            {
                rotation.z -= RotSpeed * Time.deltaTime;
            }
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
        if (rotation.z < 360 - RotPos && rotation.z > 180)
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
    }

    public void movment()
    {
        //Vector3 newPosition = transform.position;

    }
}