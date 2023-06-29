using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class DespawnBullet : MonoBehaviour
{
    [SerializeField] private float life = 1f;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private GameObject effect;
    [SerializeField] private AudioSource expolosion;
    
    float delay = 3f;


    public void Awake()
    {
        Destroy(bulletPrefab, life);
    }

    private void OoogaBooga()
    {
        expolosion.Play();
    }

    
    void OnTriggerEnter(Collider collision)

        
    {
        if (collision.gameObject.name == "Meteor(Clone)")
        {
            Debug.Log("hah");
            Destroy(collision.gameObject);
            GetComponent<Renderer>().enabled = false;
            GetComponent<CapsuleCollider>().enabled = false;
            OoogaBooga();
            GameObject effects = Instantiate(effect,transform.position, Quaternion.identity);
            Destroy(effects, 0.5f);
            Destroy(bulletPrefab, delay);


        }
    }
}
