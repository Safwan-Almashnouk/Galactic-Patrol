using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    //Gun Variables
    public Transform BulletSpawnPosition;
    public GameObject BulletPrefab;
    public AudioSource audioSource;

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
