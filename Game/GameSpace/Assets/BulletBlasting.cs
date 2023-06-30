using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBlasting : MonoBehaviour
{
   

    [SerializeField] private Transform BulletSpawnPosition;
    [SerializeField] private GameObject BulletPrefab;
    [SerializeField] private float bulletSpeed = 5;
    [SerializeField] private AudioSource audioSource;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //spawns the bullet
            Instantiate(BulletPrefab, BulletSpawnPosition.position, BulletSpawnPosition.rotation);
            //plays the bullet sound effect
            audioSource.Play();
        }
        
    }
}

