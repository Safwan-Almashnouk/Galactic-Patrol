using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorMovment : MonoBehaviour


{
    Collider meteor, Frontwall;

    public float speed = 30f;

    private void Start()
    {
        StartCoroutine(SelfDestruct());
        meteor = gameObject.GetComponent<Collider>();
       

    }
    public void Update()
    {
        transform.position += transform.right * speed * Time.deltaTime;
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

