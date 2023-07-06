using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBlasting : MonoBehaviour
{
   

    [SerializeField] private Transform BulletSpawnPosition;
    [SerializeField] private GameObject BulletPrefab;
    [SerializeField] private float bulletSpeed = 5;
    [SerializeField] private AudioSource audioSource;
    private float gunheat;
    private float delay = 1.5f;


    // Update is called once per frame
    void Update()
    {
        gunheat -= Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (gunheat <= 0)
            {
                gunheat= 0.25f;
                //spawns the bullet
                Instantiate(BulletPrefab, BulletSpawnPosition.position, BulletSpawnPosition.rotation);
                //plays the bullet sound effect
                audioSource.Play();
            }
           
        }
        
    }

    

  
}

