using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundSpawer : MonoBehaviour
{
    public GameObject prefab;
    Vector3 spawnPosition;
    private void Start()
    {
         spawnPosition = new Vector3(transform.position.x - 1, transform.position.y, transform.position.z);
    }


    private void OnTriggerEnter(Collider other)
    {
       
        Instantiate(prefab, spawnPosition, Quaternion.Euler(-90, 270, -180));
        Destroy(transform.parent.gameObject, 10f);
    }
}
