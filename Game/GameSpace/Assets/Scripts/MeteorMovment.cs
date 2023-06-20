using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorMovment : MonoBehaviour

    
{
<<<<<<< HEAD
=======
    Collider meteor, Frontwall;

>>>>>>> SafwanBranch
    public float speed = 30f;

    private void Start()
    {
        StartCoroutine(SelfDestruct());
<<<<<<< HEAD
=======
        meteor = gameObject.GetComponent<Collider>();
        //Frontwall = GameObject.Find("FrontWall").GetComponent<Collider>();
       // Physics.IgnoreCollision(Frontwall, meteor);

>>>>>>> SafwanBranch
    }
    public void Update()
    {
        transform.position += transform.right * speed * Time.deltaTime;
    }
    IEnumerator SelfDestruct()
    {
<<<<<<< HEAD
        yield return new WaitForSeconds(3f);
        Destroy(gameObject);
    }
=======
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

>>>>>>> SafwanBranch
}
