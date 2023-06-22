using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class DespawnBullet : MonoBehaviour
{
    public float life = 1.5f;
    public GameObject bulletPrefab;
    public GameObject effect; 
    
    float delay = 0.2f;


    public void Awake()
    {
        Destroy(bulletPrefab, life);
    }

    

    
    void OnTriggerEnter(Collider collision)

        
    {
        if (collision.gameObject.name == "Meteor(Clone)")
        {
            Debug.Log("hah");
            Destroy(collision.gameObject);
            Destroy(bulletPrefab, delay);
            GameObject effects = Instantiate(effect,transform.position, Quaternion.identity);
            Destroy(effects, 0.5f);

        }
    }
}
