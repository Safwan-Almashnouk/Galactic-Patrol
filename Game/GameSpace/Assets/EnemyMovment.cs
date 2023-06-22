using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovment : MonoBehaviour
{
   
    Collider enemy, Frontwall;
    private Rigidbody obj;
    public float speed = 7f;
    public bool GoingRight = true;


    private void Start()
    {
        StartCoroutine(SelfDestruct());
        enemy = gameObject.GetComponent<Collider>();
        obj = GetComponent<Rigidbody>();


    }
    public void Update()
    {
        obj.velocity = new Vector3(-5, 0, 0);

        
        if (transform.position.z >= 7)
        {
            if(GoingRight) {
                speed = -speed;
                GoingRight = false;
            }
            
        } 
        if (transform.position.z <= -7) 
        {
            if (!GoingRight)
            {
                speed = -speed;
                GoingRight = true;
            }
        }
        transform.position += new Vector3(0, 0, speed) * Time.deltaTime;
    }
    IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(10);
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Border"))
        {
            Destroy(gameObject);
        }
    }

}
