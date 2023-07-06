using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletMovement : MonoBehaviour
{
    private CapsuleCollider cd;
    public float bulletSpeed;

    // Update is called once per frame

    private void Start()
    {
          
    }
    void Update()
    {
        transform.position += new Vector3(bulletSpeed, 0, 0) * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Meteor")
        {
            Physics.IgnoreCollision(gameObject.GetComponent<Collider>(), GetComponent<Collider>());
        }
    }
}
